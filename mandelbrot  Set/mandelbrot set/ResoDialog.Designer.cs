namespace mandelbrot_set
{
    partial class ResoDialog
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
            this.rb8K = new System.Windows.Forms.RadioButton();
            this.rb720p = new System.Windows.Forms.RadioButton();
            this.rb1080p = new System.Windows.Forms.RadioButton();
            this.rbUHD = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.nudCustomRe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomRe)).BeginInit();
            this.SuspendLayout();
            // 
            // rb8K
            // 
            this.rb8K.AutoSize = true;
            this.rb8K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb8K.Location = new System.Drawing.Point(12, 12);
            this.rb8K.Name = "rb8K";
            this.rb8K.Size = new System.Drawing.Size(81, 17);
            this.rb8K.TabIndex = 8;
            this.rb8K.Text = "8K Ultra HD";
            this.rb8K.UseVisualStyleBackColor = true;
            this.rb8K.Click += new System.EventHandler(this.rb8K_Click);
            // 
            // rb720p
            // 
            this.rb720p.AutoSize = true;
            this.rb720p.Checked = true;
            this.rb720p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb720p.Location = new System.Drawing.Point(12, 81);
            this.rb720p.Name = "rb720p";
            this.rb720p.Size = new System.Drawing.Size(48, 17);
            this.rb720p.TabIndex = 7;
            this.rb720p.TabStop = true;
            this.rb720p.Text = "720p";
            this.rb720p.UseVisualStyleBackColor = true;
            this.rb720p.Click += new System.EventHandler(this.rb8K_Click);
            // 
            // rb1080p
            // 
            this.rb1080p.AutoSize = true;
            this.rb1080p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb1080p.Location = new System.Drawing.Point(12, 58);
            this.rb1080p.Name = "rb1080p";
            this.rb1080p.Size = new System.Drawing.Size(54, 17);
            this.rb1080p.TabIndex = 6;
            this.rb1080p.Text = "1080p";
            this.rb1080p.UseVisualStyleBackColor = true;
            this.rb1080p.Click += new System.EventHandler(this.rb8K_Click);
            // 
            // rbUHD
            // 
            this.rbUHD.AutoSize = true;
            this.rbUHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbUHD.Location = new System.Drawing.Point(12, 35);
            this.rbUHD.Name = "rbUHD";
            this.rbUHD.Size = new System.Drawing.Size(65, 17);
            this.rbUHD.TabIndex = 5;
            this.rbUHD.Text = "Ultra HD";
            this.rbUHD.UseVisualStyleBackColor = true;
            this.rbUHD.Click += new System.EventHandler(this.rb8K_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(93, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(12, 104);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Custom";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nudCustomRe
            // 
            this.nudCustomRe.Location = new System.Drawing.Point(93, 101);
            this.nudCustomRe.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCustomRe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomRe.Name = "nudCustomRe";
            this.nudCustomRe.Size = new System.Drawing.Size(75, 20);
            this.nudCustomRe.TabIndex = 12;
            this.nudCustomRe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomRe.Visible = false;
            this.nudCustomRe.ValueChanged += new System.EventHandler(this.nudCustomRe_ValueChanged);
            // 
            // ResoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(186, 159);
            this.Controls.Add(this.nudCustomRe);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb8K);
            this.Controls.Add(this.rb720p);
            this.Controls.Add(this.rb1080p);
            this.Controls.Add(this.rbUHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResoDialog";
            this.Text = "ResoDialog";
            this.Load += new System.EventHandler(this.ResoDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb8K;
        private System.Windows.Forms.RadioButton rb720p;
        private System.Windows.Forms.RadioButton rb1080p;
        private System.Windows.Forms.RadioButton rbUHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown nudCustomRe;
    }
}