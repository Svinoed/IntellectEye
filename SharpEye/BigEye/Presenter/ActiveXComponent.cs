using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;
using Presenter.Interfaces;
using View;
using View.Interfaces;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Contract;

namespace Presenter
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("ACD5AC4F-AA7A-41A9-8E72-A2575E86AEFB")]
    public partial class ActiveXComponent : UserControl
    {
        private ILoginPresenter _loginPresenter;
        private IMainPresenter _mainPresenter;
        private IVideoPresenter _videoPresenter; // Контрол для одной камеры

        [Import]
        private IInitialModel _initModel;


        public ActiveXComponent()
        {
            InitializeComponent();
            //this.Dock = DockStyle.Fill;
        }

        private void LoadLoginView(ILoginView view)
        {
            UserControl loginView = (UserControl)view;
            // Устанавливаем контрол по центру
            //loginView.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right) | System.Windows.Forms.AnchorStyles.Left); 
            loginView.Left = (this.ClientSize.Width - loginView.Width) / 2;
            loginView.Top = (this.ClientSize.Height - loginView.Height) / 2;
            this.Controls.Clear();
            this.Controls.Add(loginView);
        }


        private void LoadMainView(IMainView view)
        {
            UserControl mainView = (UserControl)view;
            mainView.Width = this.ClientSize.Width;
            mainView.Height = this.ClientSize.Height;
            this.Controls.Clear();
            this.Controls.Add(mainView);
        }

        private void ReSize()
        {
            if(Controls.Contains((UserControl)_loginPresenter.GetView()))
            {
                UserControl loginView = (UserControl) _loginPresenter.GetView();
                loginView.Left = (this.ClientSize.Width - loginView.Width) / 2;
                loginView.Top = (this.ClientSize.Height - loginView.Height) / 2;
            }
            if ( _mainPresenter != null && Controls.Contains((UserControl)_mainPresenter.GetView()))
            {
                UserControl mainView = (UserControl) _mainPresenter.GetView();
                mainView.Width = this.ClientSize.Width;
                mainView.Height = this.ClientSize.Height;
            }

            if (_videoPresenter != null && Controls.Contains((UserControl) _videoPresenter.GetView()))
            {
                UserControl mainView = (UserControl)_videoPresenter.GetView();
                mainView.Width = this.ClientSize.Width;
                mainView.Height = this.ClientSize.Height;
            }
        }

        private void ConnectionCompleted()
        {
            _mainPresenter = new MainPresenter(new MainControl(), ShowVideoControl);
            LoadMainView(_mainPresenter.GetView());
            _mainPresenter.Run();
        }

        /// <summary>
        /// Показать контрол для одной камеры
        /// </summary>
        private void ShowVideoControl(ICameraModel camera)
        {
            _mainPresenter.SetVisible(false);
            UserControl videoControl = (UserControl)_videoPresenter.GetView();
            videoControl.Dock = DockStyle.Fill;
            this.Controls.Add(videoControl);
            _videoPresenter.Camera = camera;
        }

        private void CloseVideoControl()
        {
            this.Controls.Remove((UserControl) _videoPresenter.GetView());
            _mainPresenter.SetVisible(true);
        }

        private void ActiveXComponent_Load(object sender, EventArgs e)
        {
            ComposContainer.Instance().Compose(this);

            _initModel.Init();

            _loginPresenter = new LoginPresenter(new LoginControl());
            _loginPresenter.Connected += ConnectionCompleted;

            LoadLoginView(_loginPresenter.GetView());
            //_loginPresenter.Connect();

            _videoPresenter = new VideoPresenter(new CameraViewer(), CloseVideoControl);
        }

        #region ComReg

        [ComRegisterFunction]
        public static void RegisterClass(string key)
        {
            var trimedkey = TrimRegKey(key);
            RegistryKey k = null;
            try
            {
                // Открываем ключ CLSID\{guid} в режиме записи
                k = Registry.ClassesRoot.OpenSubKey(trimedkey, true);
                if (k == null)
                {
                    MessageBox.Show(@"Error HKEY_CLASSES_ROOT\CLSID\" + key);
                    return;
                }

                // Создаем ключ элемента управления ActiveX – это позволяет ему появиться
                //в контейнере элемента управления ActiveX
                RegistryKey ctrl = k.CreateSubKey("Control");
                ctrl.Close();

                RegistryKey insertb = k.CreateSubKey("Insertable");
                insertb.Close();

                // Создаем запись CodeBase
                RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);
                inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase);
                inprocServer32.Close();

                MessageBox.Show(key + "\r\n Reg OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(key + "\r\nUnReg Error\r\n" + ex);
                throw;
            }
            finally
            {
                if (k != null) k.Close();
            }
        }

        [ComVisible(false)]
        private static string TrimRegKey(string key)
        {
            // Удаляем HKEY_CLASSES_ROOT\ из переданного ключа
            return key.Replace(@"HKEY_CLASSES_ROOT\", "");
        }

        [ComUnregisterFunction]
        public static void UnregisterClass(string key)
        {
            var trimedkey = TrimRegKey(key);

            RegistryKey k = null;
            try
            {
                // Открываем ключ HKCR\CLSID\{guid} в режиме записи
                k = Registry.ClassesRoot.OpenSubKey(trimedkey, true);

                if (k == null)
                {
                    MessageBox.Show(@"Error HKEY_CLASSES_ROOT\CLSID\" + key);
                    return;
                }

                k.DeleteSubKey("Control", false);
                k.DeleteSubKey("Insertable", false);
                // Затем открываем ключ InprocServer32
                RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);

                // Удаляем ключ CodeBase
                k.DeleteSubKey("CodeBase", false);
                inprocServer32.Close();

                MessageBox.Show(key + "\r\nUnReg OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(key + "\r\nUnReg Error\r\n" + ex);
                throw;
            }
            finally
            {
                if (k != null) k.Close();
            }
        }

        #endregion

        private void ActiveXComponent_Paint(object sender, PaintEventArgs e)
        {
            //ReSize();
        }
    }
}
