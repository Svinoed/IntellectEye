using Microsoft.Win32;
using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Settings;
using Contract;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using VideoOS.Platform.Client;
using VideoOS.Platform;

namespace MiniEye
{
    //[ComSourceInterfaces(typeof(IMiniEye))]               //Предоставление COM событий
    [ProgId("MiniEye")]
    [Guid(MiniEye._Guid)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class MiniEye : UserControl, ICameraData         //Наследование от ICameraData для сохранения настроек с помощью IPersistStorage
    {
        #region Register ActiveX
        [ComRegisterFunction()]
        public static void RegisterCOM(string key)
        {
            // Strip off HKEY_CLASSES_ROOT\ from the passed key as I don't need it
            StringBuilder sb = new StringBuilder(key);

            sb.Replace(@"HKEY_CLASSES_ROOT\", "");
            // Open the CLSID\{guid} key for write access
            RegistryKey k = Registry.ClassesRoot.OpenSubKey(sb.ToString(), true);

            // And create	the	'Control' key -	this allows	it to show up in
            // the ActiveX control container
            RegistryKey ctrl = k.CreateSubKey("Control");
            ctrl.Close();
            RegistryKey insertb = k.CreateSubKey("Insertable");
            insertb.Close();

            // Next create the CodeBase entry	- needed if	not	string named and GACced.
            RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);
            inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase);
            inprocServer32.Close();
            // Finally close the main	key
            k.Close();
        }

        ///	<summary>
        ///	Called to unregister the control
        ///	</summary>
        ///	<param name="key">Tke registry key</param>
        [ComUnregisterFunction()]
        public static void Unregister(string key)
        {
            StringBuilder sb = new StringBuilder(key);
            sb.Replace(@"HKEY_CLASSES_ROOT\", "");

            // Open	HKCR\CLSID\{guid} for write	access
            RegistryKey k = Registry.ClassesRoot.OpenSubKey(sb.ToString(), true);

            // Delete the 'Control'	key, but don't throw an	exception if it	does not exist
            k.DeleteSubKey("Control", false);

            k.DeleteSubKey("Insertable", false);


            // Next	open up	InprocServer32
            //RegistryKey	inprocServer32 = 
            k.OpenSubKey("InprocServer32", true);

            // And delete the CodeBase key,	again not throwing if missing
            k.DeleteSubKey("CodeBase", false);

            // Finally close the main key
            k.Close();
        }
        #endregion

        #region Designer
        private Button cameraButton;
        private void InitializeComponent()
        {
            this.cameraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cameraButton
            // 
            this.cameraButton.AutoSize = true;
            this.cameraButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cameraButton.BackgroundImage = global::MiniEye.Properties.Resources.Camera256;
            this.cameraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraButton.FlatAppearance.BorderSize = 0;
            this.cameraButton.Location = new System.Drawing.Point(0, 0);
            this.cameraButton.Margin = new System.Windows.Forms.Padding(0);
            this.cameraButton.MaximumSize = new System.Drawing.Size(256, 256);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(64, 64);
            this.cameraButton.TabIndex = 0;
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // MiniEye
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.cameraButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(64, 64);
            this.Name = "MiniEye";
            this.Size = new System.Drawing.Size(64, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Properties
        private const string _Guid = "9E86F8DE-0BF3-4762-B936-33D0A8C2BC01";
        //Объекты отображения
        private Views.CameraSettings _ViewSettings = null;
        private Views.Preview _ViewPreview = null;


        //Объекты необходимые для работы с сервером видео
        [Import(typeof(ILoginModel))]
        private ILoginModel _ModelConnection;
        [Import]
        private IInitialModel _ModelInitialization;
        [Import(typeof(ICameraManagerModel))]
        private ICameraManagerModel _ModelCameraManager;
        [Import(typeof(ISerializable))]
        private ISerializable _ModelSerializeDevice;
        [Import(typeof(IVideoModel))]
        private IVideoModel _ModelLiveStream;

        #region Save state properties
        [Browsable(false)]
        //[Description(""), Category("Data")]
        public bool IsStateSaved { get; set; }

        public string CameraName { get; set; }

        public string SelectedCameraName { get; set; }

        public string ServerName { get; set; }

        public Authorization AuthType { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
        //Свойства могут быть сохранены только в виде примитивных типов, поэтому камера
        //конвертируется в строку
        public string SelectedCamera = null;
        #endregion


        #endregion

        /// <summary>
        /// Создает все объекты
        /// </summary>
        public MiniEye()
        {
            ///Восстановление состояния объекта проихсодит после вызова конструктора!
            #region set visual style
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
            cameraButton.BackColor = Color.Transparent;
            #endregion

            #region setup default user data
            this.AuthType = Settings.Settings.GetSettings().AuthType;
            this.Login = Settings.Settings.GetSettings().Login;
            this.Password = Settings.Settings.GetSettings().Password;
            this.ServerName = Settings.Settings.GetSettings().ServerName;
            this.SelectedCameraName = "";
            this.CameraName = "";
            #endregion

            #region video server initializaion
            //Искать части проекта в директории где лежит проект
            //TODO: добавить обработку исключений в случае если части программы не найдены
            CompositionContainer container = new CompositionContainer(new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.ToString())));
            container.ComposeParts(this);
            _ModelInitialization.Init();
            #endregion

            //Создание всех представлений
            _ViewSettings = new Views.CameraSettings(this);
            _ViewPreview = new Views.Preview(this);
            
            //Подключить необходимые обработчики событий для представлений
            _ViewSettings.OnCheckConnection += _ViewSettings_OnCheckConnection;
            _ViewSettings.OnGetCameraRequest += _Settings_OnGetCameraRequest;
            _ViewSettings.OnSettingsApplyed += _ViewSettings_OnSettingsApplyed;
            _ViewSettings.OnCameraSelected += _ViewSettings_OnCameraSelected;
        }

        /// <summary>
        /// Обработчик выполняющий перехват выбранной камеры и сохраняющий ее в свойствах
        /// Камера при этом для сохранения предварительно конвертируется в строку
        /// </summary>
        private void _ViewSettings_OnCameraSelected(object camera)
        {
            this.SelectedCamera = _ModelSerializeDevice.Serialize((ICameraModel)camera);
        }

        /// <summary>
        /// Проверка подключения к серверу
        /// </summary>
        private void _ViewSettings_OnCheckConnection(string server, Authorization authType, string login, string password)
        {
            //TODO: Добавить тип авторизации при необходимости
            _ModelConnection.Connect(server, login, password);
            switch (_ModelConnection.Status)
            {
                case ConnectStatus.Ok:
                    break;
                case ConnectStatus.ServerNotFound:
                    throw new Exception("Не удается найти сервер. Проверьте адрес подключения");
                case ConnectStatus.IncorrectPassOrLogin:
                    throw new Exception("Логин/пароль введены неверно");
                default:
                    throw new Exception("Неизвестная ошибка при подключении");
            }
        }

        /// <summary>
        /// При нажатии на кнопку применения настроек
        /// </summary>
        private void _ViewSettings_OnSettingsApplyed(ICameraData data)
        {
            IsStateSaved = true; //Сохранить состояние контрола
            this.AuthType = data.AuthType;
            this.Login = data.Login;
            this.Password = data.Password;
            this.ServerName = data.ServerName;
            this.SelectedCameraName = data.SelectedCameraName;
            this.CameraName = data.CameraName;
            _ViewSettings.Hide();
            InitializePreview();    //Привязать камеру к окну просмотра и показать пользователю
        }

        /// <summary>
        /// Запустить компонент
        /// </summary>
        private void cameraButton_Click(object sender, EventArgs e)
        {
            if (!IsStateSaved)
            {
                //Загрузка всех параметров по-умолчанию
                _ViewSettings.Show();
            }
            else
            {
                //Настройки автоматически восстанавливаются при использовании IPersistStorage
                //методы которого вызываются контейнером
                _ViewSettings.SetSettings(this);
                if (_ViewPreview.IsDisposed || _ViewPreview == null)
                    _ViewPreview = new Views.Preview(this);
                InitializePreview();    //Привязать камеру к окну просмотра и показать пользователю
            }
        }
        /// <summary>
        /// Реализация получения списка камер
        /// </summary>
        private List<object> _Settings_OnGetCameraRequest()
        {
            List<object> listCamera = new List<object>();
            foreach (var camera in _ModelCameraManager.GetCameras())
                listCamera.Add(camera);
            return listCamera;
        }
        private void InitializePreview()
        {
            //Установить обновленные данные
            _ViewPreview.Text = this.CameraName;
            //Нужно сначала показать пользователю форму, после чего вставлять в нее видео
            _ViewPreview.Show();
            //Привязка отображения к камере
            try
            {
                //ICameraModel camera = _ModelCameraManager.GetCameras().Find(cam => cam.Name.Equals(SelectedCameraName));
                ICameraModel camera = _ModelSerializeDevice.Deserialize(SelectedCamera);

                MessageBox.Show("Test");
                _ModelLiveStream.SetVideoStreamInPanel(camera, _ViewPreview._VideoPanel);
            }
            catch (Exception err)
            {
                IsStateSaved = false;
                MessageBox.Show($"Ошибка при установке камеры {err.Message}");
            }
        }

    }
}
