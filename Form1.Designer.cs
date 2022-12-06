using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace FINAL_FANTASY_2_SEQUENCER
{

    public static class PRG
    {
        public static StreamReader ROMPath;
        public static byte[] ROM;
        public static byte[] SequenceData;
        public static int SequenceDataOffset = 0;
        public static int ROMOffset = 0x0;
        public static ASCIIEncoding Asen = new ASCIIEncoding();
        public static byte Hibyte;
        public static byte Lobyte;
        public static byte CurrentSEQByte;
        public static string HeaderString;

        public static int SEQIndex = 0;
        public static int IndexLength;
        public static string SEQArrayTEXT = " ";
        public static int SEQNewLineIndex= 0;
        public static string HeaderType;
        public static byte LastOctave = 0x00;
        public static byte CurrentOctave = 0x00;
    }


    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TempoBox = new System.Windows.Forms.TextBox();
            this.TempoLabel = new System.Windows.Forms.Label();
            this.DutyCycleL = new System.Windows.Forms.Label();
            this.DutyCycle = new System.Windows.Forms.TextBox();
            this.NoteEnvelopeL = new System.Windows.Forms.Label();
            this.NoteEnvelope = new System.Windows.Forms.TextBox();
            this.PitchEnvelopeL = new System.Windows.Forms.Label();
            this.PitchEnvelope = new System.Windows.Forms.TextBox();
            this.Tracklist = new System.Windows.Forms.ComboBox();
            this.RomOffsetL = new System.Windows.Forms.Label();
            this.MusicSizeL = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fF2DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeL = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NoteBox = new System.Windows.Forms.ListBox();
            this.Octavelistbox = new System.Windows.Forms.ListBox();
            this.Noteduration = new System.Windows.Forms.ListBox();
            this.AddNoteBTN = new System.Windows.Forms.Button();
            this.AddRestBTN = new System.Windows.Forms.Button();
            this.AddLoopBTN = new System.Windows.Forms.Button();
            this.LoopListbox = new System.Windows.Forms.ListBox();
            this.SongDataL = new System.Windows.Forms.Label();
            this.PreviousBytesL = new System.Windows.Forms.Label();
            this.CurrentSongL = new System.Windows.Forms.Label();
            this.NewSongDataL = new System.Windows.Forms.Label();
            this.JumpBox = new System.Windows.Forms.TextBox();
            this.JumpBoxBTN = new System.Windows.Forms.Button();
            this.JumpAddrL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateHeaderButton = new System.Windows.Forms.Button();
            this.UsedBytesL = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HeaderData = new System.Windows.Forms.Label();
            this.SaveAsRom = new System.Windows.Forms.SaveFileDialog();
            this.SaveAsBin = new System.Windows.Forms.SaveFileDialog();
            this.CreditsWin = new System.Windows.Forms.Form();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TempoBox
            // 
            this.TempoBox.Location = new System.Drawing.Point(265, 62);
            this.TempoBox.Name = "TempoBox";
            this.TempoBox.Size = new System.Drawing.Size(47, 20);
            this.TempoBox.TabIndex = 1;
            // 
            // TempoLabel
            // 
            this.TempoLabel.AutoSize = true;
            this.TempoLabel.Location = new System.Drawing.Point(215, 66);
            this.TempoLabel.Name = "TempoLabel";
            this.TempoLabel.Size = new System.Drawing.Size(43, 14);
            this.TempoLabel.TabIndex = 2;
            this.TempoLabel.Text = "Tempo:";
            // 
            // DutyCycleL
            // 
            this.DutyCycleL.AutoSize = true;
            this.DutyCycleL.Location = new System.Drawing.Point(197, 94);
            this.DutyCycleL.Name = "DutyCycleL";
            this.DutyCycleL.Size = new System.Drawing.Size(63, 14);
            this.DutyCycleL.TabIndex = 4;
            this.DutyCycleL.Text = "Duty Cycle:";
            // 
            // DutyCycle
            // 
            this.DutyCycle.Location = new System.Drawing.Point(265, 90);
            this.DutyCycle.Name = "DutyCycle";
            this.DutyCycle.Size = new System.Drawing.Size(47, 20);
            this.DutyCycle.TabIndex = 3;
            // 
            // NoteEnvelopeL
            // 
            this.NoteEnvelopeL.AutoSize = true;
            this.NoteEnvelopeL.Location = new System.Drawing.Point(177, 150);
            this.NoteEnvelopeL.Name = "NoteEnvelopeL";
            this.NoteEnvelopeL.Size = new System.Drawing.Size(81, 14);
            this.NoteEnvelopeL.TabIndex = 6;
            this.NoteEnvelopeL.Text = "Note Envelope:";
            // 
            // NoteEnvelope
            // 
            this.NoteEnvelope.Location = new System.Drawing.Point(265, 146);
            this.NoteEnvelope.Name = "NoteEnvelope";
            this.NoteEnvelope.Size = new System.Drawing.Size(47, 20);
            this.NoteEnvelope.TabIndex = 5;
            // 
            // PitchEnvelopeL
            // 
            this.PitchEnvelopeL.AutoSize = true;
            this.PitchEnvelopeL.Location = new System.Drawing.Point(176, 178);
            this.PitchEnvelopeL.Name = "PitchEnvelopeL";
            this.PitchEnvelopeL.Size = new System.Drawing.Size(83, 14);
            this.PitchEnvelopeL.TabIndex = 8;
            this.PitchEnvelopeL.Text = "Pitch Envelope:";
            // 
            // PitchEnvelope
            // 
            this.PitchEnvelope.Location = new System.Drawing.Point(265, 174);
            this.PitchEnvelope.Name = "PitchEnvelope";
            this.PitchEnvelope.Size = new System.Drawing.Size(47, 20);
            this.PitchEnvelope.TabIndex = 7;
            // 
            // Tracklist
            // 
            this.Tracklist.Enabled = false;
            this.Tracklist.FormattingEnabled = true;
            this.Tracklist.Items.AddRange(new object[] {
            "Prelude SQ1",
            "Prelude SQ2",
            "Main Theme SQ1",
            "Main Theme SQ2",
            "Main Theme TRI",
            "Fanfare SQ1",
            "Fanfare SQ2",
            "Fanfare TRI",
            "Pandemonium SQ1",
            "Pandemonium SQ2",
            "Pandemonium TRI",
            "Ancient Castle SQ1",
            "Ancient Castle SQ2",
            "Ancient Castle TRI",
            "Tower of Magi SQ1",
            "Tower of Magi SQ2",
            "Tower of Magi TRI",
            "Imperial Army SQ1",
            "Imperial Army SQ2",
            "Imperial Army TRI",
            "Dungeon SQ1",
            "Dungeon SQ2",
            "Dungeon TRI",
            "Town SQ1",
            "Town SQ2",
            "Town TRI",
            "Rebel Army SQ1",
            "Rebel Army SQ2",
            "Rebel Army TRI"});
            this.Tracklist.Location = new System.Drawing.Point(12, 60);
            this.Tracklist.Name = "Tracklist";
            this.Tracklist.Size = new System.Drawing.Size(140, 22);
            this.Tracklist.TabIndex = 9;
            this.Tracklist.SelectedIndexChanged += new System.EventHandler(this.Tracklist_SelectedIndexChanged);
            // 
            // RomOffsetL
            // 
            this.RomOffsetL.AutoSize = true;
            this.RomOffsetL.Location = new System.Drawing.Point(21, 118);
            this.RomOffsetL.Name = "RomOffsetL";
            this.RomOffsetL.Size = new System.Drawing.Size(48, 14);
            this.RomOffsetL.TabIndex = 10;
            this.RomOffsetL.Text = "Rom: 0x";
            // 
            // MusicSizeL
            // 
            this.MusicSizeL.AutoSize = true;
            this.MusicSizeL.Location = new System.Drawing.Point(21, 146);
            this.MusicSizeL.Name = "MusicSizeL";
            this.MusicSizeL.Size = new System.Drawing.Size(37, 14);
            this.MusicSizeL.TabIndex = 11;
            this.MusicSizeL.Text = "Bytes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.SaveToRomToolStripMenuItem,
            this.SaveToBinToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem1.Text = "Open";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // SaveToRomToolStripMenuItem
            // 
            this.SaveToRomToolStripMenuItem.Name = "SaveToRomToolStripMenuItem";
            this.SaveToRomToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SaveToRomToolStripMenuItem.Text = "Save To ROM";
            this.SaveToRomToolStripMenuItem.Click += new System.EventHandler(this.SaveToRomToolStripMenuItem_Click);
            // 
            // SaveToBinToolStripMenuItem
            // 
            this.SaveToBinToolStripMenuItem.Name = "SaveToBinToolStripMenuItem";
            this.SaveToBinToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SaveToBinToolStripMenuItem.Text = "Save to BIN";
            this.SaveToBinToolStripMenuItem.Click += new System.EventHandler(this.SaveToBinToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fF2DocumentsToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fF2DocumentsToolStripMenuItem
            // 
            this.fF2DocumentsToolStripMenuItem.Name = "fF2DocumentsToolStripMenuItem";
            this.fF2DocumentsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fF2DocumentsToolStripMenuItem.Text = "FF2 Documents";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // VolumeL
            // 
            this.VolumeL.AutoSize = true;
            this.VolumeL.Location = new System.Drawing.Point(190, 122);
            this.VolumeL.Name = "VolumeL";
            this.VolumeL.Size = new System.Drawing.Size(72, 14);
            this.VolumeL.TabIndex = 13;
            this.VolumeL.Text = "Volume Flag:";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(265, 118);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(47, 20);
            this.Volume.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NoteBox
            // 
            this.NoteBox.FormattingEnabled = true;
            this.NoteBox.ItemHeight = 14;
            this.NoteBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.NoteBox.Location = new System.Drawing.Point(903, 60);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(62, 172);
            this.NoteBox.TabIndex = 15;
            this.NoteBox.SelectedIndexChanged += new System.EventHandler(this.NoteBox_SelectedIndexChanged);
            // 
            // Octavelistbox
            // 
            this.Octavelistbox.FormattingEnabled = true;
            this.Octavelistbox.ItemHeight = 14;
            this.Octavelistbox.Items.AddRange(new object[] {
            "O2",
            "O3",
            "O4",
            "O5",
            "O6",
            "O7"});
            this.Octavelistbox.Location = new System.Drawing.Point(986, 60);
            this.Octavelistbox.Name = "Octavelistbox";
            this.Octavelistbox.Size = new System.Drawing.Size(59, 88);
            this.Octavelistbox.TabIndex = 16;
            this.Octavelistbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Noteduration
            // 
            this.Noteduration.FormattingEnabled = true;
            this.Noteduration.ItemHeight = 14;
            this.Noteduration.Items.AddRange(new object[] {
            "0: Whole (96)",
            "1: Dotted half (72)",
            "2: Half (48)",
            "3: Dotted 4th (36)",
            "4: Triplet half (32)",
            "5: 4th (24)",
            "6: Dotted 8th (18)",
            "7: Triplet 4th (16)",
            "8: 8th (12)",
            "9: Dotted 16th (9)",
            "a: Triplet 8th (8)",
            "b: 16th (6)",
            "c: Triplet 16th (4)",
            "d: 32nd (3)",
            "e: Triplet 32nd (2)",
            "f: Triplet 64th (1)"});
            this.Noteduration.Location = new System.Drawing.Point(764, 60);
            this.Noteduration.Name = "Noteduration";
            this.Noteduration.Size = new System.Drawing.Size(120, 228);
            this.Noteduration.TabIndex = 17;
            this.Noteduration.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // AddNoteBTN
            // 
            this.AddNoteBTN.Enabled = false;
            this.AddNoteBTN.Location = new System.Drawing.Point(651, 62);
            this.AddNoteBTN.Name = "AddNoteBTN";
            this.AddNoteBTN.Size = new System.Drawing.Size(98, 58);
            this.AddNoteBTN.TabIndex = 18;
            this.AddNoteBTN.Text = "Add Note";
            this.AddNoteBTN.UseVisualStyleBackColor = true;
            this.AddNoteBTN.Click += new System.EventHandler(this.AddNoteBTN_Click);
            // 
            // AddRestBTN
            // 
            this.AddRestBTN.Enabled = false;
            this.AddRestBTN.Location = new System.Drawing.Point(651, 137);
            this.AddRestBTN.Name = "AddRestBTN";
            this.AddRestBTN.Size = new System.Drawing.Size(98, 59);
            this.AddRestBTN.TabIndex = 19;
            this.AddRestBTN.Text = "Add Rest";
            this.AddRestBTN.UseVisualStyleBackColor = true;
            this.AddRestBTN.Click += new System.EventHandler(this.AddRestBTN_Click);
            // 
            // AddLoopBTN
            // 
            this.AddLoopBTN.Enabled = false;
            this.AddLoopBTN.Location = new System.Drawing.Point(539, 60);
            this.AddLoopBTN.Name = "AddLoopBTN";
            this.AddLoopBTN.Size = new System.Drawing.Size(75, 60);
            this.AddLoopBTN.TabIndex = 20;
            this.AddLoopBTN.Text = "Set Loop Value";
            this.AddLoopBTN.UseVisualStyleBackColor = true;
            // 
            // LoopListbox
            // 
            this.LoopListbox.FormattingEnabled = true;
            this.LoopListbox.ItemHeight = 14;
            this.LoopListbox.Items.AddRange(new object[] {
            "Loop x2",
            "Loop x3",
            "Loop x4",
            "Loop x5"});
            this.LoopListbox.Location = new System.Drawing.Point(473, 62);
            this.LoopListbox.Name = "LoopListbox";
            this.LoopListbox.Size = new System.Drawing.Size(53, 60);
            this.LoopListbox.TabIndex = 21;
            // 
            // SongDataL
            // 
            this.SongDataL.AutoSize = true;
            this.SongDataL.BackColor = System.Drawing.Color.LightCoral;
            this.SongDataL.Location = new System.Drawing.Point(9, 346);
            this.SongDataL.Name = "SongDataL";
            this.SongDataL.Size = new System.Drawing.Size(81, 14);
            this.SongDataL.TabIndex = 22;
            this.SongDataL.Text = "Song data here";
            // 
            // PreviousBytesL
            // 
            this.PreviousBytesL.AutoSize = true;
            this.PreviousBytesL.Location = new System.Drawing.Point(72, 332);
            this.PreviousBytesL.Name = "PreviousBytesL";
            this.PreviousBytesL.Size = new System.Drawing.Size(80, 14);
            this.PreviousBytesL.TabIndex = 23;
            this.PreviousBytesL.Text = "Previous Bytes";
            // 
            // CurrentSongL
            // 
            this.CurrentSongL.AutoSize = true;
            this.CurrentSongL.Location = new System.Drawing.Point(315, 332);
            this.CurrentSongL.Name = "CurrentSongL";
            this.CurrentSongL.Size = new System.Drawing.Size(154, 14);
            this.CurrentSongL.TabIndex = 25;
            this.CurrentSongL.Text = "Current Bytes Without Header";
            // 
            // NewSongDataL
            // 
            this.NewSongDataL.AutoSize = true;
            this.NewSongDataL.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NewSongDataL.Location = new System.Drawing.Point(300, 346);
            this.NewSongDataL.Name = "NewSongDataL";
            this.NewSongDataL.Size = new System.Drawing.Size(79, 14);
            this.NewSongDataL.TabIndex = 24;
            this.NewSongDataL.Text = "New Data here";
            // 
            // JumpBox
            // 
            this.JumpBox.Location = new System.Drawing.Point(473, 170);
            this.JumpBox.Name = "JumpBox";
            this.JumpBox.Size = new System.Drawing.Size(53, 20);
            this.JumpBox.TabIndex = 26;
            // 
            // JumpBoxBTN
            // 
            this.JumpBoxBTN.Enabled = false;
            this.JumpBoxBTN.Location = new System.Drawing.Point(539, 136);
            this.JumpBoxBTN.Name = "JumpBoxBTN";
            this.JumpBoxBTN.Size = new System.Drawing.Size(75, 60);
            this.JumpBoxBTN.TabIndex = 27;
            this.JumpBoxBTN.Text = "Jump to RAM addr";
            this.JumpBoxBTN.UseVisualStyleBackColor = true;
            // 
            // JumpAddrL
            // 
            this.JumpAddrL.AutoSize = true;
            this.JumpAddrL.Location = new System.Drawing.Point(473, 146);
            this.JumpAddrL.Name = "JumpAddrL";
            this.JumpAddrL.Size = new System.Drawing.Size(63, 14);
            this.JumpAddrL.TabIndex = 28;
            this.JumpAddrL.Text = "Jump Addr.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Note Duration                    Pitch                  Octave";
            // 
            // UpdateHeaderButton
            // 
            this.UpdateHeaderButton.Location = new System.Drawing.Point(265, 209);
            this.UpdateHeaderButton.Name = "UpdateHeaderButton";
            this.UpdateHeaderButton.Size = new System.Drawing.Size(102, 23);
            this.UpdateHeaderButton.TabIndex = 30;
            this.UpdateHeaderButton.Text = "UpdateHeader";
            this.UpdateHeaderButton.UseVisualStyleBackColor = true;
            this.UpdateHeaderButton.Click += new System.EventHandler(this.UpdateHeaderButton_Click_1);
            this.UpdateHeaderButton.Enabled = false;
            // 
            // UsedBytesL
            // 
            this.UsedBytesL.AutoSize = true;
            this.UsedBytesL.Location = new System.Drawing.Point(24, 170);
            this.UsedBytesL.Name = "UsedBytesL";
            this.UsedBytesL.Size = new System.Drawing.Size(35, 14);
            this.UsedBytesL.TabIndex = 31;
            this.UsedBytesL.Text = "Used:";
            this.UsedBytesL.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(206, 244);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(41, 14);
            this.HeaderLabel.TabIndex = 32;
            this.HeaderLabel.Text = "HType:";
            // 
            // HeaderData
            // 
            this.HeaderData.AutoSize = true;
            this.HeaderData.BackColor = System.Drawing.Color.LightGreen;
            this.HeaderData.Location = new System.Drawing.Point(270, 244);
            this.HeaderData.Name = "HeaderData";
            this.HeaderData.Size = new System.Drawing.Size(43, 14);
            this.HeaderData.TabIndex = 33;
            this.HeaderData.Text = "HLabel";
            // 
            // SaveAsBin
            // 
            this.SaveAsBin.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveAsBin_FileOk);
            // 
            // CreditsWin
            // 
            this.CreditsWin.ClientSize = new System.Drawing.Size(284, 261);
            this.CreditsWin.Location = new System.Drawing.Point(2076, 156);
            this.CreditsWin.Name = "CreditsWin";
            this.CreditsWin.Visible = false;
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Location = new System.Drawing.Point(0, 0);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(100, 23);
            this.CreditsLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.HeaderData);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.UsedBytesL);
            this.Controls.Add(this.UpdateHeaderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JumpAddrL);
            this.Controls.Add(this.JumpBoxBTN);
            this.Controls.Add(this.JumpBox);
            this.Controls.Add(this.CurrentSongL);
            this.Controls.Add(this.NewSongDataL);
            this.Controls.Add(this.PreviousBytesL);
            this.Controls.Add(this.SongDataL);
            this.Controls.Add(this.LoopListbox);
            this.Controls.Add(this.AddLoopBTN);
            this.Controls.Add(this.AddRestBTN);
            this.Controls.Add(this.AddNoteBTN);
            this.Controls.Add(this.Noteduration);
            this.Controls.Add(this.Octavelistbox);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.VolumeL);
            this.Controls.Add(this.MusicSizeL);
            this.Controls.Add(this.RomOffsetL);
            this.Controls.Add(this.Tracklist);
            this.Controls.Add(this.PitchEnvelopeL);
            this.Controls.Add(this.PitchEnvelope);
            this.Controls.Add(this.NoteEnvelopeL);
            this.Controls.Add(this.NoteEnvelope);
            this.Controls.Add(this.DutyCycleL);
            this.Controls.Add(this.DutyCycle);
            this.Controls.Add(this.TempoLabel);
            this.Controls.Add(this.TempoBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Final Fantasy 2 Sequencer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        

        private System.Windows.Forms.TextBox TempoBox;
        private System.Windows.Forms.Label TempoLabel;
        private System.Windows.Forms.Label DutyCycleL;
        private System.Windows.Forms.TextBox DutyCycle;
        private System.Windows.Forms.Label NoteEnvelopeL;
        private System.Windows.Forms.TextBox NoteEnvelope;
        private System.Windows.Forms.Label PitchEnvelopeL;
        private System.Windows.Forms.TextBox PitchEnvelope;
        private System.Windows.Forms.ComboBox Tracklist;
        private System.Windows.Forms.Label RomOffsetL;
        private System.Windows.Forms.Label MusicSizeL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToRomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fF2DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label VolumeL;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox NoteBox;
        private System.Windows.Forms.ListBox Octavelistbox;
        private System.Windows.Forms.ListBox Noteduration;
        private System.Windows.Forms.Button AddNoteBTN;
        private System.Windows.Forms.Button AddRestBTN;
        private System.Windows.Forms.Button AddLoopBTN;
        private System.Windows.Forms.ListBox LoopListbox;
        private System.Windows.Forms.Label SongDataL;
        private System.Windows.Forms.Label PreviousBytesL;
        private System.Windows.Forms.Label CurrentSongL;
        private System.Windows.Forms.Label NewSongDataL;
        private System.Windows.Forms.TextBox JumpBox;
        private System.Windows.Forms.Button JumpBoxBTN;
        private System.Windows.Forms.Label JumpAddrL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateHeaderButton;
        private System.Windows.Forms.Label UsedBytesL;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label HeaderData;
        private System.Windows.Forms.SaveFileDialog SaveAsRom;
        private System.Windows.Forms.SaveFileDialog SaveAsBin;
        private System.Windows.Forms.Form CreditsWin;
        private System.Windows.Forms.Label CreditsLabel;


    }
}

