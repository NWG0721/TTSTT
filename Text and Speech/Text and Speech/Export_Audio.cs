using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.AudioFormat;

namespace Text_and_Speech
{
    public partial class Export_Audio : Form
    {
        int Bit_rate = 8;
        int SpRate = 44100;
        SpeechAudioFormatInfo formatInfo;

        public Export_Audio()
        {
            InitializeComponent();
        }

        private void Export_Audio_Load(object sender, EventArgs e)
        {
            bit_8.Checked = true;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bit_16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            if (bit_8.Checked == true)
            {
                formatInfo = new SpeechAudioFormatInfo(SpRate, AudioBitsPerSample.Eight, AudioChannel.Mono);
            }
            else if (bit_16.Checked == true)
            {
                formatInfo = new SpeechAudioFormatInfo(SpRate, AudioBitsPerSample.Sixteen, AudioChannel.Mono);
            }
            //= new SpeechAudioFormatInfo(,Bit_rate, AudioChannel.Mono);// AudioBitsPerSample
        }

        private void SR_Bar_Scroll(object sender, EventArgs e)
        {
            SR_Bar.Minimum = 44100;
            SR_Bar.Maximum = 192000;
            SpRate = SR_Bar.Value;
            bar_shower.Text = SR_Bar.Value.ToString();
        }
    }
}
