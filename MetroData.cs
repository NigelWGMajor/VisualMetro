using System;
using System.Collections.Generic;
using System.Text;

namespace Nix.Metro
{
    /// <summary>
    /// I am using this to manage the variables we need to maintain.
    /// </summary>
    public class MetroData
    {
        /// <summary>
        /// Counts beats
        /// </summary>
        // public double Counter { get; set; }

        /// <summary>
        /// Initializing constuctor
        /// </summary>
        public MetroData()
        {
            Height = 200;
            MainBeatIndex = 12;
            OtherBeatIndex = 9;
        }
        // Read and write these in the same order in PluginPersistence
        public int Height { get; set; }
        public int MainBeatIndex { get; set; }
        public int OtherBeatIndex { get; set; }
        private SortedList<int, Cue> _cues;
        public SortedList<int, Cue> Cues
        {
            get
            {
                if (_cues == null) _cues = new SortedList<int, Cue>();
                return _cues;
            }
            set 
            {
                _cues = value; 
            }
        }
    }
}
