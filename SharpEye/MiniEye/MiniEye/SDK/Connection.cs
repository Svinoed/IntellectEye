using System;
using Settings;
using System.Net;
using VideoOS.Platform;
using VideoOS.Platform.Data;
using VideoOS.Platform.Live;
using VideoOS.Platform.SDK.Platform;


namespace MiniEye.SDK
{
    public interface IConnection
    {
        //Возвращает true если подключение к серверу успешно
        void Connect(string url, string login, string password, Settings.Authorization authType);
    }


    public static class InitializeSDK
    {
        private static int _Count = 0;
        public static void Initialize()
        {
            if (_Count > 0) return;
            else
            {
                //TODO: во время подключения инициализируется весь SDK
                VideoOS.Platform.SDK.Environment.Initialize();

                VideoOS.Platform.SDK.UI.Environment.Initialize();

                VideoOS.Platform.SDK.Media.Environment.Initialize();
                
                _Count++;
            }
        }
    }


    public class Connection : IConnection
    {
        public Connection(){}

        public void Connect(string url, string login, string password, Settings.Authorization authType)
        {
            
            Uri uri = new UriBuilder(url).Uri;
            if (VideoOS.Platform.SDK.Environment.IsLoggedIn(uri))
            {
                VideoOS.Platform.SDK.Environment.Logout();
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
            }

            NetworkCredential nc;
            switch (authType)
            {
                //Раскомментировать, когда появятся настройки пользователя по умолчанию
                /*case Settings.Authorization.DefaultWindows:
                    nc = CredentialCache.DefaultNetworkCredentials;
                    VideoOS.Platform.SDK.Environment.AddServer(uri, nc);
                    break;*/
                case Settings.Authorization.Windows:
                    nc = new NetworkCredential(login, password);
                    VideoOS.Platform.SDK.Environment.AddServer(uri, nc);
                    break;
                case Settings.Authorization.Basic:
                    CredentialCache cc = VideoOS.Platform.Login.Util.BuildCredentialCache(uri, login, password, "Basic");
                    VideoOS.Platform.SDK.Environment.AddServer(uri, cc);
                    break;
            }
            //Попытка авторизации
            try
            {
                VideoOS.Platform.SDK.Environment.Login(uri);
            }
            catch (ServerNotFoundMIPException)
            {
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                throw new Exception("Проверьте имя сервера");
            }
            catch (InvalidCredentialsMIPException)
            {
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                throw new Exception("Проверьте имя пользователя и пароль");

            }
            catch (Exception)
            {
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                throw new Exception("Ошибка подключения к серверу");
            }
            //Если дошли до сюда и нет Exception значит все круто
        }
    }
}
