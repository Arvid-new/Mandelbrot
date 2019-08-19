using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot_set
{
    public partial class ResoDialog : Form
    {
        public int Res  { get; set;} = 1280;

        public ResoDialog()
        {
            InitializeComponent();
        }

        private void ResoDialog_Load(object sender, EventArgs e)
        {
            if (!MandelbrotSet.tmavý)
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                this.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nudCustomRe.Visible = ((RadioButton)sender).Checked;
        }

        private void rb8K_Click(object sender, EventArgs e)
        {
            RadioButton sen = (RadioButton)sender;
            if (sen.Checked)
            {
                if (sen.Name == rb720p.Name)
                {
                    Res = 1280;
                }
                else if (sen.Name == rb1080p.Name)
                {
                    Res = 1920;
                }
                else if (sen.Name == rb8K.Name)
                {
                    Res = 7680;
                }
                else
                {
                    Res = 3840;
                }
            }
        }

        private void nudCustomRe_ValueChanged(object sender, EventArgs e)
        {
            Res = Convert.ToInt32(((NumericUpDown)sender).Value);
        }
    }
}
