using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;
using Model.Interfaces;
using Presenter.Interfaces;


namespace Presenter
{
    /// <summary>
    ///  Презентер авторизации. 
    ///  Управляет контролом авторизации и объектом соединения.
    /// </summary>
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView _view;
        private IConnectionModel _connectModel;
        public event Action Connected;

        public LoginPresenter(ILoginView view, IConnectionModel connectModel)
        {
            if (view != null && connectModel != null)
            {
                this._view = view;
                this._connectModel = connectModel;
                _view.Login += () => login();
                _connectModel.Done += () => done();
            }
            else
            {
                throw new Exception("Null point");
            }
            
        }


        private void login()
        {
            if (_view.Server != null)
                Connect();
        }


        private void done()
        {
            switch(_connectModel.Status)
            {
                case Model.Utils.ConnectStatus.Ok:
                    Connected();
                    break;
                case Model.Utils.ConnectStatus.ServerNotFound:
                    _view.ShowConError("Неправильное имя сервера");
                    _view.Show();
                    break;
                case Model.Utils.ConnectStatus.IncorrectPassOrLogin:
                    _view.ShowConError("Неправильный логин или пароль");
                    _view.Show();
                    break;
                case Model.Utils.ConnectStatus.Undefined://Нужен ли здесь обработчик?
                    _view.Show();
                    break;
            }
        }

        public void Connect()
        {
            try
            {
                _connectModel.Connect(_view.Server, _view.UserName, _view.Password);
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
