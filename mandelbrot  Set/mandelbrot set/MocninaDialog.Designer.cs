namespace mandelbrot_set
{
    partial class MocninaDialog
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
            this.rbReal = new System.Windows.Forms.RadioButton();
            this.rbKomp = new System.Windows.Forms.RadioButton();
            this.gbReal = new System.Windows.Forms.GroupBox();
            this.nudMocnina = new System.Windows.Forms.NumericUpDown();
            this.gbKomp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudIma = new System.Windows.Forms.NumericUpDown();
            this.nudReal = new System.Windows.Forms.NumericUpDown();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.gbReal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMocnina)).BeginInit();
            this.gbKomp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "vyberte mocninu";
            // 
            // rbReal
            // 
            this.rbReal.AutoSize = true;
            this.rbReal.Checked = true;
            this.rbReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReal.Location = new System.Drawing.Point(21, 37);
            this.rbReal.Name = "rbReal";
            this.rbReal.Size = new System.Drawing.Size(73, 17);
            this.rbReal.TabIndex = 2;
            this.rbReal.TabStop = true;
            this.rbReal.Text = "real power";
            this.rbReal.UseVisualStyleBackColor = true;
            this.rbReal.CheckedChanged += new System.EventHandler(this.rbReal_CheckedChanged);
            // 
            // rbKomp
            // 
            this.rbKomp.AutoSize = true;
            this.rbKomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbKomp.Location = new System.Drawing.Point(216, 37);
            this.rbKomp.Name = "rbKomp";
            this.rbKomp.Size = new System.Drawing.Size(95, 17);
            this.rbKomp.TabIndex = 3;
            this.rbKomp.Text = "complex power";
            this.rbKomp.UseVisualStyleBackColor = true;
            // 
            // gbReal
            // 
            this.gbReal.Controls.Add(this.nudMocnina);
            this.gbReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbReal.Location = new System.Drawing.Point(15, 70);
            this.gbReal.Name = "gbReal";
            this.gbReal.Size = new System.Drawing.Size(188, 64);
            this.gbReal.TabIndex = 4;
            this.gbReal.TabStop = false;
            this.gbReal.Text = "real";
            // 
            // nudMocnina
            // 
            this.nudMocnina.DecimalPlaces = 5;
            this.nudMocnina.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMocnina.Location = new System.Drawing.Point(6, 19);
            this.nudMocnina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMocnina.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudMocnina.Name = "nudMocnina";
            this.nudMocnina.Size = new System.Drawing.Size(150, 20);
            this.nudMocnina.TabIndex = 6;
            // 
            // gbKomp
            // 
            this.gbKomp.Controls.Add(this.label3);
            this.gbKomp.Controls.Add(this.label2);
            this.gbKomp.Controls.Add(this.nudIma);
            this.gbKomp.Controls.Add(this.nudReal);
            this.gbKomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbKomp.Location = new System.Drawing.Point(210, 70);
            this.gbKomp.Name = "gbKomp";
            this.gbKomp.Size = new System.Drawing.Size(200, 68);
            this.gbKomp.TabIndex = 5;
            this.gbKomp.TabStop = false;
            this.gbKomp.Text = "complex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "imaginary part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "real part";
            // 
            // nudIma
            // 
            this.nudIma.DecimalPlaces = 5;
            this.nudIma.Enabled = false;
            this.nudIma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIma.Location = new System.Drawing.Point(104, 33);
            this.nudIma.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudIma.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudIma.Name = "nudIma";
            this.nudIma.Size = new System.Drawing.Size(90, 20);
            this.nudIma.TabIndex = 8;
            // 
            // nudReal
            // 
            this.nudReal.DecimalPlaces = 5;
            this.nudReal.Enabled = false;
            this.nudReal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudReal.Location = new System.Drawing.Point(6, 33);
            this.nudReal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudReal.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudReal.Name = "nudReal";
            this.nudReal.Size = new System.Drawing.Size(90, 20);
            this.nudReal.TabIndex = 7;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Location = new System.Drawing.Point(248, 144);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOk
            // 
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOk.Location = new System.Drawing.Point(329, 144);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 7;
            this.butOk.Text = "OK";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // MocninaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 175);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.gbKomp);
            this.Controls.Add(this.gbReal);
            this.Controls.Add(this.rbKomp);
            this.Controls.Add(this.rbReal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MocninaDialog";
            this.Text = "Powers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MocninaDialog_FormClosing);
            this.Load += new System.EventHandler(this.MocninaDialog_Load);
            this.gbReal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMocnina)).EndInit();
            this.gbKomp.ResumeLayout(false);
            this.gbKomp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbReal;
        private System.Windows.Forms.RadioButton rbKomp;
        private System.Windows.Forms.GroupBox gbReal;
        private System.Windows.Forms.GroupBox gbKomp;
        private System.Windows.Forms.NumericUpDown nudMocnina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIma;
        private System.Windows.Forms.NumericUpDown nudReal;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOk;
    }
}