using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Runtime.Remoting.Messaging;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;
using System.Speech.AudioFormat;
using System.Security.Cryptography;



namespace Text_and_Speech
{
    public partial class main_Form
    {

        Thread trd;
        bool ready = false;
        bool Saved = false;
        string _File_Name_;

        VoiceAge _VoiceAge_;
        VoiceGender voiceGender;


        Export_Audio EA = new Export_Audio();
        private void Play_btn_Click(object sender, EventArgs e)
        {

            reader.Dispose();
            if (Left_Box.Text != "")
            {
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(voiceGender, _VoiceAge_);
                reader.SpeakAsync(Left_Box.Text);
                Pause_btn.Enabled = true;
                stop_btn.Enabled = true;
                Resume.Enabled = false;
                ready = true;
                Status_Mode.Text = "Speaking";
            }
            else
            {
                MessageBox.Show("Please enter some text in the textbox", "hey you!!!", MessageBoxButtons.OK);
            }
        }
        public void stop_btn_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
                Resume.Enabled = false;
                stop_btn.Enabled = false;
                Pause_btn.Enabled = false;
                Status_Mode.Text = "Stoped";
            }
        }
        public void Pause_btn_Click(object sender, EventArgs e)
        {
            if (reader != null && reader.State == SynthesizerState.Speaking)
            {
                reader.Pause();
                Resume.Enabled = true;
                Status_Mode.Text = "Paused";
            }
        }
        public void Resume_Click(object sender, EventArgs e)
        {
            if (reader != null && reader.State == SynthesizerState.Paused)
            {
                reader.Resume();
                Resume.Enabled = false;
                Status_Mode.Text = "Speaking Again";
            }
        }
        //                                              //
        //             For tool strip menu              //
        //                                              //

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Left_Box.Text != null && Left_Box.Text != "The quick brown fox jumps over the lazy dog")
            {

                if (MessageBox.Show("Do you want to save?????????", "Save??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveFileDialog1.Filter = "Text to speech file|*.TTSX";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, Left_Box.Text);
                        Saved = true;
                        _File_Name_ = saveFileDialog1.FileName;
                    }
                }
                else
                {
                    Left_Box.Text = "";
                }
            }
            else
            {
                Left_Box.Text = "";
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text to speech file|*.TTSX";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && Saved == true)
            {
                Left_Box.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
            else
            {
                savemetode();
                Left_Box.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savemetode();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == false)
            {
                if (MessageBox.Show("Do you want to save?????????", "Save??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveFileDialog1.Filter = "Text to speech file|*.TTSX";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, Left_Box.Text);
                        Saved = true;
                        _File_Name_ = saveFileDialog1.FileName;
                    }
                    else
                    {
                        MessageBox.Show("There is nothing we can do");
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EA.Show();
        }

        private void savemetode()
        {
            if (Saved == false)
            {
                if (MessageBox.Show("Do you want to save?????????", "Save??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveFileDialog1.Filter = "Text to speech file|*.TTSX";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog1.FileName, Left_Box.Text);
                        Saved = true;
                        _File_Name_ = saveFileDialog1.FileName;
                    }
                    else
                    {
                        MessageBox.Show("There is nothing we can do");
                    }
                }
            }
            else
            {
                reader.SelectVoiceByHints(VoiceGender.Neutral);

                System.IO.File.WriteAllText(saveFileDialog1.FileName, Left_Box.Text);
            }
        }

        private void P1_RB_CheckedChanged(object sender, EventArgs e)
        {
            voiceGender = VoiceGender.Neutral;
        }

        private void P2_RB_CheckedChanged(object sender, EventArgs e)
        {
            voiceGender = VoiceGender.Female;
        }

        private void P3_RB_CheckedChanged(object sender, EventArgs e)
        {
            voiceGender = VoiceGender.Male;
        }

        private void Left_Box_TextChanged(object sender, EventArgs e)
        {
        }

        private void AgeNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeTrak_Scroll(object sender, EventArgs e)
        {
            switch (AgeTrak.Value)
            {
                case 0:
                    _VoiceAge_ = VoiceAge.NotSet;
                    AgeNameLabel.Text = "Default";
                    break;
                case 1:
                    _VoiceAge_ = VoiceAge.Child;
                    AgeNameLabel.Text = "Child";
                    break;
                case 2:
                    _VoiceAge_ = VoiceAge.Teen;
                    AgeNameLabel.Text = "Teenager";
                    break;
                case 3:
                    _VoiceAge_ = VoiceAge.Adult;
                    AgeNameLabel.Text = "Adult";
                    break;
                case 4:
                    _VoiceAge_ = VoiceAge.Senior;
                    AgeNameLabel.Text = "Old";
                    break;
            }
        }
    }
}
