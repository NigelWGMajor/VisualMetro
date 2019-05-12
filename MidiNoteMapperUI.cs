using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jacobi.Vst.Samples.MidiNoteMapper
{
    /// <summary>
    /// The plugin custom editor UI.
    /// </summary>
    partial class MidiNoteMapperUI : UserControl
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MidiNoteMapperUI()
        {
            InitializeComponent();
        }
        //private MapNoteItemList _noteMap;
        /// <summary>
        /// Gets or sets the list of note map items that are shown in the editor.
        /// </summary>
        //public MapNoteItemList NoteMap
        //{
        //    get { return _noteMap; }
        //    set { _noteMap = value; FillList(); }
        //}
        private TransposeDefinition _transpose;
        /// <summary>
        /// Nick added: number of semitones to transpose.
        /// </summary>
        public TransposeDefinition Transpose
        {
            get { return _transpose; }
            set
            {
                _transpose = value;
               // numericUpDown1.Value = _transpose.Semitones;
            }
        }
        /// <summary>
        /// Contains a queue with note-on note numbers currently playing.
        /// </summary>
        public Queue<byte> NoteOnEvents { get; set; }
        /// <summary>
        /// Updates the UI with the <see cref="NoteOnEvents"/>.
        /// </summary>
        public void ProcessIdle()
        {
            //if (NoteOnEvents.Count > 0)
            //{
            //    byte noteNo;
            //    lock (((ICollection)NoteOnEvents).SyncRoot)
            //    {
            //        noteNo = NoteOnEvents.Dequeue();
            //    }
            //    SelectNoteMapItem(noteNo);
            //}
        }
        //private void SelectNoteMapItem(byte noteNo)
        //{
        //    MapListVw.SelectedIndices.Clear();
        //    if (MapListVw.Items.ContainsKey(noteNo.ToString()))
        //    {
        //        MapListVw.Items[noteNo.ToString()].Selected = true;
        //    }
        //}
        //private void FillList()
        //{
        //    if (!this.Created || NoteMap == null) return;
        //    MapNoteItem selectedItem = null;
        //    if (MapListVw.SelectedItems.Count > 0)
        //    {
        //        selectedItem = (MapNoteItem)MapListVw.SelectedItems[0].Tag;
        //    }
        //    MapListVw.Items.Clear();
        //    foreach (MapNoteItem item in NoteMap)
        //    {
        //        ListViewItem lvItem = new ListViewItem(item.TriggerNoteNumber.ToString());
        //        lvItem.SubItems.Add(item.KeyName);
        //        lvItem.SubItems.Add(item.OutputNoteNumber.ToString());
        //        lvItem.Tag = item;
        //        lvItem.Selected = (selectedItem == item);
        //        lvItem.Name = item.TriggerNoteNumber.ToString();

        //        MapListVw.Items.Add(lvItem);
        //    }
        //    if (selectedItem == null || MapListVw.SelectedItems.Count == 0)
        //    {
        //        if (MapListVw.Items.Count > 0)
        //        {
        //            MapListVw.Items[0].Selected = true;
        //        }
        //    }
        //}
        private void AddBtn_Click(object sender, EventArgs e)
        {
            //MapNoteDetails dlg = new MapNoteDetails();
            //dlg.MapNoteItem = new MapNoteItem()
            //{
            //    KeyName = "New Note Map",
            //    TriggerNoteNumber = 64,
            //    OutputNoteNumber = 64
            //};

            //if (dlg.ShowDialog(this) == DialogResult.OK)
            //{
            //    //if (NoteMap.Contains(dlg.MapNoteItem.TriggerNoteNumber))
            //    //{
            //    //    NoteMap.Remove(NoteMap[dlg.MapNoteItem.TriggerNoteNumber]);
            //    //}

            //    //NoteMap.Add(dlg.MapNoteItem);
            //    //FillList();
            //}
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            //if (MapListVw.SelectedItems.Count > 0)
            //{
            //    MapNoteDetails dlg = new MapNoteDetails();
            //    dlg.MapNoteItem = (MapNoteItem)MapListVw.SelectedItems[0].Tag;

            //    if (dlg.ShowDialog(this) == DialogResult.OK)
            //    {
            //        FillList();
            //    }
            //}
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //if (MapListVw.SelectedItems.Count > 0)
            //{
            //    MapNoteItem item = (MapNoteItem)MapListVw.SelectedItems[0].Tag;

            //    if (MessageBox.Show(this, 
            //        String.Format("Are you sure you want to delete {0}.", item.KeyName), 
            //        "Delete a Note Map Item.", 
            //        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    {
            //        NoteMap.Remove(item);
            //        FillList();
            //    }
            //}
        }
        private void MapListVw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ListViewHitTestInfo hitInfo = MapListVw.HitTest(e.Location);
            //if (hitInfo.Item != null)
            //{
            //    hitInfo.Item.Selected = true;

            //    MapNoteDetails dlg = new MapNoteDetails();
            //    dlg.MapNoteItem = (MapNoteItem)hitInfo.Item.Tag;

            //    if (dlg.ShowDialog(this) == DialogResult.OK)
            //    {
            //        FillList();
            //    }
            //}
        }
        private void MidiNoteMapperUI_Load(object sender, EventArgs e)
        {
     //       FillList();
            
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RefreshSliders();
        }

        private void RefreshSliders()
        {
            _transpose.Semitones = (int)eSemitones.Value;
            int _i = (int)(eSemitones.Value + eFrom.Value);
            while (_i < 0) _i = _i + 12;
            while (_i > 12) _i = _i - 12;
            eTo.Value = _i;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Transpose.FromValue = eFrom.Value;
            Recalculate();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Recalculate();
        }
        private void Recalculate()
        {
            eSemitones.Value = (decimal)(eTo.Value - eFrom.Value);
            ShowUpDown();
        }

        private void ShowUpDown()
        {
            if (eSemitones.Value == 12)
                cUpDown.Text = "Zero";
            else if (eSemitones.Value > 0)
                cUpDown.Text = "<-- Down";
            else if (eSemitones.Value < 0)
                cUpDown.Text = "Up -->";
            else if (eSemitones.Value == 0)
                cUpDown.Text = "<-- Down";
        }

        private void cUpDown_Click(object sender, EventArgs e)
        {
            if (eSemitones.Value == -12) eSemitones.Value = 12.0M; // wrap around... 
            else if (eSemitones.Value >= 0) eSemitones.Value -= 12;
            else eSemitones.Value += 12;
            ShowUpDown();
        }

        private void MidiNoteMapperUI_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true && Transpose != null)
            {
                eSemitones.Value = (Decimal)Transpose.Semitones;
                eFrom.Value = Transpose.FromValue;
                RefreshSliders();
            }
        }

        private void cDropOctave_Click(object sender, EventArgs e)
        {
            if (eSemitones.Value >= -12)
            {
                eSemitones.Value -= 12;
                RefreshSliders(); ;
            }
        }

        private void cAddOctave_Click(object sender, EventArgs e)
        {
            if (eSemitones.Value < 13)
            {
                eSemitones.Value += 12;
                RefreshSliders(); ;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
