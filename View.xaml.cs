using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nix.Metro
{



    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class View : UserControl, IView
    {
        private ViewModel _vm;
        public View()
        {
            InitializeComponent();
            DataContext = _vm = new ViewModel();
        }

        public MetroData MetroData { get; set; }

        public void ProcessIdle(double top, double bottom, double tempo, double current, double barStart, double cycleStart, double cycleEnd)
        {
            _vm.ProcessIdle(top, bottom, tempo, current, barStart, cycleStart, cycleEnd);
        }

        public void Resize(int width, int height)
        {
            base.Width = width;
            base.Height = height;
            _vm.Message = "dleta!";
        }


        public new int Width
        {
            get { return (int)base.Width; }
        }

        public new int Height
        {
            get { return (int)base.Height; }
        }

      
    }
}
