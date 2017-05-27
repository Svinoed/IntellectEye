using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Model.Utils;
using VideoOS.Platform.Login;
using System.Net.Sockets;
using VideoOS.Platform;
using System.Diagnostics;
using System.Net;
using System.Xml;
using System.IO;
using System.ComponentModel.Composition;

namespace Model
{
    [Export(typeof(IPrintScreenModel))]
    public class PrintScreenModel : IPrintScreenModel
    {
        // Содержит токен подключения к серверу
        private LoginSettings _loginSettings;
        private string _hostName;
        public string HostName
        {
            set
            {
                _hostName = value;
                _loginSettings = LoginSettingsCache.GetLoginSettings(_hostName);
            }
            get
            {
                return _hostName;
            }
        }
        public event Action<float> Progress;
        public event Action<byte[], string> Created;
        public event Action<string> SendMessage;

        private const string CONNECTION_FAILED = "Не удалось открыть соединение";
        private const string NO_CON_REQUEST = "Неудалось отправить запрос подключения к серверу";
        private const string NO_CON_RESPONSE = "Нет ответа подключения от сервера";
        private const string AUTH_FAILED = "Аутетификация не прошла";
        private const string NO_CREATE_IMG_REQUEST = "Запрос создания изображения не отправлен";
        private const string NO_CREATE_IMG_RESPONSE = "Ответ создания изображения не получен";
        private const string UNCORRECT_RESPONSE_IMG = "Получен не верный формат данных";

        public void CreateLiveScreen(ICameraModel camera)
        {
            if (Created == null || SendMessage == null)
            {
                throw new NullReferenceException("Created or SendMessage is null");
            }
            Socket sock;
            string hostName = "";
            Item cameraItem = Configuration.Instance.GetItem(camera.Id);
            string token = _loginSettings.Token;
            Debug.WriteLine("Camera Id: " + cameraItem.FQID.ToString());
            try
            {
                Item recoder = cameraItem.GetParent();
                hostName = recoder.Properties["Address"];
                int port = 80; // По умолчаю задаем 80 порт
                Int32.TryParse(recoder.Properties["Port"], out port);

                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipe = new IPEndPoint(PrintScreenUtils.ToIpv4(hostName), port);
                sock.Connect(ipe);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Не удалось открыть соединение: {0}", e.Message);
                SendMessage?.Invoke(CONNECTION_FAILED);
                return;
            }
            Progress?.Invoke(0.14f);

            //Строим запрос запрос в формате «Image Server API»
            string sendString = string.Format(
                     "<?xml version=\"1.0\" encoding=\"utf-8\"?><methodcall><requestid>0</requestid>" +
                     "<methodname>connect</methodname><username></username><password></password>" +
                     "<cameraid>{0}</cameraid><alwaysstdjpeg>yes</alwaysstdjpeg>" +
                     "<connectparam>id={1}&amp;connectiontoken={2}" +
                     "</connectparam></methodcall>\r\n\r\n",
                     cameraItem.FQID.ObjectId, cameraItem.FQID.ObjectId, token);

            // Конвертируем запрос в UTF 8 и отправляем его
            Byte[] bytesToSend = Encoding.UTF8.GetBytes(sendString);
            int bs = sock.Send(bytesToSend, bytesToSend.Length, 0); // bs -чисто отправленных байтов
            if (bs != bytesToSend.Length)
            {
                SendMessage(NO_CON_REQUEST);
                return;
            }
            Progress?.Invoke(0.28f);
            // Подготавливаемся к ответу
            int maxbuf = 1024 * 500; // Задаем размер буфера
            Byte[] bytesReceived = new Byte[maxbuf];
            int bytes = PrintScreenUtils.RecvUntilCrLfCrLf(sock, bytesReceived, 0, maxbuf);

            if (bytes == 0)
            {
                SendMessage(NO_CON_RESPONSE);
                return;
            }
            Progress?.Invoke(0.42f);
            string stringReceived = Encoding.UTF8.GetString(bytesReceived, 0, bytes);

            // Смотрим выполнилось соединение
            bool authenticated = false;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(stringReceived);
            XmlNodeList nodes = doc.GetElementsByTagName("connected");
            foreach(XmlNode node in nodes)
            {
                if (node.InnerText.ToLower() == "yes")
                {
                    authenticated = true;
                }
            }

            if (!authenticated)
            {
                SendMessage(AUTH_FAILED); 
                return;
            }
            Progress?.Invoke(0.60f);
            // Cтроим запрос LIVE запрос
            sendString = string.Format("<?xml version=\"1.0\" encoding=\"utf-8\"?><methodcall><requestid>1</requestid>" +
                "<methodname>live</methodname>" +
                // "<sendinitialimage>no</sendinitialimage>" +
                "<compressionrate>80</compressionrate>" +
                "</methodcall>\r\n\r\n"
                );

            bytesToSend = Encoding.UTF8.GetBytes(sendString);
            bs = sock.Send(bytesToSend, bytesToSend.Length, 0);
            if (bs != bytesToSend.Length)
            {
                SendMessage(NO_CREATE_IMG_REQUEST); ;
                return;
            }
            Progress?.Invoke(0.74f);
            bool gotImage = false;
            while(!gotImage)
            {
                bytes = PrintScreenUtils.RecvUntilCrLfCrLf(sock, bytesReceived, 0, maxbuf);
                if (bytes == 0)
                {
                    SendMessage(NO_CREATE_IMG_RESPONSE);
                    return;
                }

                stringReceived = Encoding.UTF8.GetString(bytesReceived, 0, bytes);
                Console.WriteLine(stringReceived);

                // Находим загловок изображения
                if (bytesReceived[0] != 'I')
                {
                    continue;
                }

                ImageInfo h = PrintScreenUtils.ParseHeader(bytesReceived, 0, bytes);
                int expectedSize = h.Length + 4;
                if (expectedSize > maxbuf)
                {
                    maxbuf = expectedSize;
                    bytesReceived = new Byte[maxbuf];
                }

                bytes = PrintScreenUtils.RecvFixedLenth(sock, bytesReceived, 0, expectedSize);
                sock.Close();

                if (!(bytes == expectedSize || bytes == - expectedSize))
                {
                    SendMessage(UNCORRECT_RESPONSE_IMG);
                    return;
                }
                Progress?.Invoke(0.92f);

                int startJpegData = -1;
                int lengthJpegData = -1;

                if (bytesReceived[0] == 0xFF && bytesReceived[1] == 0xD8)
                {
                    startJpegData = 0;
                    lengthJpegData = h.Length;
                }
                else
                {
                    // There is a 36 bytes "Milestone Generic-Byte-Data" header in front of the JPEG
                    if (bytesReceived[36] == 0xFF && bytesReceived[37] == 0xD8)
                    {
                        startJpegData = 36;
                        lengthJpegData = h.Length - 36;
                    }
                }

                if (startJpegData == -1)
                {
                    break;
                }
                Progress?.Invoke(1.0f);
                Byte[] jpeg = new Byte[lengthJpegData];
                Array.Copy(bytesReceived, startJpegData, jpeg, 0, lengthJpegData);
                Created?.Invoke(jpeg, "jpeg");
                return;
            }
        }
    }
}
