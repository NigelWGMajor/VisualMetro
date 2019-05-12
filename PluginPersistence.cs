using System;
using System.IO;
using System.Text;

using Jacobi.Vst.Core;
using Jacobi.Vst.Framework;

namespace Nix.Metro
{

    /// <summary>
    /// This persist our data.
    /// </summary>
    class PluginPersistence : IVstPluginPersistence
    {   /* UPDATE Versin to prevent data clashes */
        private const Decimal _version_ = 1.001M;
        private Plugin _plugin;
        private Encoding _encoding = Encoding.ASCII;

        public PluginPersistence(Plugin plugin)
        {
            _plugin = plugin;
        }

        #region IVstPluginPersistence Members

        public bool CanLoadChunk(VstPatchChunkInfo chunkInfo)
        {
            return true;
        }

        public void ReadPrograms(Stream stream, VstProgramCollection programs)
        {
            int stage = 0;
            try
            {
                
                BinaryReader reader = new BinaryReader(stream, _encoding);
                {
                    Decimal version = reader.ReadDecimal();
                    if (version != _version_)
                    {
                        System.Windows.Forms.MessageBox.Show(String.Format("{0} != {1}", version, _version_));
                    }
                    _plugin.Data.Height = reader.ReadInt32();
                    _plugin.Data.MainBeatIndex = reader.ReadInt32();
                    _plugin.Data.OtherBeatIndex = reader.ReadInt32();
                    while (reader.PeekChar() > -1)
                    {
                        stage++;
                        string note = "", text = "";
                        int index = reader.ReadInt32();
                        if (reader.PeekChar() > -1)
                        {
                            int present = reader.ReadInt32();
                            // this is a bit flag....
                            if ((present & 1) == 1)
                                note = reader.ReadString();
                            if ((present & 2) == 2)
                                text = reader.ReadString();

                            if (!_plugin.Data.Cues.ContainsKey(index))
                                _plugin.Data.Cues.Add(index, new Cue(index, note, text));
                        }
                        // we are rejecting multiple definintions - this shouldn't occur.
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, string.Format("Data read error at stage {0}", stage) );
            }
        }

        public void WritePrograms(Stream stream, VstProgramCollection programs)
        {
            BinaryWriter writer = new BinaryWriter(stream, _encoding);
            writer.Write(_version_);
            writer.Write(_plugin.Data.Height);
            writer.Write(_plugin.Data.MainBeatIndex);
            writer.Write(_plugin.Data.OtherBeatIndex);
            foreach (Cue cue in _plugin.Data.Cues.Values)
            {
                if (cue.Index < 0 || (String.IsNullOrEmpty(cue.Note) && String.IsNullOrEmpty(cue.Text)))
                    continue;
                int present =
                    (String.IsNullOrWhiteSpace(cue.Note) ? 0 : 1) +
                    (String.IsNullOrWhiteSpace(cue.Text) ? 0 : 2);
                writer.Write(cue.Index);
                writer.Write(present);
                if ((present & 1) == 1)
                    writer.Write(cue.Note);
                if ((present & 2) == 2)
                    writer.Write(cue.Text);
            }
        }

        #endregion
    }
}
