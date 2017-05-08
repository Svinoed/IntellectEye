﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using Model.Utils;
using VideoOS.Platform;
using VideoOS.Platform.Data;
using VideoOS.Platform.Live;
using VideoOS.Platform.SDK.Platform;

namespace Model
{
    public class ConnectionModel : IConnectionModel
    {
        public ConnectStatus Status { get { return _status; } set { this._status = value; } }
        public event Action Done;
        private ConnectStatus _status = ConnectStatus.Undefined;
        public void Connect(string server, string login, string password)
        {
            //На этом этапе мы уверены, что введённые данные правильные?
            if (!server.StartsWith("http://", true, null)) server = "http://" + server;
            Uri uri = new UriBuilder(server).Uri;
            CredentialCache cc = VideoOS.Platform.Login.Util.BuildCredentialCache(uri, login, password, "Basic");
            VideoOS.Platform.SDK.Environment.AddServer(uri, cc);
            try
            {
                VideoOS.Platform.SDK.Environment.Login(uri);
                //Должно работать, Exception вылетит на первой же строчке, если что-то не так
                Status = ConnectStatus.Ok;
            }
            catch (ServerNotFoundMIPException)
            {
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                Status = ConnectStatus.ServerNotFound;
            }
            catch (InvalidCredentialsMIPException)
            {
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                Status = ConnectStatus.IncorrectPassOrLogin;
            }
            catch (Exception undefined)//Как реагировать на другие ошибки?
            {
                //Дописать обработку ошибки
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                throw new Exception(undefined.Message);
            }
            finally
            {
                Done();
            }
        }
    }
}
