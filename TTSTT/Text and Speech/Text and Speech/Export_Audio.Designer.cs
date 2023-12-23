namespace Text_and_Speech
{
    partial class Export_Audio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileDestinationText = new AltoControls.AltoTextBox();
            this.FileNameText = new AltoControls.AltoTextBox();
            this.bit_8 = new System.Windows.Forms.RadioButton();
            this.bit_16 = new System.Windows.Forms.RadioButton();
            this.SR_Bar = new System.Windows.Forms.TrackBar();
            this.bar_shower = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Cancel_btn = new Text_and_Speech.NewButton1();
            this.Export_btn = new Text_and_Speech.NewButton1();
            this.newButton11 = new Text_and_Speech.NewButton1();
            ((System.ComponentModel.ISupportInitialize)(this.SR_Bar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saving a Audio File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "File name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(16, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sampel Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bit Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(16, 430);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "File destination";
            // 
            // FileDestinationText
            // 
            this.FileDestinationText.BackColor = System.Drawing.Color.Transparent;
            this.FileDestinationText.Br = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileDestinationText.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.FileDestinationText.ForeColor = System.Drawing.Color.DimGray;
            this.FileDestinationText.Location = new System.Drawing.Point(268, 423);
            this.FileDestinationText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileDestinationText.Name = "FileDestinationText";
            this.FileDestinationText.Size = new System.Drawing.Size(396, 41);
            this.FileDestinationText.TabIndex = 5;
            // 
            // FileNameText
            // 
            this.FileNameText.BackColor = System.Drawing.Color.Transparent;
            this.FileNameText.Br = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileNameText.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.FileNameText.ForeColor = System.Drawing.Color.DimGray;
            this.FileNameText.Location = new System.Drawing.Point(169, 96);
            this.FileNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(445, 41);
            this.FileNameText.TabIndex = 8;
            // 
            // bit_8
            // 
            this.bit_8.AutoSize = true;
            this.bit_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bit_8.ForeColor = System.Drawing.Color.White;
            this.bit_8.Location = new System.Drawing.Point(164, 17);
            this.bit_8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bit_8.Name = "bit_8";
            this.bit_8.Size = new System.Drawing.Size(93, 33);
            this.bit_8.TabIndex = 12;
            this.bit_8.TabStop = true;
            this.bit_8.Text = "8 Bits";
            this.bit_8.UseVisualStyleBackColor = true;
            // 
            // bit_16
            // 
            this.bit_16.AutoSize = true;
            this.bit_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bit_16.ForeColor = System.Drawing.Color.White;
            this.bit_16.Location = new System.Drawing.Point(164, 82);
            this.bit_16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bit_16.Name = "bit_16";
            this.bit_16.Size = new System.Drawing.Size(106, 33);
            this.bit_16.TabIndex = 13;
            this.bit_16.TabStop = true;
            this.bit_16.Text = "16 Bits";
            this.bit_16.UseVisualStyleBackColor = true;
            this.bit_16.CheckedChanged += new System.EventHandler(this.bit_16_CheckedChanged);
            // 
            // SR_Bar
            // 
            this.SR_Bar.Location = new System.Drawing.Point(213, 174);
            this.SR_Bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SR_Bar.Name = "SR_Bar";
            this.SR_Bar.Size = new System.Drawing.Size(344, 56);
            this.SR_Bar.TabIndex = 14;
            this.SR_Bar.Scroll += new System.EventHandler(this.SR_Bar_Scroll);
            // 
            // bar_shower
            // 
            this.bar_shower.AutoSize = true;
            this.bar_shower.BackColor = System.Drawing.Color.Black;
            this.bar_shower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_shower.ForeColor = System.Drawing.Color.Silver;
            this.bar_shower.Location = new System.Drawing.Point(585, 174);
            this.bar_shower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bar_shower.Name = "bar_shower";
            this.bar_shower.Size = new System.Drawing.Size(78, 29);
            this.bar_shower.TabIndex = 15;
            this.bar_shower.Text = "44100";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bit_8);
            this.panel1.Controls.Add(this.bit_16);
            this.panel1.Location = new System.Drawing.Point(16, 236);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 159);
            this.panel1.TabIndex = 19;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cancel_btn.FlatAppearance.BorderSize = 0;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(357, 490);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(200, 49);
            this.Cancel_btn.TabIndex = 11;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Export_btn
            // 
            this.Export_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Export_btn.FlatAppearance.BorderSize = 0;
            this.Export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_btn.ForeColor = System.Drawing.Color.White;
            this.Export_btn.Location = new System.Drawing.Point(565, 490);
            this.Export_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(200, 49);
            this.Export_btn.TabIndex = 10;
            this.Export_btn.Text = "Export";
            this.Export_btn.UseVisualStyleBackColor = false;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // newButton11
            // 
            this.newButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newButton11.FlatAppearance.BorderSize = 0;
            this.newButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton11.ForeColor = System.Drawing.Color.Black;
            this.newButton11.Image = global::Text_and_Speech.Properties.Resources.save_2;
            this.newButton11.Location = new System.Drawing.Point(672, 420);
            this.newButton11.Margin = new System.Windows.Forms.Padding(4);
            this.newButton11.Name = "newButton11";
            this.newButton11.Size = new System.Drawing.Size(53, 49);
            this.newButton11.TabIndex = 9;
            this.newButton11.UseVisualStyleBackColor = true;
            this.newButton11.Click += new System.EventHandler(this.newButton11_Click);
            // 
            // Export_Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bar_shower);
            this.Controls.Add(this.SR_Bar);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Export_btn);
            this.Controls.Add(this.newButton11);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.FileDestinationText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Export_Audio";
            this.Text = "Export Audio";
            this.Load += new System.EventHandler(this.Export_Audio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SR_Bar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox FileDestinationText;
        private AltoControls.AltoTextBox FileNameText;
        private NewButton1 newButton11;
        private NewButton1 Export_btn;
        private NewButton1 Cancel_btn;
        private System.Windows.Forms.RadioButton bit_8;
        private System.Windows.Forms.RadioButton bit_16;
        private System.Windows.Forms.TrackBar SR_Bar;
        private System.Windows.Forms.Label bar_shower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}