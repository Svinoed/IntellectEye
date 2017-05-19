using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniEye.Views;
using Settings;

namespace MiniEye
{

    public interface ICameraData : IGlobalData
    {
        string CameraName { get; set; }
        string DefaultSelectedCamera { get; set; }
    }
    /// <summary>
    /// Класс модели настроек
    /// </summary>
    class CameraData : ICameraData
    {
        public Authorization AuthType { get; set; }

        public string CameraName { get; set; }

        public string DefaultSelectedCamera { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string ServerName { get; set; }

        public static ICameraData GetDefaultSettings()
        {
            //Загрузить настройки по умолчанию
            CameraData localData = new CameraData();
            localData.AuthType = Settings.Settings.GetSettings().AuthType;
            localData.Login = Settings.Settings.GetSettings().Login;
            localData.Password = Settings.Settings.GetSettings().Password;
            localData.ServerName = Settings.Settings.GetSettings().ServerName;
            localData.DefaultSelectedCamera = "";
            localData.CameraName = "";
            return localData;
        }

    }
}
