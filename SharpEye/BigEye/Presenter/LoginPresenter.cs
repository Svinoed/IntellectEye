using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;
using Contract;
using Presenter.Interfaces;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Presenter
{
    /// <summary>
    ///  Презентер авторизации. 
    ///  Управляет контролом авторизации и объектом соединения.
    /// </summary>
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView _view;
        [Import(typeof(ILoginModel))]
        public ILoginModel _loginModel;
        public event Action Connected;

        public LoginPresenter(ILoginView view)
        {
            ComposContainer.Instance().Compose(this);
            if (view != null)
            {
                this._view = view;
                _view.Login += () => login();
                _loginModel.Done += () => done();
            }
            else
            {
                throw new Exception("Null point");
            }
            
        }


        private void login()
        {
            ComposContainer.Instance().Compose(this);
            if (_view.Server != null)
                Connect();
        }


        private void done()
        {
            switch(_loginModel.Status)
            {
                case Contract.ConnectStatus.Ok:
                    Connected();
                    break;
                case Contract.ConnectStatus.ServerNotFound:
                    _view.ShowConError("Неправильное имя сервера");
                    _view.Show();
                    break;
                case Contract.ConnectStatus.IncorrectPassOrLogin:
                    _view.ShowConError("Неправильный логин или пароль");
                    _view.Show();
                    break;
                case Contract.ConnectStatus.Undefined://Нужен ли здесь обработчик?
                    _view.Show();
                    break;
            }
        }

        public void Connect()
        {
            try
            {
                _loginModel.Connect(_view.Server, _view.UserName, _view.Password);
            }
            catch(Exception undefined)
            {
                _view.ShowConError(undefined.Message);
            }
        }

        public ILoginView GetView()
        {
            return this._view;
        }
    }
}
