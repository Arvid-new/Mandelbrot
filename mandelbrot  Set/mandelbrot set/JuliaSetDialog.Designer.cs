namespace mandelbrot_set
{
    partial class JuliaSetDialog
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
            this.butOK = new System.Windows.Forms.Button();
            this.butCancle = new System.Windows.Forms.Button();
            this.nudReal = new System.Windows.Forms.NumericUpDown();
            this.nudIma = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // butOK
            // 
            this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.Location = new System.Drawing.Point(93, 64);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 0;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancle
            // 
            this.butCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancle.Location = new System.Drawing.Point(12, 64);
            this.butCancle.Name = "butCancle";
            this.butCancle.Size = new System.Drawing.Size(75, 23);
            this.butCancle.TabIndex = 1;
            this.butCancle.Text = "Cancel";
            this.butCancle.UseVisualStyleBackColor = true;
            this.butCancle.Click += new System.EventHandler(this.butCancle_Click);
            // 
            // nudReal
            // 
            this.nudReal.DecimalPlaces = 8;
            this.nudReal.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.nudReal.Location = new System.Drawing.Point(12, 26);
            this.nudReal.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudReal.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudReal.Name = "nudReal";
            this.nudReal.Size = new System.Drawing.Size(75, 20);
            this.nudReal.TabIndex = 2;
            this.nudReal.ValueChanged += new System.EventHandler(this.nudReal_ValueChanged);
            // 
            // nudIma
            // 
            this.nudIma.DecimalPlaces = 8;
            this.nudIma.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.nudIma.Location = new System.Drawing.Point(93, 26);
            this.nudIma.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudIma.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudIma.Name = "nudIma";
            this.nudIma.Size = new System.Drawing.Size(75, 20);
            this.nudIma.TabIndex = 3;
            this.nudIma.ValueChanged += new System.EventHandler(this.nudIma_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "real part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "imaginary part";
            // 
            // pbPrev
            // 
            this.pbPrev.Location = new System.Drawing.Point(175, 10);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(75, 75);
            this.pbPrev.TabIndex = 6;
            this.pbPrev.TabStop = false;
            // 
            // JuliaSetDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 95);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudIma);
            this.Controls.Add(this.nudReal);
            this.Controls.Add(this.butCancle);
            this.Controls.Add(this.butOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "JuliaSetDialog";
            this.Text = "Julia Set";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JuliaSetDialog_FormClosing);
            this.Load += new System.EventHandler(this.JuliaSetDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancle;
        private System.Windows.Forms.NumericUpDown nudReal;
        private System.Windows.Forms.NumericUpDown nudIma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPrev;
    }
}