using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Model.Utils
{
    class PrintScreenUtils
    {

        #region ToIpv4
        public static IPAddress ToIpv4(string dns)
        {
            IPAddress ipaddr;
            byte[] nullip = { 0, 0, 0, 0 };

            try
            {
                ipaddr = IPAddress.Parse(dns);
                return ipaddr;
            }
            catch(Exception)
            {
                try
                {
                    ipaddr = null;
                    IPHostEntry ent = Dns.GetHostEntry(dns);

                    foreach (IPAddress addr in ent.AddressList)
                    {
                        if (addr.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipaddr = addr;
                            return ipaddr;
                        }
                    }
                    return new IPAddress(nullip);
                }
                catch
                {
                    return new IPAddress(nullip);
                }
            }
        }
        #endregion

        #region RecvUntilCrLfCrLf
        public static int RecvUntilCrLfCrLf(Socket socket, byte[] buf, int offset, int size)
        {
            int miss = size;
            int got = 0;
            int bytes = 0;
            int retry = 100;
            int ended = 4;
            int i = 0;

            while (got < size && ended > 0 && retry > 0)
            {
                i = offset + got;
                bytes = socket.Receive(buf, i, 1, SocketFlags.None); // читаем по байтно

                if (bytes == 1)
                {
                    if (buf[i] == '\r' || buf[i] == '\n')
                    {
                        ended--;
                    }
                    else
                    {
                        ended = 4;
                    }
                    got += bytes;
                    miss -= bytes;
                }

                if (socket.Available == 0)
                {
                    System.Threading.Thread.Sleep(100);
                    retry--;
                }
            }

            if (got > size)
            {
                throw new Exception("Buffer overflow");
            }

            if (ended == 0)
            {
                return got;
            }
            else
            {
                return -got;
            }
            
        }
        #endregion

        #region Parse header
        public static ImageInfo ParseHeader(byte[] buf, int offset, int bytes)
        {
            ImageInfo imageInfo = new ImageInfo();
            imageInfo.Length = 0;
            imageInfo.Type = "";
            string response = Encoding.UTF8.GetString(buf, offset, bytes);
            string[] headers = response.Split('\n');
            foreach(string header in headers)
            {
                string[] keyval = header.Split(':');
                if (keyval[0].ToLower() == "content-length" && keyval.Length > 1)
                {
                    imageInfo.Length = int.Parse(keyval[1]);
                }

                if (keyval[0].ToLower() == "content-type" && keyval.Length > 1)
                {
                    imageInfo.Type = keyval[1].Trim('\r').ToLower();
                }
                if (keyval[0].ToLower() == "current" && keyval.Length > 1)
                {
                    imageInfo.Current = keyval[1].Trim('\r');
                }
                if (keyval[0].ToLower() == "next" && keyval.Length > 1)
                {
                    imageInfo.Next = keyval[1].Trim('\r');
                }
                if (keyval[0].ToLower() == "prev" && keyval.Length > 1)
                {
                    imageInfo.Prev = keyval[1].Trim('\r');
                }
            }
            return imageInfo;
        }
        #endregion

        #region Recv Fixed Length
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sock"></param>
        /// <param name="buf"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int RecvFixedLenth(Socket sock, byte[] buf, int offset, int size)
        {
            int miss = size;
            int got = 0;
            int bytes = 0;
            int get = 1;
            int maxb = 1024 * 16;

            do
            {
                get = miss > maxb ? maxb : miss;
                bytes = sock.Receive(buf, offset + got, get, SocketFlags.None);
                got += bytes;
                miss -= bytes;
            }
            while (got < size);

            if (got > size)
            {
                throw new Exception("Buffer overflow");
            }

            if (size < 4)
            {
                return -got;
            }

            int i = offset + got - 4;
            if (buf[i] == '\r' && buf[i + 1] == '\n' && buf[i +2] == '\r' && buf[i + 3] == '\n')
            {
                return got;
            }

            return -got;
        }
        #endregion

    }

    public class ImageInfo
    {
        public int Length;
        public string Type;
        public string Current;
        public string Next;
        public string Prev;

        public ImageInfo()
        {
            Length = -1;
            Type = "";
            Current = "";
            Next = "";
            Prev = "";
        }
    }
}
