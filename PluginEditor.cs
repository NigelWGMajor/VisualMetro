using System;
using Jacobi.Vst.Core;
using Jacobi.Vst.Framework;
using Jacobi.Vst.Framework.Common;

namespace Nix.Metro
{
    /// <summary>
    /// Implements the custom UI editor for the plugin.
    /// </summary>
    class PluginEditor : IVstPluginEditor
    {
        private Plugin _plugin;
        private WpfControlWrapper _uiWrapper = new WpfControlWrapper(360, 360);
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="plugin">Must not be null.</param>
        public PluginEditor(Plugin plugin)
        {
            _plugin = plugin;
        }
        #region IVstPluginEditor Members
        public System.Drawing.Rectangle Bounds
        {
            get { return _uiWrapper.Bounds; }
        }
        public void Close()
        {
            _uiWrapper.Close();
        }
        public void KeyDown(byte ascii, VstVirtualKey virtualKey, VstModifierKeys modifers)
        {
            // no-op
        }
        public void KeyUp(byte ascii, VstVirtualKey virtualKey, VstModifierKeys modifers)
        {
            // no-op
        }
        public VstKnobMode KnobMode { get; set; }
        public void Open(IntPtr hWnd)
        {
            _uiWrapper.Open(hWnd);
            _uiWrapper.SafeInstance.MetroData = _plugin.Data;
        }
        public void ProcessIdle()
        {
            //var x = _plugin.Host.GetInstance<IVstHostSequencer>();
            



            VstTimeInfo timeInfo = _plugin.Host.GetInstance<IVstHostCommands20>().GetTimeInfo(
            VstTimeInfoFlags.PpqPositionValid | VstTimeInfoFlags.BarStartPositionValid | VstTimeInfoFlags.TempoValid | VstTimeInfoFlags.CyclePositionValid);
            double current = timeInfo.PpqPosition;
            double tempo = timeInfo.Tempo;
            double top = (double)timeInfo.TimeSignatureNumerator;
            double bottom = (double)timeInfo.TimeSignatureDenominator;
            double barStart = timeInfo.BarStartPosition;
            double cycleStart = timeInfo.CycleStartPosition;
            double cycleEnd = timeInfo.CycleEndPosition;
           


            if (_uiWrapper.SafeInstance != null)
                _uiWrapper.SafeInstance.ProcessIdle(top, bottom, tempo, current, barStart, cycleStart, cycleEnd );
        }
        #endregion
        bool IVstPluginEditor.KeyDown(byte ascii, VstVirtualKey virtualKey, VstModifierKeys modifers)
        {
            return false;
        }
        bool IVstPluginEditor.KeyUp(byte ascii, VstVirtualKey virtualKey, VstModifierKeys modifers)
        {
            return false;
        }
    }
}
