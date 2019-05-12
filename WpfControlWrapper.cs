using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.RightsManagement;
using System.Text;

namespace Nix.Metro
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Interop;
    using System.Drawing;

    /// <summary>
    /// Helper class to attach a WPF UserControl to a Win32 native main window of the host.
    /// </summary>
    /// <typeparam name="T">The type of the managed WPF Control.</typeparam>
    public class WpfControlWrapper 
    {
        private HwndSource _hwndSource;
        private int _width;
        private int _height;

        /// <summary>
        /// Constructs a new instance for the specified <paramref name="width"/> and <paramref name="height"/>.
        /// </summary>
        /// <param name="width">The width of the control.</param>
        /// <param name="height">The height of the control.</param>
        public WpfControlWrapper(int width, int height)
        {
            _width = width;
            _height = height;
        }

        private IView _instance;
        /// <summary>
        /// Gets and instance of the specified <typeparamref name="T"/>.
        /// </summary>
        /// <remarks>Can return null.</remarks>
        public IView Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// Opens and attaches the Control to the <paramref name="hWnd"/>.
        /// </summary>
        /// <param name="hWnd">The native win32 handle to the main window of the host.</param>
        public void Open(IntPtr hWnd)
        {
            _instance = new View();
            _instance.Resize(_width , _height);
            HwndSourceParameters hwndParams = new HwndSourceParameters("VST.NET Wpf Editor");
            hwndParams.ParentWindow = hWnd;
            hwndParams.Height = _height;
            hwndParams.Width = _width;
            hwndParams.WindowStyle = 0x10000000 | 0x40000000; // WS_VISIBLE|WS_CHILD
            _hwndSource = new HwndSource(hwndParams);
            _hwndSource.RootVisual = (System.Windows.Media.Visual)_instance;
        }

        public void ProcessIdle(double top, double bottom, double tempo, double current, double barStart, double cycleStart, double cycleEnd )
        {
            (_instance as View).ProcessIdle(top, bottom, tempo, current, barStart, cycleStart, cycleEnd);
        }

        public Rectangle Bounds
        {
            get
            {
                Rectangle rect;
                GetBounds(out rect);
                return rect;
            }
        }

        public IView SafeInstance
        {
            get { return _instance; }
        }

        /// <summary>
        /// Returns the bounding rectangle of the Control.
        /// </summary>
        /// <param name="rect">Receives the bounding rectangle.</param>
        /// <remarks>The same size as in design-time.</remarks>
        public void GetBounds(out Rectangle rect)
        {
            if (_instance == null)
                rect = new Rectangle(0, 0, 400, 400);
            else
                rect = new Rectangle(0, 0, (int)_instance.Width, (int)_instance.Height);
        }

        /// <summary>
        /// Closes and destroys the Control.
        /// </summary>
        public void Close()
        {
            if (_hwndSource != null)
            {
                _hwndSource.Dispose();
                _hwndSource = null;
            }
            _instance = null;
        }
    }
}