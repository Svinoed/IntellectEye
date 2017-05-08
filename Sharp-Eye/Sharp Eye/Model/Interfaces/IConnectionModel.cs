using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Utils;

namespace Model.Interfaces
{
    /// <summary>
    /// Задает необходимый функцонал соединения.
    /// </summary>
    public interface IConnectionModel
    {
        ConnectStatus Status { set; get; }
        event Action Done;

        void Connect( string server, string login, string password);
    }
}
