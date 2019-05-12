using System;
using System.Collections.Generic;
using System.Text;
using Jacobi.Vst.Framework;
using Jacobi.Vst.Framework.Common;

namespace Jacobi.Vst.Samples.MidiNoteMapper
{
    public class PluginFloater : IVstPluginEditor
    {
        private Plugin _plugin;
        private WinFormsControlWrapper<Repeater> _repeater = new WinFormsControlWrapper<Repeater>();
        public PluginFloater(Plugin plugin)
        {
            _plugin = plugin;
        }

        public System.Drawing.Rectangle Bounds
        {
            get { return _repeater.Bounds; }
        }

        public void Close()
        {
            _repeater.Close();
        }

        public void KeyDown(byte ascii, Core.VstVirtualKey virtualKey, Core.VstModifierKeys modifers)
        {
            //throw new NotImplementedException();
        }

        public void KeyUp(byte ascii, Core.VstVirtualKey virtualKey, Core.VstModifierKeys modifers)
        {
            //throw new NotImplementedException();
        }

        public Core.VstKnobMode KnobMode{  get; set; }

        public void Open(IntPtr hWnd)
        {
             _repeater.Open(hWnd);
             _repeater.SafeInstance.AdjustSize();
        }

        public void ProcessIdle()
        {
            //throw new NotImplementedException();
        }
    }
}
