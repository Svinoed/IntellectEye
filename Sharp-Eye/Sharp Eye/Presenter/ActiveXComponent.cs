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
using Model;
using View.Interfaces;

namespace Presenter
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("ACD5AC4F-AA7A-41A9-8E72-A2575E86AEFB")]
    public partial class ActiveXComponent : UserControl
    {

        private ILoginPresenter _loginPresenter;
        private IMainPresenter _mainPresenter;


        public ActiveXComponent()
        {
            InitializeComponent();           
        }

        public void LoadLoginView(ILoginView view)
        {
            UserControl loginView = (UserControl)view;
            // Устанавливаем контрол по центру
            loginView.Left = (this.ClientSize.Width - loginView.Width) / 2;
            loginView.Top = (this.ClientSize.Height - loginView.Height) / 2;
            this.Controls.Clear();
            this.Controls.Add(loginView);
        }


        public void LoadMainView(IMainView view)
        {
            UserControl mainView = (UserControl)view;
            mainView.Width = this.ClientSize.Width;
            mainView.Height = this.ClientSize.Height;
            this.Controls.Clear();
            this.Controls.Add(mainView);
        }

        private void ConnectionCompleted()
        {
            _mainPresenter = new MainPresenter(new MainControl());
            LoadMainView(_mainPresenter.GetView());

            _mainPresenter.Run();
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

        private void ActiveXComponent_Load(object sender, EventArgs e)
        {
            EntityCreator.Initialize();

            _loginPresenter = new LoginPresenter(new LoginControl(), EntityCreator.ConnectionModelBuild());
            _loginPresenter.Connected += () => ConnectionCompleted();

            LoadLoginView(_loginPresenter.GetView());
            _loginPresenter.Connect();
        }
    }
}
