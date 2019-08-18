namespace mandelbrot_set
{
    partial class profiDialog
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
            this.nudKolikBar = new System.Windows.Forms.NumericUpDown();
            this.butB1 = new System.Windows.Forms.Button();
            this.butB2 = new System.Windows.Forms.Button();
            this.butB5 = new System.Windows.Forms.Button();
            this.butB6 = new System.Windows.Forms.Button();
            this.butB8 = new System.Windows.Forms.Button();
            this.butB7 = new System.Windows.Forms.Button();
            this.butB4 = new System.Windows.Forms.Button();
            this.butB3 = new System.Windows.Forms.Button();
            this.butB15 = new System.Windows.Forms.Button();
            this.butB16 = new System.Windows.Forms.Button();
            this.butB12 = new System.Windows.Forms.Button();
            this.butB11 = new System.Windows.Forms.Button();
            this.butB13 = new System.Windows.Forms.Button();
            this.butB14 = new System.Windows.Forms.Button();
            this.butB10 = new System.Windows.Forms.Button();
            this.butB9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTlac = new System.Windows.Forms.GroupBox();
            this.nudPocKroku = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.butstorno = new System.Windows.Forms.Button();
            this.butok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolikBar)).BeginInit();
            this.gbTlac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPocKroku)).BeginInit();
            this.SuspendLayout();
            // 
            // nudKolikBar
            // 
            this.nudKolikBar.Location = new System.Drawing.Point(97, 12);
            this.nudKolikBar.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudKolikBar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolikBar.Name = "nudKolikBar";
            this.nudKolikBar.Size = new System.Drawing.Size(75, 20);
            this.nudKolikBar.TabIndex = 0;
            this.nudKolikBar.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudKolikBar.ValueChanged += new System.EventHandler(this.nudKolikBar_ValueChanged);
            // 
            // butB1
            // 
            this.butB1.BackColor = System.Drawing.Color.Blue;
            this.butB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB1.Location = new System.Drawing.Point(6, 19);
            this.butB1.Name = "butB1";
            this.butB1.Size = new System.Drawing.Size(75, 55);
            this.butB1.TabIndex = 1;
            this.butB1.Text = "1";
            this.butB1.UseVisualStyleBackColor = false;
            this.butB1.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB2
            // 
            this.butB2.BackColor = System.Drawing.Color.Red;
            this.butB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB2.Location = new System.Drawing.Point(87, 19);
            this.butB2.Name = "butB2";
            this.butB2.Size = new System.Drawing.Size(75, 55);
            this.butB2.TabIndex = 2;
            this.butB2.Text = "2";
            this.butB2.UseVisualStyleBackColor = false;
            this.butB2.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB5
            // 
            this.butB5.BackColor = System.Drawing.Color.Lime;
            this.butB5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB5.Location = new System.Drawing.Point(6, 141);
            this.butB5.Name = "butB5";
            this.butB5.Size = new System.Drawing.Size(75, 55);
            this.butB5.TabIndex = 3;
            this.butB5.Text = "5";
            this.butB5.UseVisualStyleBackColor = false;
            this.butB5.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB6
            // 
            this.butB6.BackColor = System.Drawing.Color.Magenta;
            this.butB6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB6.Location = new System.Drawing.Point(87, 141);
            this.butB6.Name = "butB6";
            this.butB6.Size = new System.Drawing.Size(75, 55);
            this.butB6.TabIndex = 4;
            this.butB6.Text = "6";
            this.butB6.UseVisualStyleBackColor = false;
            this.butB6.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB8
            // 
            this.butB8.BackColor = System.Drawing.Color.Aqua;
            this.butB8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB8.Location = new System.Drawing.Point(87, 202);
            this.butB8.Name = "butB8";
            this.butB8.Size = new System.Drawing.Size(75, 55);
            this.butB8.TabIndex = 8;
            this.butB8.Text = "8";
            this.butB8.UseVisualStyleBackColor = false;
            this.butB8.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB7
            // 
            this.butB7.BackColor = System.Drawing.Color.PeachPuff;
            this.butB7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB7.Location = new System.Drawing.Point(6, 202);
            this.butB7.Name = "butB7";
            this.butB7.Size = new System.Drawing.Size(75, 55);
            this.butB7.TabIndex = 7;
            this.butB7.Text = "7";
            this.butB7.UseVisualStyleBackColor = false;
            this.butB7.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB4
            // 
            this.butB4.BackColor = System.Drawing.Color.Silver;
            this.butB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB4.Location = new System.Drawing.Point(87, 80);
            this.butB4.Name = "butB4";
            this.butB4.Size = new System.Drawing.Size(75, 55);
            this.butB4.TabIndex = 6;
            this.butB4.Text = "4";
            this.butB4.UseVisualStyleBackColor = false;
            this.butB4.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB3
            // 
            this.butB3.BackColor = System.Drawing.Color.Orange;
            this.butB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB3.Location = new System.Drawing.Point(6, 80);
            this.butB3.Name = "butB3";
            this.butB3.Size = new System.Drawing.Size(75, 55);
            this.butB3.TabIndex = 5;
            this.butB3.Text = "3";
            this.butB3.UseVisualStyleBackColor = false;
            this.butB3.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB15
            // 
            this.butB15.BackColor = System.Drawing.Color.Green;
            this.butB15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB15.Location = new System.Drawing.Point(168, 202);
            this.butB15.Name = "butB15";
            this.butB15.Size = new System.Drawing.Size(75, 55);
            this.butB15.TabIndex = 16;
            this.butB15.Text = "15";
            this.butB15.UseVisualStyleBackColor = false;
            this.butB15.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB16
            // 
            this.butB16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butB16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB16.Location = new System.Drawing.Point(249, 202);
            this.butB16.Name = "butB16";
            this.butB16.Size = new System.Drawing.Size(75, 55);
            this.butB16.TabIndex = 15;
            this.butB16.Text = "16";
            this.butB16.UseVisualStyleBackColor = false;
            this.butB16.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB12
            // 
            this.butB12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butB12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB12.Location = new System.Drawing.Point(249, 80);
            this.butB12.Name = "butB12";
            this.butB12.Size = new System.Drawing.Size(75, 55);
            this.butB12.TabIndex = 14;
            this.butB12.Text = "12";
            this.butB12.UseVisualStyleBackColor = false;
            this.butB12.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB11
            // 
            this.butB11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butB11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB11.Location = new System.Drawing.Point(168, 80);
            this.butB11.Name = "butB11";
            this.butB11.Size = new System.Drawing.Size(75, 55);
            this.butB11.TabIndex = 13;
            this.butB11.Text = "11";
            this.butB11.UseVisualStyleBackColor = false;
            this.butB11.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB13
            // 
            this.butB13.BackColor = System.Drawing.Color.HotPink;
            this.butB13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB13.Location = new System.Drawing.Point(168, 141);
            this.butB13.Name = "butB13";
            this.butB13.Size = new System.Drawing.Size(75, 55);
            this.butB13.TabIndex = 12;
            this.butB13.Text = "13";
            this.butB13.UseVisualStyleBackColor = false;
            this.butB13.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB14
            // 
            this.butB14.BackColor = System.Drawing.Color.HotPink;
            this.butB14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB14.Location = new System.Drawing.Point(249, 141);
            this.butB14.Name = "butB14";
            this.butB14.Size = new System.Drawing.Size(75, 55);
            this.butB14.TabIndex = 11;
            this.butB14.Text = "14";
            this.butB14.UseVisualStyleBackColor = false;
            this.butB14.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB10
            // 
            this.butB10.BackColor = System.Drawing.Color.LavenderBlush;
            this.butB10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB10.Location = new System.Drawing.Point(249, 19);
            this.butB10.Name = "butB10";
            this.butB10.Size = new System.Drawing.Size(75, 55);
            this.butB10.TabIndex = 10;
            this.butB10.Text = "10";
            this.butB10.UseVisualStyleBackColor = false;
            this.butB10.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // butB9
            // 
            this.butB9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butB9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butB9.Location = new System.Drawing.Point(168, 19);
            this.butB9.Name = "butB9";
            this.butB9.Size = new System.Drawing.Size(75, 55);
            this.butB9.TabIndex = 9;
            this.butB9.Text = "9";
            this.butB9.UseVisualStyleBackColor = false;
            this.butB9.Click += new System.EventHandler(this.vyberBarvy);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "number of color";
            // 
            // gbTlac
            // 
            this.gbTlac.Controls.Add(this.butB7);
            this.gbTlac.Controls.Add(this.butB1);
            this.gbTlac.Controls.Add(this.butB15);
            this.gbTlac.Controls.Add(this.butB2);
            this.gbTlac.Controls.Add(this.butB16);
            this.gbTlac.Controls.Add(this.butB5);
            this.gbTlac.Controls.Add(this.butB12);
            this.gbTlac.Controls.Add(this.butB6);
            this.gbTlac.Controls.Add(this.butB11);
            this.gbTlac.Controls.Add(this.butB3);
            this.gbTlac.Controls.Add(this.butB13);
            this.gbTlac.Controls.Add(this.butB4);
            this.gbTlac.Controls.Add(this.butB14);
            this.gbTlac.Controls.Add(this.butB8);
            this.gbTlac.Controls.Add(this.butB10);
            this.gbTlac.Controls.Add(this.butB9);
            this.gbTlac.Location = new System.Drawing.Point(10, 66);
            this.gbTlac.Name = "gbTlac";
            this.gbTlac.Size = new System.Drawing.Size(336, 266);
            this.gbTlac.TabIndex = 18;
            this.gbTlac.TabStop = false;
            this.gbTlac.Text = "colors";
            // 
            // nudPocKroku
            // 
            this.nudPocKroku.Location = new System.Drawing.Point(97, 40);
            this.nudPocKroku.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPocKroku.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPocKroku.Name = "nudPocKroku";
            this.nudPocKroku.Size = new System.Drawing.Size(75, 20);
            this.nudPocKroku.TabIndex = 29;
            this.nudPocKroku.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "color step";
            // 
            // butstorno
            // 
            this.butstorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butstorno.Location = new System.Drawing.Point(12, 338);
            this.butstorno.Name = "butstorno";
            this.butstorno.Size = new System.Drawing.Size(64, 23);
            this.butstorno.TabIndex = 31;
            this.butstorno.Text = "Cancel";
            this.butstorno.UseVisualStyleBackColor = true;
            this.butstorno.Click += new System.EventHandler(this.butstorno_Click);
            // 
            // butok
            // 
            this.butok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butok.Location = new System.Drawing.Point(82, 338);
            this.butok.Name = "butok";
            this.butok.Size = new System.Drawing.Size(64, 23);
            this.butok.TabIndex = 32;
            this.butok.Text = "OK";
            this.butok.UseVisualStyleBackColor = true;
            this.butok.Click += new System.EventHandler(this.butok_Click);
            // 
            // profiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 371);
            this.Controls.Add(this.butok);
            this.Controls.Add(this.butstorno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPocKroku);
            this.Controls.Add(this.gbTlac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudKolikBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "profiDialog";
            this.Text = "Professional ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.profiDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudKolikBar)).EndInit();
            this.gbTlac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPocKroku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudKolikBar;
        private System.Windows.Forms.Button butB1;
        private System.Windows.Forms.Button butB2;
        private System.Windows.Forms.Button butB5;
        private System.Windows.Forms.Button butB6;
        private System.Windows.Forms.Button butB8;
        private System.Windows.Forms.Button butB7;
        private System.Windows.Forms.Button butB4;
        private System.Windows.Forms.Button butB3;
        private System.Windows.Forms.Button butB15;
        private System.Windows.Forms.Button butB16;
        private System.Windows.Forms.Button butB12;
        private System.Windows.Forms.Button butB11;
        private System.Windows.Forms.Button butB13;
        private System.Windows.Forms.Button butB14;
        private System.Windows.Forms.Button butB10;
        private System.Windows.Forms.Button butB9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTlac;
        private System.Windows.Forms.NumericUpDown nudPocKroku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butstorno;
        private System.Windows.Forms.Button butok;
    }
}