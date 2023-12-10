using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Speech.AudioFormat;

namespace Text_and_Speech
{
    public partial class main_Form : Form
    {

        //
        //For moving form
        //
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF010;

        int height = Screen.PrimaryScreen.Bounds.Height;
        int width = Screen.PrimaryScreen.Bounds.Width;

        public void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE | 0x2, 0);
            }
        }
        //
        //For moving form
        //

        //
        //For Form Header
        //
        bool restore = true;

        private void Min_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Rest_Btn_Click(object sender, EventArgs e)
        {

            if (restore == true)
            {
                WindowState = FormWindowState.Maximized;
                restore = false;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                restore = true;
            }

        }

        private void set_Restore()
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    restore = true;
                }
                else
                {
                    restore = false;
                }
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //
        //For Form Header
        //

        //
        //Form Settings
        //
        SpeechSynthesizer reader;
        public main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader = new SpeechSynthesizer();
            Resume.Enabled = false;
            stop_btn.Enabled = false;
            Pause_btn.Enabled = false;
        }

        //
        //Form Settings
        //

    }
}
