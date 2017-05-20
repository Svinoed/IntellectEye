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

        public void Connect()
        {
            try
            {
                _loginModel.Connect(_view.Server, _view.UserName, _view.Password);
                //Если дошли до сюда то подключение выполнено
                Connected();
            }
            catch(Exception undefined)
            {
                _view.ShowConError(undefined.Message);
                _view.Show();
            }
        }

        public ILoginView GetView()
        {
            return this._view;
        }
    }
}
