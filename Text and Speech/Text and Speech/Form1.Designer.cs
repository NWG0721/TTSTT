﻿namespace Text_and_Speech
{
    partial class main_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new AltoControls.AltoButton();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.Min_Btn = new AltoControls.AltoButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Max_Rest_Btn = new AltoControls.AltoButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Exit_Btn = new AltoControls.AltoButton();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.Text_Seting = new System.Windows.Forms.TabPage();
            this.TTS = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.main_Tabs = new System.Windows.Forms.TabControl();
            this.STT = new System.Windows.Forms.TabPage();
            this.splitter16 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Status_Mode = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.splitter15 = new System.Windows.Forms.Splitter();
            this.Resume = new Text_and_Speech.NewButton1();
            this.splitter14 = new System.Windows.Forms.Splitter();
            this.stop_btn = new Text_and_Speech.NewButton1();
            this.splitter13 = new System.Windows.Forms.Splitter();
            this.Pause_btn = new Text_and_Speech.NewButton1();
            this.splitter12 = new System.Windows.Forms.Splitter();
            this.Play_btn = new Text_and_Speech.NewButton1();
            this.splitter11 = new System.Windows.Forms.Splitter();
            this.splitter10 = new System.Windows.Forms.Splitter();
            this.splitter9 = new System.Windows.Forms.Splitter();
            this.Left_Box = new System.Windows.Forms.RichTextBox();
            this.Voice_Seting = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.P3_RB = new System.Windows.Forms.RadioButton();
            this.P2_RB = new System.Windows.Forms.RadioButton();
            this.P1_RB = new System.Windows.Forms.RadioButton();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.splitter8 = new System.Windows.Forms.Splitter();
            this.Menu_1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.TTS.SuspendLayout();
            this.main_Tabs.SuspendLayout();
            this.STT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Voice_Seting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Menu_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.Min_Btn);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.Max_Rest_Btn);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 40);
            this.panel1.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.Active1 = System.Drawing.Color.Black;
            this.Header.Active2 = System.Drawing.Color.Black;
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Header.ForeColor = System.Drawing.Color.LimeGreen;
            this.Header.Inactive1 = System.Drawing.Color.Black;
            this.Header.Inactive2 = System.Drawing.Color.Black;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Radius = 10;
            this.Header.Size = new System.Drawing.Size(863, 40);
            this.Header.Stroke = false;
            this.Header.StrokeColor = System.Drawing.Color.Gray;
            this.Header.TabIndex = 6;
            this.Header.Text = "TEXT AND SPEECH";
            this.Header.Transparency = false;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(863, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(6, 40);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // Min_Btn
            // 
            this.Min_Btn.Active1 = System.Drawing.Color.Lime;
            this.Min_Btn.Active2 = System.Drawing.Color.Lime;
            this.Min_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Min_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Min_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Min_Btn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Min_Btn.ForeColor = System.Drawing.Color.Black;
            this.Min_Btn.Inactive1 = System.Drawing.Color.Yellow;
            this.Min_Btn.Inactive2 = System.Drawing.Color.Lime;
            this.Min_Btn.Location = new System.Drawing.Point(869, 0);
            this.Min_Btn.Name = "Min_Btn";
            this.Min_Btn.Radius = 10;
            this.Min_Btn.Size = new System.Drawing.Size(40, 40);
            this.Min_Btn.Stroke = false;
            this.Min_Btn.StrokeColor = System.Drawing.Color.Gray;
            this.Min_Btn.TabIndex = 4;
            this.Min_Btn.Text = "─";
            this.Min_Btn.Transparency = false;
            this.Min_Btn.Click += new System.EventHandler(this.Min_Btn_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(909, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 40);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // Max_Rest_Btn
            // 
            this.Max_Rest_Btn.Active1 = System.Drawing.Color.Yellow;
            this.Max_Rest_Btn.Active2 = System.Drawing.Color.Yellow;
            this.Max_Rest_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Max_Rest_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Max_Rest_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Max_Rest_Btn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Max_Rest_Btn.ForeColor = System.Drawing.Color.Black;
            this.Max_Rest_Btn.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Max_Rest_Btn.Inactive2 = System.Drawing.Color.Yellow;
            this.Max_Rest_Btn.Location = new System.Drawing.Point(915, 0);
            this.Max_Rest_Btn.Name = "Max_Rest_Btn";
            this.Max_Rest_Btn.Radius = 10;
            this.Max_Rest_Btn.Size = new System.Drawing.Size(40, 40);
            this.Max_Rest_Btn.Stroke = false;
            this.Max_Rest_Btn.StrokeColor = System.Drawing.Color.Gray;
            this.Max_Rest_Btn.TabIndex = 2;
            this.Max_Rest_Btn.Text = "❐";
            this.Max_Rest_Btn.Transparency = false;
            this.Max_Rest_Btn.Click += new System.EventHandler(this.Max_Rest_Btn_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(955, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 40);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit_Btn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Exit_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Btn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Exit_Btn.ForeColor = System.Drawing.Color.Black;
            this.Exit_Btn.Inactive1 = System.Drawing.Color.Red;
            this.Exit_Btn.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit_Btn.Location = new System.Drawing.Point(961, 0);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Radius = 10;
            this.Exit_Btn.Size = new System.Drawing.Size(40, 40);
            this.Exit_Btn.Stroke = false;
            this.Exit_Btn.StrokeColor = System.Drawing.Color.Gray;
            this.Exit_Btn.TabIndex = 0;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.Transparency = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // splitter4
            // 
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(0, 40);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(9, 534);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter5.Enabled = false;
            this.splitter5.Location = new System.Drawing.Point(992, 40);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(9, 534);
            this.splitter5.TabIndex = 2;
            this.splitter5.TabStop = false;
            // 
            // Text_Seting
            // 
            this.Text_Seting.Location = new System.Drawing.Point(4, 22);
            this.Text_Seting.Name = "Text_Seting";
            this.Text_Seting.Padding = new System.Windows.Forms.Padding(3);
            this.Text_Seting.Size = new System.Drawing.Size(975, 457);
            this.Text_Seting.TabIndex = 3;
            this.Text_Seting.Text = "Text Seting";
            this.Text_Seting.UseVisualStyleBackColor = true;
            // 
            // TTS
            // 
            this.TTS.BackColor = System.Drawing.Color.Black;
            this.TTS.Controls.Add(this.richTextBox1);
            this.TTS.Location = new System.Drawing.Point(4, 22);
            this.TTS.Name = "TTS";
            this.TTS.Padding = new System.Windows.Forms.Padding(3);
            this.TTS.Size = new System.Drawing.Size(975, 457);
            this.TTS.TabIndex = 2;
            this.TTS.Text = "Speech To Text";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Location = new System.Drawing.Point(588, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(384, 451);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // main_Tabs
            // 
            this.main_Tabs.Controls.Add(this.STT);
            this.main_Tabs.Controls.Add(this.TTS);
            this.main_Tabs.Controls.Add(this.Text_Seting);
            this.main_Tabs.Controls.Add(this.Voice_Seting);
            this.main_Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Tabs.Location = new System.Drawing.Point(9, 82);
            this.main_Tabs.Name = "main_Tabs";
            this.main_Tabs.SelectedIndex = 0;
            this.main_Tabs.Size = new System.Drawing.Size(983, 483);
            this.main_Tabs.TabIndex = 18;
            // 
            // STT
            // 
            this.STT.BackColor = System.Drawing.Color.Black;
            this.STT.Controls.Add(this.splitter16);
            this.STT.Controls.Add(this.panel2);
            this.STT.Controls.Add(this.splitter15);
            this.STT.Controls.Add(this.Resume);
            this.STT.Controls.Add(this.splitter14);
            this.STT.Controls.Add(this.stop_btn);
            this.STT.Controls.Add(this.splitter13);
            this.STT.Controls.Add(this.Pause_btn);
            this.STT.Controls.Add(this.splitter12);
            this.STT.Controls.Add(this.Play_btn);
            this.STT.Controls.Add(this.splitter11);
            this.STT.Controls.Add(this.splitter10);
            this.STT.Controls.Add(this.splitter9);
            this.STT.Controls.Add(this.Left_Box);
            this.STT.Location = new System.Drawing.Point(4, 22);
            this.STT.Name = "STT";
            this.STT.Padding = new System.Windows.Forms.Padding(3);
            this.STT.Size = new System.Drawing.Size(975, 457);
            this.STT.TabIndex = 1;
            this.STT.Text = "Text To Speech";
            // 
            // splitter16
            // 
            this.splitter16.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter16.Enabled = false;
            this.splitter16.Location = new System.Drawing.Point(448, 421);
            this.splitter16.Name = "splitter16";
            this.splitter16.Size = new System.Drawing.Size(463, 19);
            this.splitter16.TabIndex = 26;
            this.splitter16.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Status_Mode);
            this.panel2.Controls.Add(this.Status_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(448, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 28);
            this.panel2.TabIndex = 25;
            // 
            // Status_Mode
            // 
            this.Status_Mode.AutoSize = true;
            this.Status_Mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.Status_Mode.Font = new System.Drawing.Font("NPINazaninTitr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Mode.ForeColor = System.Drawing.Color.White;
            this.Status_Mode.Location = new System.Drawing.Point(64, 0);
            this.Status_Mode.Name = "Status_Mode";
            this.Status_Mode.Size = new System.Drawing.Size(47, 21);
            this.Status_Mode.TabIndex = 1;
            this.Status_Mode.Text = " none";
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Status_label.Font = new System.Drawing.Font("NPINazaninTitr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_label.ForeColor = System.Drawing.Color.White;
            this.Status_label.Location = new System.Drawing.Point(0, 0);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(64, 21);
            this.Status_label.TabIndex = 0;
            this.Status_label.Text = "Status: ";
            // 
            // splitter15
            // 
            this.splitter15.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter15.Enabled = false;
            this.splitter15.Location = new System.Drawing.Point(448, 373);
            this.splitter15.Name = "splitter15";
            this.splitter15.Size = new System.Drawing.Size(463, 20);
            this.splitter15.TabIndex = 24;
            this.splitter15.TabStop = false;
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Resume.Dock = System.Windows.Forms.DockStyle.Top;
            this.Resume.FlatAppearance.BorderSize = 0;
            this.Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume.Font = new System.Drawing.Font("Electroharmonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.ForeColor = System.Drawing.Color.Red;
            this.Resume.Location = new System.Drawing.Point(448, 303);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(463, 70);
            this.Resume.TabIndex = 23;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // splitter14
            // 
            this.splitter14.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter14.Enabled = false;
            this.splitter14.Location = new System.Drawing.Point(448, 283);
            this.splitter14.Name = "splitter14";
            this.splitter14.Size = new System.Drawing.Size(463, 20);
            this.splitter14.TabIndex = 22;
            this.splitter14.TabStop = false;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stop_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Electroharmonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.ForeColor = System.Drawing.Color.Blue;
            this.stop_btn.Location = new System.Drawing.Point(448, 213);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(463, 70);
            this.stop_btn.TabIndex = 21;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // splitter13
            // 
            this.splitter13.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter13.Enabled = false;
            this.splitter13.Location = new System.Drawing.Point(448, 193);
            this.splitter13.Name = "splitter13";
            this.splitter13.Size = new System.Drawing.Size(463, 20);
            this.splitter13.TabIndex = 20;
            this.splitter13.TabStop = false;
            // 
            // Pause_btn
            // 
            this.Pause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Pause_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pause_btn.FlatAppearance.BorderSize = 0;
            this.Pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_btn.Font = new System.Drawing.Font("Electroharmonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_btn.ForeColor = System.Drawing.Color.Black;
            this.Pause_btn.Location = new System.Drawing.Point(448, 123);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(463, 70);
            this.Pause_btn.TabIndex = 19;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = false;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // splitter12
            // 
            this.splitter12.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter12.Enabled = false;
            this.splitter12.Location = new System.Drawing.Point(448, 103);
            this.splitter12.Name = "splitter12";
            this.splitter12.Size = new System.Drawing.Size(463, 20);
            this.splitter12.TabIndex = 18;
            this.splitter12.TabStop = false;
            // 
            // Play_btn
            // 
            this.Play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Play_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Play_btn.FlatAppearance.BorderSize = 0;
            this.Play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_btn.Font = new System.Drawing.Font("Electroharmonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_btn.ForeColor = System.Drawing.Color.Fuchsia;
            this.Play_btn.Location = new System.Drawing.Point(448, 33);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(463, 70);
            this.Play_btn.TabIndex = 17;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = false;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // splitter11
            // 
            this.splitter11.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter11.Enabled = false;
            this.splitter11.Location = new System.Drawing.Point(448, 3);
            this.splitter11.Name = "splitter11";
            this.splitter11.Size = new System.Drawing.Size(463, 30);
            this.splitter11.TabIndex = 16;
            this.splitter11.TabStop = false;
            // 
            // splitter10
            // 
            this.splitter10.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter10.Enabled = false;
            this.splitter10.Location = new System.Drawing.Point(911, 3);
            this.splitter10.Name = "splitter10";
            this.splitter10.Size = new System.Drawing.Size(61, 451);
            this.splitter10.TabIndex = 2;
            this.splitter10.TabStop = false;
            // 
            // splitter9
            // 
            this.splitter9.Location = new System.Drawing.Point(387, 3);
            this.splitter9.Name = "splitter9";
            this.splitter9.Size = new System.Drawing.Size(61, 451);
            this.splitter9.TabIndex = 1;
            this.splitter9.TabStop = false;
            // 
            // Left_Box
            // 
            this.Left_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Left_Box.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Box.Location = new System.Drawing.Point(3, 3);
            this.Left_Box.Name = "Left_Box";
            this.Left_Box.Size = new System.Drawing.Size(384, 451);
            this.Left_Box.TabIndex = 0;
            this.Left_Box.Text = "The quick brown fox jumps over the lazy dog";
            // 
            // Voice_Seting
            // 
            this.Voice_Seting.BackColor = System.Drawing.Color.Black;
            this.Voice_Seting.Controls.Add(this.groupBox1);
            this.Voice_Seting.Location = new System.Drawing.Point(4, 22);
            this.Voice_Seting.Name = "Voice_Seting";
            this.Voice_Seting.Padding = new System.Windows.Forms.Padding(3);
            this.Voice_Seting.Size = new System.Drawing.Size(975, 457);
            this.Voice_Seting.TabIndex = 4;
            this.Voice_Seting.Text = "Voice Seting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("G2 Rubber Stamp LET", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voice Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("G2 Rubber Stamp LET", 14.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(310, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 131);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Narrator\'s voice person";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.P3_RB);
            this.groupBox2.Controls.Add(this.P2_RB);
            this.groupBox2.Controls.Add(this.P1_RB);
            this.groupBox2.Font = new System.Drawing.Font("G2 Rubber Stamp LET", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(6, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Narrator\'s voice person";
            // 
            // P3_RB
            // 
            this.P3_RB.AutoSize = true;
            this.P3_RB.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3_RB.Location = new System.Drawing.Point(3, 78);
            this.P3_RB.Name = "P3_RB";
            this.P3_RB.Size = new System.Drawing.Size(292, 26);
            this.P3_RB.TabIndex = 2;
            this.P3_RB.TabStop = true;
            this.P3_RB.Text = "man";
            this.P3_RB.UseVisualStyleBackColor = true;
            this.P3_RB.CheckedChanged += new System.EventHandler(this.P3_RB_CheckedChanged);
            // 
            // P2_RB
            // 
            this.P2_RB.AutoSize = true;
            this.P2_RB.Dock = System.Windows.Forms.DockStyle.Top;
            this.P2_RB.Location = new System.Drawing.Point(3, 52);
            this.P2_RB.Name = "P2_RB";
            this.P2_RB.Size = new System.Drawing.Size(292, 26);
            this.P2_RB.TabIndex = 1;
            this.P2_RB.TabStop = true;
            this.P2_RB.Text = "Woman";
            this.P2_RB.UseVisualStyleBackColor = true;
            this.P2_RB.CheckedChanged += new System.EventHandler(this.P2_RB_CheckedChanged);
            // 
            // P1_RB
            // 
            this.P1_RB.AutoSize = true;
            this.P1_RB.Checked = true;
            this.P1_RB.Dock = System.Windows.Forms.DockStyle.Top;
            this.P1_RB.Location = new System.Drawing.Point(3, 26);
            this.P1_RB.Name = "P1_RB";
            this.P1_RB.Size = new System.Drawing.Size(292, 26);
            this.P1_RB.TabIndex = 0;
            this.P1_RB.TabStop = true;
            this.P1_RB.Text = "Neutral";
            this.P1_RB.UseVisualStyleBackColor = true;
            this.P1_RB.CheckedChanged += new System.EventHandler(this.P1_RB_CheckedChanged);
            // 
            // splitter7
            // 
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter7.Enabled = false;
            this.splitter7.Location = new System.Drawing.Point(9, 73);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(983, 9);
            this.splitter7.TabIndex = 17;
            this.splitter7.TabStop = false;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter6.Enabled = false;
            this.splitter6.Location = new System.Drawing.Point(9, 565);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(983, 9);
            this.splitter6.TabIndex = 9;
            this.splitter6.TabStop = false;
            // 
            // splitter8
            // 
            this.splitter8.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter8.Enabled = false;
            this.splitter8.Location = new System.Drawing.Point(9, 40);
            this.splitter8.Name = "splitter8";
            this.splitter8.Size = new System.Drawing.Size(983, 9);
            this.splitter8.TabIndex = 12;
            this.splitter8.TabStop = false;
            // 
            // Menu_1
            // 
            this.Menu_1.BackColor = System.Drawing.Color.Black;
            this.Menu_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.Menu_1.Location = new System.Drawing.Point(9, 49);
            this.Menu_1.Name = "Menu_1";
            this.Menu_1.Size = new System.Drawing.Size(983, 24);
            this.Menu_1.TabIndex = 16;
            this.Menu_1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1001, 574);
            this.Controls.Add(this.main_Tabs);
            this.Controls.Add(this.splitter7);
            this.Controls.Add(this.Menu_1);
            this.Controls.Add(this.splitter8);
            this.Controls.Add(this.splitter6);
            this.Controls.Add(this.splitter5);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.TTS.ResumeLayout(false);
            this.main_Tabs.ResumeLayout(false);
            this.STT.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Voice_Seting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Menu_1.ResumeLayout(false);
            this.Menu_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton Min_Btn;
        private System.Windows.Forms.Splitter splitter2;
        private AltoControls.AltoButton Max_Rest_Btn;
        private System.Windows.Forms.Splitter splitter1;
        private AltoControls.AltoButton Exit_Btn;
        private AltoControls.AltoButton Header;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.TabPage Text_Seting;
        private System.Windows.Forms.TabPage TTS;
        private System.Windows.Forms.TabControl main_Tabs;
        private System.Windows.Forms.TabPage STT;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Splitter splitter8;
        private System.Windows.Forms.MenuStrip Menu_1;
        private System.Windows.Forms.RichTextBox Left_Box;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Splitter splitter9;
        private System.Windows.Forms.Splitter splitter10;
        private NewButton1 Play_btn;
        private System.Windows.Forms.Splitter splitter15;
        private NewButton1 Resume;
        private System.Windows.Forms.Splitter splitter14;
        private NewButton1 stop_btn;
        private System.Windows.Forms.Splitter splitter13;
        private NewButton1 Pause_btn;
        private System.Windows.Forms.Splitter splitter11;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter12;
        private System.Windows.Forms.Splitter splitter16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Status_label;
        public System.Windows.Forms.Label Status_Mode;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage Voice_Seting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton P3_RB;
        private System.Windows.Forms.RadioButton P2_RB;
        private System.Windows.Forms.RadioButton P1_RB;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

