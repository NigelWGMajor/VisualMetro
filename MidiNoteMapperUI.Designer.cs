namespace Jacobi.Vst.Samples.MidiNoteMapper
{
    partial class MidiNoteMapperUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.eSemitones = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cUpDown = new System.Windows.Forms.Button();
            this.cDropOctave = new System.Windows.Forms.Button();
            this.cAddOctave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eFrom = new System.Windows.Forms.TrackBar();
            this.eTo = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eSemitones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTo)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(296, 119);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 34);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Location = new System.Drawing.Point(296, 79);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 34);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit...";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Visible = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(296, 38);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 35);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete...";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // eSemitones
            // 
            this.eSemitones.Location = new System.Drawing.Point(125, 33);
            this.eSemitones.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.eSemitones.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.eSemitones.Name = "eSemitones";
            this.eSemitones.Size = new System.Drawing.Size(44, 20);
            this.eSemitones.TabIndex = 4;
            this.toolTip1.SetToolTip(this.eSemitones, "Semitones to transpose (up or down)");
            this.eSemitones.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transpose:";
            // 
            // cUpDown
            // 
            this.cUpDown.BackColor = System.Drawing.Color.AliceBlue;
            this.cUpDown.ForeColor = System.Drawing.Color.Navy;
            this.cUpDown.Location = new System.Drawing.Point(178, 273);
            this.cUpDown.Name = "cUpDown";
            this.cUpDown.Size = new System.Drawing.Size(82, 23);
            this.cUpDown.TabIndex = 9;
            this.cUpDown.Text = "up/down";
            this.toolTip1.SetToolTip(this.cUpDown, "Adjust the direction");
            this.cUpDown.UseVisualStyleBackColor = false;
            this.cUpDown.Click += new System.EventHandler(this.cUpDown_Click);
            // 
            // cDropOctave
            // 
            this.cDropOctave.BackColor = System.Drawing.Color.AliceBlue;
            this.cDropOctave.ForeColor = System.Drawing.Color.Navy;
            this.cDropOctave.Location = new System.Drawing.Point(178, 297);
            this.cDropOctave.Name = "cDropOctave";
            this.cDropOctave.Size = new System.Drawing.Size(41, 23);
            this.cDropOctave.TabIndex = 11;
            this.cDropOctave.Text = "- 8va";
            this.toolTip1.SetToolTip(this.cDropOctave, "Lower an octave");
            this.cDropOctave.UseVisualStyleBackColor = false;
            this.cDropOctave.Click += new System.EventHandler(this.cDropOctave_Click);
            // 
            // cAddOctave
            // 
            this.cAddOctave.BackColor = System.Drawing.Color.AliceBlue;
            this.cAddOctave.ForeColor = System.Drawing.Color.Navy;
            this.cAddOctave.Location = new System.Drawing.Point(219, 297);
            this.cAddOctave.Name = "cAddOctave";
            this.cAddOctave.Size = new System.Drawing.Size(41, 23);
            this.cAddOctave.TabIndex = 11;
            this.cAddOctave.Text = "+8va";
            this.toolTip1.SetToolTip(this.cAddOctave, "Raise an octave");
            this.cAddOctave.UseVisualStyleBackColor = false;
            this.cAddOctave.Click += new System.EventHandler(this.cAddOctave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(32, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nick\'s Test Metro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(175, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "semitones.";
            // 
            // eFrom
            // 
            this.eFrom.AutoSize = false;
            this.eFrom.LargeChange = 2;
            this.eFrom.Location = new System.Drawing.Point(18, 70);
            this.eFrom.Maximum = 12;
            this.eFrom.Name = "eFrom";
            this.eFrom.Size = new System.Drawing.Size(235, 30);
            this.eFrom.TabIndex = 6;
            this.eFrom.Value = 6;
            this.eFrom.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // eTo
            // 
            this.eTo.AutoSize = false;
            this.eTo.LargeChange = 2;
            this.eTo.Location = new System.Drawing.Point(18, 217);
            this.eTo.Maximum = 12;
            this.eTo.Name = "eTo";
            this.eTo.Size = new System.Drawing.Size(235, 32);
            this.eTo.TabIndex = 7;
            this.eTo.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.eTo.Value = 6;
            this.eTo.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(109, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "FROM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(119, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(18, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 110);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(48, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 110);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Location = new System.Drawing.Point(78, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 110);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cornsilk;
            this.panel4.Location = new System.Drawing.Point(108, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 110);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cornsilk;
            this.panel5.Location = new System.Drawing.Point(138, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 110);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cornsilk;
            this.panel6.Location = new System.Drawing.Point(171, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 110);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Cornsilk;
            this.panel7.Location = new System.Drawing.Point(202, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(28, 110);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Cornsilk;
            this.panel8.Location = new System.Drawing.Point(232, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(28, 110);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(39, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(16, 73);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(72, 101);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(16, 73);
            this.panel10.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel11.Location = new System.Drawing.Point(129, 101);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(16, 73);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel12.Location = new System.Drawing.Point(161, 101);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(16, 73);
            this.panel12.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel13.Location = new System.Drawing.Point(195, 101);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(16, 73);
            this.panel13.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(23, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Developed by Nigel Major";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(22, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "by Jacobi Software (c) 2011.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(22, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "using VST.NET framework";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(243, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "v 1.3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MidiNoteMapperUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.cAddOctave);
            this.Controls.Add(this.cDropOctave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cUpDown);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eTo);
            this.Controls.Add(this.eFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eSemitones);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel3);
            this.Name = "MidiNoteMapperUI";
            this.Size = new System.Drawing.Size(747, 348);
            this.Load += new System.EventHandler(this.MidiNoteMapperUI_Load);
            this.VisibleChanged += new System.EventHandler(this.MidiNoteMapperUI_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.eSemitones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.NumericUpDown eSemitones;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar eFrom;
        private System.Windows.Forms.TrackBar eTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button cUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cDropOctave;
        private System.Windows.Forms.Button cAddOctave;
        private System.Windows.Forms.Label label9;

    }
}
