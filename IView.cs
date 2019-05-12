using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Nix.Metro
{
    public interface IView 
    {
        //Visual Host { get; set; }
        MetroData MetroData { get; set; }
        void ProcessIdle(double top, double bottom, double tempo, double current, double barStart, double cycleStart, double cycleEnd);
        void Resize(int width, int height);
        int Width { get; }
        int Height { get; }

    }
}
