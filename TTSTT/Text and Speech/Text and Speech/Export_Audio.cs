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
using Text_and_Speech;
using System.Speech.Synthesis;

namespace Text_and_Speech
{
    public partial class Export_Audio : Form
    {
        int Bit_rate = 8;
        int SpRate = 44100;
        SpeechAudioFormatInfo formatInfo;
        SpeechSynthesizer Speaker = new SpeechSynthesizer();
        Stream stream = new MemoryStream();
        public SpeechSynthesizer speechSynthesizer;

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


        public void synthesizer()
        {
            stream = new MemoryStream();
            Speaker.SetOutputToWaveFile(FileDestinationText.Text,formatInfo);
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            if (bit_8.Checked == true)
            {
                formatInfo = new SpeechAudioFormatInfo(SpRate, AudioBitsPerSample.Eight, AudioChannel.Mono);
                synthesizer();

            }
            else if (bit_16.Checked == true)
            {
                formatInfo = new SpeechAudioFormatInfo(SpRate, AudioBitsPerSample.Sixteen, AudioChannel.Mono);
                synthesizer();
            }
        }

        private void SR_Bar_Scroll(object sender, EventArgs e)
        {
            SR_Bar.Minimum = 44100;
            SR_Bar.Maximum = 192000;
            SpRate = SR_Bar.Value;
            bar_shower.Text = SR_Bar.Value.ToString();
        }

        private void newButton11_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = FileNameText.Text;
            saveFileDialog1.Filter = "Audio File (*.wav, *.mp3, *.ogg)|*.wav";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileDestinationText.Text = saveFileDialog1.FileName;
            }
        }
    }
}
