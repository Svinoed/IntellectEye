using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    /// <summary>
    /// Определяет результат завершения процесса соеденинения с сервером.
    /// </summary>
    public enum ConnectStatus
    {
        NotConnected,
        Undefined,
        Ok,
        ServerNotFound,
        IncorrectPassOrLogin
    }
}
