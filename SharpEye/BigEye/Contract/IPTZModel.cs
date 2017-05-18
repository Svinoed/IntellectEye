using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IPTZModel
    {
        ICameraModel Camera { set; get; }

        void Home();

        void Down();
        void DownLeft();
        void DownRight();
        
        void Up();
        void UpLeft();
        void UpRight();

        void Left();
        void Right();

        void ZoomIn(float zoom);
        void ZoomOut(float zoom);
    }
}
