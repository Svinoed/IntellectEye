using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IInitialModel
    {
        /// <summary>
        /// Используйте этот метод если вам необходимо
        /// инициализировать что-то во время запуска приложения
        /// </summary>
        void Init();
    }
}
