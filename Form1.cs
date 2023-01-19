using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace FINAL_FANTASY_2_SEQUENCER
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tracklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //offset handler

            //prelude
            if (this.Tracklist.SelectedIndex == 0) { PRG.ROMOffset = 0x35e67; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 1) { PRG.ROMOffset = 0x35f67; PRG.HeaderType = "SQ2"; }

            //main
            if (this.Tracklist.SelectedIndex == 2) { PRG.ROMOffset = 0x36008; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 3) { PRG.ROMOffset = 0x3605b; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 4) { PRG.ROMOffset = 0x36066; PRG.HeaderType = "TRI"; }

            //fanfare
            if (this.Tracklist.SelectedIndex == 5) { PRG.ROMOffset = 0x3617D; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 6) { PRG.ROMOffset = 0x361a7; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 7) { PRG.ROMOffset = 0x361c5; PRG.HeaderType = "TRI"; }

            //Pandemonium
            if (this.Tracklist.SelectedIndex == 8)  { PRG.ROMOffset = 0x362b6; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 9)  { PRG.ROMOffset = 0x36313; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 10) { PRG.ROMOffset = 0x363f8; PRG.HeaderType = "TRI"; }

            //Ancient Castle
            if (this.Tracklist.SelectedIndex == 11) { PRG.ROMOffset = 0x3647b; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 12) { PRG.ROMOffset = 0x364dA; PRG.HeaderType = "SQ2"; } //says 9 in doc but wrong..
            if (this.Tracklist.SelectedIndex == 13) { PRG.ROMOffset = 0x36574; PRG.HeaderType = "TRI"; }

            //magi tower
            if (this.Tracklist.SelectedIndex == 14) { PRG.ROMOffset = 0x36601; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 15) { PRG.ROMOffset = 0x366b0; PRG.HeaderType = "SQ2"; } 
            if (this.Tracklist.SelectedIndex == 16) { PRG.ROMOffset = 0x36744; PRG.HeaderType = "TRI"; }

            //imperial
            if (this.Tracklist.SelectedIndex == 17) { PRG.ROMOffset = 0x367d0; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 18) { PRG.ROMOffset = 0x3686d; PRG.HeaderType = "SQ2"; } 
            if (this.Tracklist.SelectedIndex == 19) { PRG.ROMOffset = 0x368ea; PRG.HeaderType = "TRI"; }

            //dungeon
            if (this.Tracklist.SelectedIndex == 20) { PRG.ROMOffset = 0x369b1; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 21) { PRG.ROMOffset = 0x36aaa; PRG.HeaderType = "SQ2"; } 
            if (this.Tracklist.SelectedIndex == 22) { PRG.ROMOffset = 0x36aea; PRG.HeaderType = "TRI"; }

            //town
            if (this.Tracklist.SelectedIndex == 23) { PRG.ROMOffset = 0x36b21; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 24) { PRG.ROMOffset = 0x36bab; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 25) { PRG.ROMOffset = 0x36c35; PRG.HeaderType = "TRI"; }

            //rebels
            if (this.Tracklist.SelectedIndex == 26) { PRG.ROMOffset = 0x36c70; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 27) { PRG.ROMOffset = 0x36cd7; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 28) { PRG.ROMOffset = 0x36d1b; PRG.HeaderType = "TRI"; }

            //Battle
            if (this.Tracklist.SelectedIndex == 29) { PRG.ROMOffset = 0x36D70; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 30) { PRG.ROMOffset = 0x36e6e; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 31) { PRG.ROMOffset = 0x36f63; PRG.HeaderType = "TRI"; }

            //Boss
            if (this.Tracklist.SelectedIndex == 32) { PRG.ROMOffset = 0x37046; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 33) { PRG.ROMOffset = 0x371D6; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 34) { PRG.ROMOffset = 0x373b7; PRG.HeaderType = "TRI"; }

            //Vioctry
            if (this.Tracklist.SelectedIndex == 35) { PRG.ROMOffset = 0x37540; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 36) { PRG.ROMOffset = 0x375a6; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 37) { PRG.ROMOffset = 0x37605; PRG.HeaderType = "TRI"; }

            //Game Over
            if (this.Tracklist.SelectedIndex == 38) { PRG.ROMOffset = 0x37660; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 39) { PRG.ROMOffset = 0x37688; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 40) { PRG.ROMOffset = 0x376D4; PRG.HeaderType = "TRI"; }

            //Princess 
            if (this.Tracklist.SelectedIndex == 41) { PRG.ROMOffset = 0x376eb; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 42) { PRG.ROMOffset = 0x37688; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 43) { PRG.ROMOffset = 0x376d4; PRG.HeaderType = "TRI"; }

            //Revival
            if (this.Tracklist.SelectedIndex == 44) { PRG.ROMOffset = 0x37763; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 45) { PRG.ROMOffset = 0x37782; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 46) { PRG.ROMOffset = 0x3778e; PRG.HeaderType = "TRI"; }

            //Reunion
            if (this.Tracklist.SelectedIndex == 47) { PRG.ROMOffset = 0x3779b; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 48) { PRG.ROMOffset = 0x377c1; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 49) { PRG.ROMOffset = 0x37826; PRG.HeaderType = "TRI"; }

            //ESCAPE!
            if (this.Tracklist.SelectedIndex == 50) { PRG.ROMOffset = 0x3783c; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 51) { PRG.ROMOffset = 0x37870; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 52) { PRG.ROMOffset = 0x37884; PRG.HeaderType = "TRI"; }

            //Emporer Rebirth 
            if (this.Tracklist.SelectedIndex == 53) { PRG.ROMOffset = 0x37996; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 54) { PRG.ROMOffset = 0x379c0; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 55) { PRG.ROMOffset = 0x379dc; PRG.HeaderType = "TRI"; }

            //Finale
            if (this.Tracklist.SelectedIndex == 56) { PRG.ROMOffset = 0x379f7; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 57) { PRG.ROMOffset = 0x37b4d; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 58) { PRG.ROMOffset = 0x37c88; PRG.HeaderType = "TRI"; }

            //Chocobo
            if (this.Tracklist.SelectedIndex == 59) { PRG.ROMOffset = 0x35f9d; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 60) { PRG.ROMOffset = 0x35fdc; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 61) { PRG.ROMOffset = 0x35ff1; PRG.HeaderType = "TRI"; }

            //Waltz!
            if (this.Tracklist.SelectedIndex == 62) { PRG.ROMOffset = 0x3783c; PRG.HeaderType = "SQ1"; }
            if (this.Tracklist.SelectedIndex == 63) { PRG.ROMOffset = 0x37870; PRG.HeaderType = "SQ2"; }
            if (this.Tracklist.SelectedIndex == 64) { PRG.ROMOffset = 0x37884; PRG.HeaderType = "TRI"; }

            //configure SEQ Index for headers
            if (PRG.HeaderType == "SQ1") { PRG.SEQIndex = 8; }
            if (PRG.HeaderType == "SQ2" || PRG.HeaderType == "TRI") { PRG.SEQIndex = 6; }

            this.RomOffsetL.Text = ("Rom Offset: " + "0x" + PRG.ROMOffset.ToString("x8").TrimStart('0'));
            this.UsedBytesL.Text = ("Used: " + Convert.ToString(PRG.SEQIndex));

            HeaderTypeOptions();
            EnableFormOptions();

            DecodeFF2Music(); // call length "finder" and put in MusicSizeL
            this.Invalidate();
        }

        private void EnableFormOptions()
        {

            this.AddRestBTN.Enabled = true;
            this.AddNoteBTN.Enabled = true;
            this.AddLoopBTN.Enabled = true;
            this.JumpBoxBTN.Enabled = true;
            this.OddJumpButton.Enabled = true;
            this.EndLoopButton.Enabled = true;
            this.UpdateHeaderButton.Enabled = true;


        }


        private void HeaderTypeOptions()
        {

            if (PRG.HeaderType == "SQ1") {
                this.TempoBox.Enabled = true;
                this.DutyCycle.Enabled = true;
                this.Volume.Enabled = true;
               

            }

            if (PRG.HeaderType == "SQ2") {
                this.TempoBox.Enabled = false;
                this.DutyCycle.Enabled = true;
                this.Volume.Enabled = true;
             
            }

            if (PRG.HeaderType == "TRI") {
                this.TempoBox.Enabled = false;
                this.DutyCycle.Enabled = false;
                this.Volume.Enabled = false;
         
            }


            this.HeaderLabel.Text = "HType: " + PRG.HeaderType;
            PRG.HeaderString = ""; // clear string

            PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 0].ToString("x2") + " ");
            PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 1].ToString("x2") + " ");
            PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 2].ToString("x2") + " ");
            PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 3].ToString("x2") + " ");
            PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 4].ToString("x2") + " ");
            PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 5].ToString("x2") + " ");
             
                if (PRG.HeaderType == "SQ1")
                {
                PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 6].ToString("x2") + " ");
                PRG.HeaderString += (PRG.ROM[PRG.ROMOffset + 7].ToString("x2") + " ");
                }

            this.HeaderData.Text = PRG.HeaderString;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) // File open hendler
        {
            this.openFileDialog1.DefaultExt = "nes";
            this.openFileDialog1.InitialDirectory = @"C:\";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Filter = "NES files (*.nes)|*nes|All files (*.*)|*.*\"";
            this.openFileDialog1.Title = "Final Fantasy 2 Rom...";
            this.openFileDialog1.ShowDialog();
     

            PRG.ROM = File.ReadAllBytes(this.openFileDialog1.FileName);
            this.Tracklist.Enabled = true;
        }

        private void DecodeFF2Music()
        {

            //account for header size
           


            this.NewSongDataL.Text = " "; // hide song data text   
            int DutyMask = 0b11000000;
            int DutyResult = DutyMask & Convert.ToInt16(PRG.ROM[PRG.ROMOffset+1]);
            if (DutyResult >= 0x00 && DutyResult <=0x3F) { this.DutyCycle.Text = "0"; }
            if (DutyResult >= 0x40 && DutyResult <= 0x7F) { this.DutyCycle.Text = "1"; }
            if (DutyResult >= 0x80 && DutyResult <= 0xBF) { this.DutyCycle.Text = "2"; }
            if (DutyResult >= 0xC0 && DutyResult <= 0xFF) { this.DutyCycle.Text = "3"; }

            byte VMask = (byte)(PRG.ROM[PRG.ROMOffset + 1] << 4);
            if (VMask == 0x00) { this.Volume.Text = "No"; }
            if (VMask > 0x00) { this.Volume.Text = "Yes"; }

            this.NoteEnvelope.Text = (Convert.ToInt16(PRG.ROM[PRG.ROMOffset + 3]).ToString("x2").TrimStart('0')  + Convert.ToInt16(PRG.ROM[PRG.ROMOffset + 2]).ToString("x2").TrimStart('0'));
            this.PitchEnvelope.Text = (Convert.ToInt16(PRG.ROM[PRG.ROMOffset + 5]).ToString("x2").TrimStart('0')  + Convert.ToInt16(PRG.ROM[PRG.ROMOffset + 4]).ToString("x2").TrimStart('0'));
            this.TempoBox.Text = Convert.ToInt16(PRG.ROM[PRG.ROMOffset + 7]).ToString("x2").TrimStart('0');

            int LengthIndex = 1;

            while (PRG.ROM[PRG.ROMOffset + LengthIndex] != 0xF6)
            {
                LengthIndex++;
            }
            this.MusicSizeL.Text = ( "Bytes: "+ Convert.ToString(LengthIndex));

            PRG.IndexLength = LengthIndex ;
            //repurposing non global length index

            LengthIndex = 0;
            
            string OriginalMusicArray = "";
            int Newlineindex = 0;
            while (LengthIndex < PRG.IndexLength)
            {
                OriginalMusicArray += (Convert.ToInt16(PRG.ROM[PRG.ROMOffset + LengthIndex]).ToString("x2") + " ");
                if (Newlineindex == 15) { OriginalMusicArray += "\n"; Newlineindex = 0; }
                LengthIndex++;
                Newlineindex++;
                
            }


            this.SongDataL.Text = OriginalMusicArray;
            PRG.SequenceData = new byte[PRG.IndexLength];




            //this.NewSongDataL.Text =

           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void NoteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.NoteBox.SelectedIndex == 0) { PRG.Hibyte = 0x00; }   //C
            if (this.NoteBox.SelectedIndex == 1) { PRG.Hibyte = 0x10; }  //C#
            if (this.NoteBox.SelectedIndex == 2) { PRG.Hibyte = 0x20; }  //D
            if (this.NoteBox.SelectedIndex == 3) { PRG.Hibyte = 0x30; }  //D#
            if (this.NoteBox.SelectedIndex == 4) { PRG.Hibyte = 0x40; }  //E
            if (this.NoteBox.SelectedIndex == 5) { PRG.Hibyte = 0x50; }  //F
            if (this.NoteBox.SelectedIndex == 6) { PRG.Hibyte = 0x60; }  //F#
            if (this.NoteBox.SelectedIndex == 7) { PRG.Hibyte = 0x70; }  //G
            if (this.NoteBox.SelectedIndex == 8) { PRG.Hibyte = 0x80; }  //G#
            if (this.NoteBox.SelectedIndex == 9) { PRG.Hibyte = 0x90; }  //A
            if (this.NoteBox.SelectedIndex == 10){ PRG.Hibyte = 0xA0; } //A#
            if (this.NoteBox.SelectedIndex == 11){ PRG.Hibyte = 0xB0; } //B
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) //noteduration
        {
            if (this.Noteduration.SelectedIndex == 0) { PRG.Lobyte = 0x00; }  // whole
            if (this.Noteduration.SelectedIndex == 1) { PRG.Lobyte = 0x01; }  // dothalf
            if (this.Noteduration.SelectedIndex == 2) { PRG.Lobyte = 0x02; }  // half
            if (this.Noteduration.SelectedIndex == 3) { PRG.Lobyte = 0x03; }  // dot4th
            if (this.Noteduration.SelectedIndex == 4) { PRG.Lobyte = 0x04; }  // trihalf
            if (this.Noteduration.SelectedIndex == 5) { PRG.Lobyte = 0x05; }  // 4th
            if (this.Noteduration.SelectedIndex == 6) { PRG.Lobyte = 0x06; }  // dot8th
            if (this.Noteduration.SelectedIndex == 7) { PRG.Lobyte = 0x07; }  // tri4th
            if (this.Noteduration.SelectedIndex == 8) { PRG.Lobyte = 0x08; }  // 8th
            if (this.Noteduration.SelectedIndex == 9) { PRG.Lobyte = 0x09; }  // dot16th
            if (this.Noteduration.SelectedIndex == 10) { PRG.Lobyte = 0x0a; } // tri8th
            if (this.Noteduration.SelectedIndex == 11) { PRG.Lobyte = 0x0b; } // 16th
            if (this.Noteduration.SelectedIndex == 12) { PRG.Lobyte = 0x0b; } // tri16th
            if (this.Noteduration.SelectedIndex == 13) { PRG.Lobyte = 0x0d; } // 32nd
            if (this.Noteduration.SelectedIndex == 14) { PRG.Lobyte = 0x0e; } //tri32nd
            if (this.Noteduration.SelectedIndex == 15) { PRG.Lobyte = 0x0f; } //tri64th
        }

        private void AddNoteBTN_Click(object sender, EventArgs e)
        {

            //add octave data if changed
            if (PRG.CurrentOctave != PRG.LastOctave)
            {
                PRG.SequenceData[PRG.SequenceDataOffset] = PRG.CurrentOctave;
                PRG.LastOctave = PRG.CurrentOctave;

                this.NewSongDataL.Text += PRG.CurrentOctave.ToString("x2") + " ";
                PRG.SequenceDataOffset++;
                this.UsedBytesL.Text = ("Used: " + Convert.ToString(PRG.SEQIndex));
                PRG.SEQIndex++;
            }


            // add note data
            var CurrentSeqInt = PRG.Hibyte + PRG.Lobyte;
            
            // convert to byte and add to Byte Array
            PRG.CurrentSEQByte = Convert.ToByte(CurrentSeqInt);
            PRG.SequenceData[PRG.SequenceDataOffset] = PRG.CurrentSEQByte;

            // Add to String Represntation of Byte array
            this.NewSongDataL.Text += PRG.CurrentSEQByte.ToString("x2") + " ";
            PRG.SEQTextIndexCounter++;

            // Formatting for String Bar to look nice
            if (PRG.SEQTextIndexCounter >= 15)
            {
                PRG.SEQTextIndexCounter = 0;
                this.NewSongDataL.Text += "\n";
            }

            PRG.SequenceDataOffset++;
            PRG.SEQIndex++;
            
            this.UsedBytesL.Text = ("Used: " + Convert.ToString(PRG.SEQIndex));
        }

        private void AddRestBTN_Click(object sender, EventArgs e)
        {
            var CurrentSeqInt = 0xC0 + PRG.Lobyte; //0xCX is a rest...
            PRG.CurrentSEQByte = Convert.ToByte(CurrentSeqInt);
            PRG.SequenceData[PRG.SequenceDataOffset] = PRG.CurrentSEQByte;

           
            PRG.SEQArrayTEXT += (PRG.SequenceData[PRG.SequenceDataOffset].ToString("x2") + " ");
            if (PRG.SEQNewLineIndex == 15) { PRG.SEQArrayTEXT += "\n"; PRG.SEQNewLineIndex = 0; }
            PRG.SEQIndex++;
            PRG.SEQNewLineIndex++;

            this.NewSongDataL.Text += PRG.CurrentSEQByte.ToString("x2") + " ";
            PRG.SequenceDataOffset++;
            this.UsedBytesL.Text = ("Used: " + Convert.ToString(PRG.SEQIndex));
        }

        private void SaveToBinToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //save handler
            this.SaveAsRom.RestoreDirectory = true;
            this.SaveAsRom.Title = "Save BIN File...";
            this.SaveAsRom.DefaultExt = "bin";
            this.SaveAsRom.Filter = "BIN files (*.bin)|*bin|All files (*.*)|*.*\"";
            this.SaveAsRom.FileName = "FF2Music.BIN";
            this.SaveAsRom.CheckPathExists = true;
            this.SaveAsRom.ShowDialog();


            using (FileStream fs = File.Create(this.SaveAsRom.FileName))
            {
                // Add some text to file    
               
                fs.Write(PRG.SequenceData, 0, PRG.SequenceData.Length);
                fs.Close();
            }
        }

        

        private void UpdateHeaderButton_Click_1(object sender, EventArgs e)
        {

                string Notestr = this.NoteEnvelope.Text;
                var NoteEnvHi = Notestr.Substring(0, 2);
                var NoteEnvLo = Notestr.Substring(2, 2);

                string Pitchstr = this.PitchEnvelope.Text;
                var PitchEnvHi = Pitchstr.Substring(0, 2);
                var PitchEnvLo = Pitchstr.Substring(2, 2);

                byte DutyByte = 0x00;
                if (Volume.Text == "Yes") 
                {
                    // uses E for volume...
                    if (DutyCycle.Text == "0") { DutyByte = 0x3E; } 
                    if (DutyCycle.Text == "1") { DutyByte = 0x7E; }
                    if (DutyCycle.Text == "2") { DutyByte = 0xBE; }
                    if (DutyCycle.Text == "3") { DutyByte = 0xEE; }

                }
                
                if (Volume.Text == "No")
                {
                    if (DutyCycle.Text == "0") { DutyByte = 0x30; }
                    if (DutyCycle.Text == "1") { DutyByte = 0x70; }
                    if (DutyCycle.Text == "2") { DutyByte = 0xB0; }
                    if (DutyCycle.Text == "3") { DutyByte = 0xE0; }
                }



                //PRG.ROM[PRG.ROMOffset + 0] = NewHeader[0];
                // little endian on WORDS
                PRG.ROM[PRG.ROMOffset + 1] = DutyByte;
                PRG.ROM[PRG.ROMOffset + 2] = Convert.ToByte(NoteEnvLo,16);
                PRG.ROM[PRG.ROMOffset + 3] = Convert.ToByte(NoteEnvHi,16);
                PRG.ROM[PRG.ROMOffset + 4] = Convert.ToByte(PitchEnvLo,16);
                PRG.ROM[PRG.ROMOffset + 5] = Convert.ToByte(PitchEnvHi,16);

                if (PRG.HeaderType == "SQ1") { PRG.ROM[PRG.ROMOffset + 7] = Convert.ToByte(TempoBox.Text,16); }

            HeaderTypeOptions(); // to refesh header
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Octavelistbox.SelectedIndex == 0) { PRG.CurrentOctave = 0xF0; }
            if (this.Octavelistbox.SelectedIndex == 1) { PRG.CurrentOctave = 0xF1; }
            if (this.Octavelistbox.SelectedIndex == 2) { PRG.CurrentOctave = 0xF2; }
            if (this.Octavelistbox.SelectedIndex == 3) { PRG.CurrentOctave = 0xF3; }
            if (this.Octavelistbox.SelectedIndex == 4) { PRG.CurrentOctave = 0xF4; }
            if (this.Octavelistbox.SelectedIndex == 5) { PRG.CurrentOctave = 0xF5; }
        }

        private void SaveToRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            

            //acount for header
            int X = 0;
            if (PRG.HeaderType == "SQ1")
            {
                 X = 0x8;
            }
            if (PRG.HeaderType == "SQ2" || PRG.HeaderType == "TRI")
            {
                X = 0x6;
            }



            // fill msuic sequence
            int Y = 0;

            while (X < PRG.IndexLength) 
            {
                PRG.ROM[PRG.ROMOffset + X] = PRG.SequenceData[Y];
                X++;
                Y++;
                
                
            }
            this.Text = ("SEQ: " + PRG.SequenceData[0].ToString() + " ROM: " + PRG.ROM[PRG.ROMOffset].ToString() + " X:" + X + " IDL: " + PRG.IndexLength);


            //save handler
            this.SaveAsRom.RestoreDirectory = true;
            this.SaveAsRom.Title = "Save Rom File...";
            this.SaveAsRom.DefaultExt = "nes";
            this.SaveAsRom.Filter = "NES files (*.nes)|*nes|All files (*.*)|*.*\"";
            this.SaveAsRom.FileName = "FinalFantasy2_Music";
            this.SaveAsRom.CheckPathExists = true;
            this.SaveAsRom.ShowDialog();

           

            //write to file
            File.WriteAllBytes(this.SaveAsRom.FileName, PRG.ROM);

           // this.SaveAsRom.Dispose();

        }

        private void SaveAsBin_FileOk(object sender, CancelEventArgs e)
        {
            this.SaveAsBin.RestoreDirectory = true;
            this.SaveAsBin.Title = "Save BIN File...";
            this.SaveAsBin.DefaultExt = "bin";
            this.SaveAsBin.Filter = "BIN files (*.bin)|*bin|All files (*.*)|*.*\"";
            this.SaveAsBin.FileName = "FinalFantasy2_Music_BIN";
            this.SaveAsBin.CheckPathExists = true;
            this.SaveAsBin.ShowDialog();

            this.Text = "bion saved";
            //write to file
        
            File.WriteAllBytes(this.SaveAsBin.FileName, PRG.ROM);
            this.SaveAsBin.Dispose();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.CreditsWin.Text = "Credits?";
            this.CreditsWin.Size = new Size(400, 165);

            this.CreditsLabel.Text = (
                "Programmed by Scatfone" + "\n" 
                + "Utilities used:" + "\n"
                + "HxD" + "\n"
                + "Justin Olbrantz's FF2 Music Docs " + "\n"
                + "Datacrystal's FF2 ROM Map");
            this.CreditsLabel.Location = new Point(10, 20);

            this.CreditsWin.Controls.Add(CreditsLabel);
            this.CreditsWin.ShowDialog();
        }

        private void JumpBoxBTN_Click(object sender, EventArgs e)
        {
            // this is a FORCED JUMP!
            PRG.OddJumpType = false;
            PRG.RegularJumpType = false;
            AddJumpNote();
        }


        public void AddJumpNote()
        {
            

            // convert to byte and add to Byte Array
            PRG.SequenceData [PRG.SequenceDataOffset] = 0xFE; //JMP Byte
            PRG.SequenceDataOffset++;

            string JMPDummy = this.JumpBox.Text;
            var JMPHi = JMPDummy.Substring(0, 2);
            var JMPLo = JMPDummy.Substring(2, 2); 
            this.Text = (JMPHi + " " + JMPLo);

            // Little ENDIAN BS
            PRG.SequenceData[PRG.SequenceDataOffset] = Convert.ToByte(JMPHi,16); //JMP Hi Byte
            PRG.SequenceDataOffset++;
            PRG.SequenceData[PRG.SequenceDataOffset] = Convert.ToByte(JMPLo,16); //JMP Byte
            PRG.SequenceDataOffset++;

            PRG.SEQIndex = PRG.SEQIndex + 3;

            // DO THIS THRICE //////////////////////////////////////
            // Add to String Represntation of Byte array

            if (PRG.OddJumpType == false && PRG.RegularJumpType == false)
            {
                this.NewSongDataL.Text += 0xFE.ToString("x2") + " ";
            }
            if (PRG.OddJumpType == true)
            {
                this.NewSongDataL.Text += 0xFD.ToString("x2") + " ";
            }
            if (PRG.RegularJumpType == true)
            {
                this.NewSongDataL.Text += 0xFC.ToString("x2") + " ";
            }
            PRG.SEQTextIndexCounter++;

            // Formatting for String Bar to look nice
            if (PRG.SEQTextIndexCounter >= 15)
            {
                PRG.SEQTextIndexCounter = 0;
                this.NewSongDataL.Text += "\n";
            }

            //////////////////////////////////////////////////////
            // Add to String Represntation of Byte array
            this.NewSongDataL.Text += JMPHi + " ";
            PRG.SEQTextIndexCounter++;

            // Formatting for String Bar to look nice
            if (PRG.SEQTextIndexCounter >= 15)
            {
                 PRG.SEQTextIndexCounter = 0;
                 this.NewSongDataL.Text += "\n";
            }

            ///////////////////////////////////////////////////////
            // Add to String Represntation of Byte array
            this.NewSongDataL.Text += JMPLo + " ";
            PRG.SEQTextIndexCounter++;

            // Formatting for String Bar to look nice
            if (PRG.SEQTextIndexCounter >= 15)
            {
                 PRG.SEQTextIndexCounter = 0;
                 this.NewSongDataL.Text += "\n";
            }

            PRG.OddJumpType = false;
            PRG.RegularJumpType = false; // Clear jump flags

            this.UsedBytesL.Text = ("Used: " + Convert.ToString(PRG.SEQIndex));
        }


        private void EndLoopButton_Click(object sender, EventArgs e)
        {
            PRG.RegularJumpType = true;
            PRG.OddJumpType = false;
            AddJumpNote();
        }

        private void OddJumpButton_Click(object sender, EventArgs e)
        {
            PRG.RegularJumpType = false;
            PRG.OddJumpType = true;
            AddJumpNote();
        }

        private void jumpsLoopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.JumpEXPWin.Text = "Jumps Explained";
            
            this.CreditsLabel.Text = ( 
                "Looping works by setting a loop counter and jumping to a RAM Address when said counter hits a certain number. \n" +
                "There are 3 Jump options. Jump uncondionally, Jump when counter is 0, and Jump when counter is an odd number. \n" +
                "The Sound data has a Weirdly styled Address you jump too, and it is LITTLE ENDIAN! Each song has a different offset.\n" +
                "To Find the \"Offset\", Take the ROM Address of the track and add 4 to the Hi Nibble of the First byte,\n" +
                "And then Subtract 1 from Hi Nibble of the Second Byte to find the \"Offset\". REMEMBER IT IS HEX NUMBERS!"
              );
            this.CreditsLabel.Location = new Point(10, 20);

            this.JumpEXPWin.Controls.Add(CreditsLabel);
            this.JumpEXPWin.ShowDialog();
        }

        private void notePitchEnvelopesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.JumpEXPWin.Text = "Envelop Addresses";
            this.CreditsLabel.Text = (
                " Volume Envelopes: bd04, bd15, bd26, bd37, bd43, bd6a, bd99, bdd2, be66, be87, beaf.\n" +
                " Pitch Envelopes: bec4, bec7, becb, bedd, bee0, bee4, bef9, befb, befd.\n" +
                " Its possible to write your own note envelops but thats beyond the scope of this Program atm..."
                );
            this.CreditsLabel.Location = new Point(10, 20);

            this.JumpEXPWin.Controls.Add(CreditsLabel);
            this.JumpEXPWin.ShowDialog();
        }

        
    }
}
