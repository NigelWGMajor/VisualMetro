using System;
using System.Collections.Generic;
using System.Text;

namespace Nix.Metro
{
    /// <summary>
    /// Defines the displayable object, intended for indexed access from a list or array.
    /// </summary>
    public class Cue
    {
        public int Index { get; set; }      // the beat number
        public string Text{ get; set; }     // the main text
        public string Note { get; set; }    // note (sub) text
        public Cue(int index, string note, string text)
        {
            Index = index;
            Text = text;
            Note = note;
        }
    }
}
