﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using View.Interfaces;
using System.Windows.Forms;

namespace View.Interfaces
{
    public interface IVideoView
    {
        Panel VideoPanel { set; get; }

        event Action CreatePrintScreen;
        event Action CreateBookMarker;
        event Action CreateComment;
        event Action Back;

        event Action Up;
        event Action UpLeft;
        event Action UpRight;
        event Action Down;
        event Action DownLeft;
        event Action DownRight;
        event Action ToRight;
        event Action ToLeft;
        event Action Home;
        event Action<float> ZoomIn;
        event Action<float> ZoomOut;


        // Продумывается
        event Action VolumeChanged;
    }
}