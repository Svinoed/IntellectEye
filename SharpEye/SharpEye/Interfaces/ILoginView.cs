﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Interfaces
{
    /// <summary>
    /// С помощью данного интерфейса презентер взаимодействует с формой авторизации.
    /// </summary>
    public interface ILoginView : IView
    {
        string Server { set; get; }
        string UserName { set; get; }
        string Password { set; get; }
        bool RememberPassword { set; get; }
        bool AutoLogin { set; get; }
        event Action Login;

        void ShowConError(string message);

        ILoginView GetView();
    }
}
