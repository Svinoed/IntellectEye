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
    class PrintScreenModel : IPrintScreenModel
    {
        // Содержит токен подключения к серверу
        private LoginSettings _loginSettings; 

        public PrintScreenModel()
        {
            // здесь получаем адрес сервера из конфигурации
            string server =  "http://217.18.157.5";
            _loginSettings = LoginSettingsCache.GetLoginSettings(server);
        }

        public bool CreateScreen(DateTime dateTime, ICameraModel camera, string directory, string fileName)
        {
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
                return false;
            }

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
                return false;
            }

            // Подготавливаемся к ответу
            int maxbuf = 1024 * 500; // Задаем размер буфера
            Byte[] bytesReceived = new Byte[maxbuf];
            int bytes = PrintScreenUtils.RecvUntilCrLfCrLf(sock, bytesReceived, 0, maxbuf);

            if (bytes == 0)
            {
                return false;
            }

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
                return false;
            }

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
                return false;
            }

            bool gotImage = false;
            while(!gotImage)
            {
                bytes = PrintScreenUtils.RecvUntilCrLfCrLf(sock, bytesReceived, 0, maxbuf);
                if (bytes == 0)
                {
                    return false;
                }

                stringReceived = Encoding.UTF8.GetString(bytesReceived, 0, bytes);
                Console.WriteLine(stringReceived);

                // Находим заглловок изображения
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
                    return false;
                }

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

                Byte[] jpeg = new Byte[lengthJpegData];

                Array.Copy(bytesReceived, startJpegData, jpeg, 0, lengthJpegData);
                string fName = fileName + ".jpg"; 
                string fullFileName = Path.Combine(directory, fName);
                File.WriteAllBytes(fullFileName, jpeg);
                return true;
            }
            return true;
        }
    }
}
