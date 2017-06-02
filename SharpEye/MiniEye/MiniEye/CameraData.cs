using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniEye.Views;
using Settings;

namespace MiniEye
{

    public interface ICameraData : IGlobalData
    {
        string CameraName { get; set; }
        string SelectedCameraName { get; set; }
    }
}
