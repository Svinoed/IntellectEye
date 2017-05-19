using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;
using System.Reflection;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.OLE.Interop;
using System.Runtime.InteropServices.ComTypes;
using System.ComponentModel;
using Settings;

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
            MessageBox.Show("Register successfull");
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
            MessageBox.Show("UnRegister successfull");
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

        private Views.CameraSettings _ViewSettings = null;
        private Views.Preview _ViewPreview = null;
        private SDK.IConnection _ModelConnection = null;
        private SDK.ICameras _ModelCameras = null;
        private SDK.ILiveStream _ModelLiveStream = null;

        [Browsable(false)]
        //[Description(""), Category("Data")]
        public bool _IsStateSaved { get; set; }

        public string CameraName { get; set; }

        public string DefaultSelectedCamera { get; set; }

        public string ServerName { get; set; }

        public Authorization AuthType { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }



        #endregion

        /// <summary>
        /// Создает все объекты
        /// </summary>
        public MiniEye()
        {
            ///Восстановление состояния объекта проихсодит после вызова конструктора!
            #region style settings
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
            cameraButton.BackColor = Color.Transparent;
            #endregion

            //Загрузка данных по умолчанию
            this.AuthType = Settings.Settings.GetSettings().AuthType;
            this.Login = Settings.Settings.GetSettings().Login;
            this.Password = Settings.Settings.GetSettings().Password;
            this.ServerName = Settings.Settings.GetSettings().ServerName;
            this.DefaultSelectedCamera = "";
            this.CameraName = "";
            //Инициализация работы с SDK
            SDK.InitializeSDK.Initialize();

            //Создание всех представлений
            _ViewSettings = new Views.CameraSettings(this);
            _ViewPreview = new Views.Preview(this);

            //Создание всех моделей
            _ModelConnection = new SDK.Connection();
            _ModelCameras = new SDK.Cameras();
            _ModelLiveStream = new SDK.LiveStream();
            
            //Подключить необходимые обработчики событий для представлений
            _ViewSettings.OnCheckConnection += _ViewSettings_OnCheckConnection;
            _ViewSettings.OnGetCameraRequest += _Settings_OnGetCameraRequest;
            _ViewSettings.OnSettingsApplyed += _ViewSettings_OnSettingsApplyed1;

            //Подключить необходимые обработчики событий для моделей
            _ModelLiveStream.ImageIsReady += _ModelLiveStream_ImageIsReady;

        }

        private void _ModelLiveStream_ImageIsReady(Bitmap picture)
        {
            _ViewPreview.SetPicture(picture);
        }

        /// <summary>
        /// Проверка подключения к серверу
        /// </summary>
        private void _ViewSettings_OnCheckConnection(string server, Authorization authType, string login, string password)
        {
            _ModelConnection.Connect(server, login, password, authType);
        }

        /// <summary>
        /// При нажатии на кнопку применения настроек
        /// </summary>
        private void _ViewSettings_OnSettingsApplyed1(ICameraData data)
        {
            _IsStateSaved = true; //Сохранить состояние контрола

            //TODO: реализовать проверку данных
            this.AuthType = data.AuthType;
            this.Login = data.Login;
            this.Password = data.Password;
            this.ServerName = data.ServerName;
            this.DefaultSelectedCamera = data.DefaultSelectedCamera;
            this.CameraName = data.CameraName;

            _ViewSettings.Hide();
            _ViewPreview.SetSettings(this);//Установить обновленные данные


            //Настроить соединение с камерой
            if(!_ModelLiveStream.ChangeCamera(this.DefaultSelectedCamera, _ViewPreview.Width, _ViewPreview.Height))
                MessageBox.Show("Невозможно установить камеру");
            _ViewPreview.Show();
        }

        /// <summary>
        /// Запустить компонент
        /// </summary>
        private void cameraButton_Click(object sender, EventArgs e)
        {
            if (!_IsStateSaved)
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
                _ViewPreview.SetSettings(this);
                //Настроить соединение с камерой
                if (!_ModelLiveStream.ChangeCamera(this.DefaultSelectedCamera, _ViewPreview.Width, _ViewPreview.Height))
                    MessageBox.Show("Невозможно установить камеру");
                _ViewPreview.Show();
            }
        }
        /// <summary>
        /// Реализация получения списка камер
        /// </summary>
        private List<string> _Settings_OnGetCameraRequest()
        {
            return _ModelCameras.GetAll();
        }
    }
}
