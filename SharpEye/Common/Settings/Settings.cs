using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System;
using System.Collections.Generic;

namespace Settings
{
    /// <summary>
    /// Тип авторизации: базовый пользователь,
    /// пользователь Windows
    /// </summary>
    public enum Authorization
    {
        Basic,
        Windows
    }

    /// <summary>
    /// Интерфейс, определяющие глобальные настройки
    /// </summary>
    public interface IGlobalData
    {
        [JsonProperty]
        string ServerName { get; set; }
        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        Authorization AuthType { get; set; }
        [JsonProperty]
        string Login { get; set; }
        [JsonProperty]
        string Password { get; set; }
    }
    /// <summary>
    /// Необходима реализация данного интерфейса всем, кто связан с настройками для получения оповещений
    /// </summary>
    public interface ISettingsListener
    {
        /// <summary>
        /// Метод вызываемый при изменении настроек
        /// </summary>
        void SettingsChanged(IGlobalData settings);
    }
    
    interface INotifier
    {
        void AddListener(ISettingsListener listener);
        void NotifyAll();
        void RemoveListener(ISettingsListener listener);
    }


    /// <summary>
    /// Интерфейс определяющий поведение настроек
    /// </summary>
    public interface ISettings : IGlobalData
    {
        void Load();
        void Save();
        string GetPath();
    }

    /// <summary>
    /// Базовый класс настроек
    /// </summary>
    public class Settings : ISettings, INotifier
    {
        private static string _FilePath = Environment.CurrentDirectory + "\\settings.json";
        private static Settings _Instance = null;
        private bool _IsDirty = false;
        private string _ServerName;
        private Authorization _AuthType;
        private string _Login;
        private string _Password;



        //Список всех объектов, которые нужно оповестить при изменении настроек
        private List<ISettingsListener> _Listeners;

        //Создает список слушателей
        private Settings()
        {
            _Listeners = new List<ISettingsListener>();
        }

        /// <summary>
        /// Возвращает объект настроек, при необходимости создавая его. НЕ является потокобезопасным!!!
        /// </summary>
        public static Settings GetSettings()
        {
            if (_Instance == null)
            {
                _Instance = new Settings();
                if (File.Exists(_FilePath))
                    _Instance.Load();
                else
                {
                    //Загрузить настройки по умолчанию и создать на основе их файл
                    InitializeDefault();
                    _Instance.Save();
                }
            }
            return _Instance;
        }
        /// <summary>
        /// Отражает состояние настроек, т.е. были ли произведены изменения в настройках,
        /// которые еще не сохранены в файл
        /// </summary>
        public bool IsSettingsDirty()
        {
            return _IsDirty;
        }

        private static void InitializeDefault()
        {
            _Instance._ServerName = "localhost";
            _Instance._AuthType = Authorization.Basic;
            _Instance._Login = "user";
            _Instance._Password = "password";
        }
        /// <summary>
        /// Тип авторизации пользователя
        /// </summary>
        public Authorization AuthType
        {
            get { return _AuthType; }
            set
            {
                _AuthType = value;
            }
        }
        /// <summary>
        /// Логин пользователя для подключения к Milestone
        /// </summary>
        public string Login
        {
            get { return _Login; }
            set
            {
                _Login = value;
            }
        }
        /// <summary>
        /// Пароль пользователя для подключения к Milestone.
        /// Внимание! Пароль хранится в открытом виде
        /// </summary>
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
            }
        }
        /// <summary>
        /// Адрес сервера Milestone для подключения
        /// </summary>
        public string ServerName
        {
            get { return _ServerName; }
            set
            {
                _ServerName = value;
            }
        }
        /// <summary>
        /// Возвращает путь до файла глобальных настроек
        /// </summary>
        public string GetPath()
        {
            return _FilePath;
        }
        /// <summary>
        /// Загружает настройки из файла
        /// </summary>
        public void Load()
        {
            try
            {
                // Десериализация JSON из файла
                using (StreamReader file = File.OpenText(_FilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    _Instance = (Settings)serializer.Deserialize(file, typeof(Settings));
                }
            }
            catch (FileNotFoundException)
            {
                //Если файл не найден, то создать его на основе текущего объекта
                Save();
            }

        }

        public void Save()
        {
            // Сериализация JSON напрямую в файл
            using (StreamWriter file = File.CreateText(_FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this);
            }
        }
        /// <summary>
        /// Добавить слушателя, который будет оповещен при изменении настроек
        /// </summary>
        public void AddListener(ISettingsListener listener)
        {
            _Listeners.Add(listener);
        }
        /// <summary>
        /// Оповещает всех слушателей об изменении настроек
        /// </summary>
        public void NotifyAll()
        {
            foreach (var item in _Listeners)
            {
                item.SettingsChanged(this);
            }
        }
        /// <summary>
        /// Отписывает слушателя от рассылки уведомлений
        /// </summary>
        public void RemoveListener(ISettingsListener listener)
        {
            _Listeners.Remove(listener);
        }
    }
}
