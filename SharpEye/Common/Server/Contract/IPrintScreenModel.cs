using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IPrintScreenModel
    {
        string HostName { set; get; }
        event Action<float> Progress;
        event Action<byte[], string> Created;
        event Action<string> SendMessage;
        void CreateLiveScreen(ICameraModel camera);
    }
}
