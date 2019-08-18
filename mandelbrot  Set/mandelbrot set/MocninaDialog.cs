using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace mandelbrot_set
{
    public partial class MocninaDialog : Form
    {

        public bool JeReal { get; private set;}
        public double Real { get; private set;}
        public Complex KomplexMoc { get; private set; }


        public MocninaDialog(double real, Complex comp, bool jeR)
        {
            InitializeComponent();
            rbKomp.Checked = jeR;
            nudMocnina.Value = Convert.ToDecimal(real);
            nudReal.Value = Convert.ToDecimal(comp.Real);
            nudIma.Value = Convert.ToDecimal(comp.Imaginary);
        }

        private void MocninaDialog_Load(object sender, EventArgs e)
        {
            if (!MandelbrotSet.tmavý)
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                gbKomp.ForeColor = gbReal.ForeColor = this.ForeColor = Color.White;
            }
            
        }

        private void rbReal_CheckedChanged(object sender, EventArgs e)
        {
            nudMocnina.Enabled = !nudMocnina.Enabled;
            nudReal.Enabled = !nudReal.Enabled;
            nudIma.Enabled = !nudIma.Enabled;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void butOk_Click(object sender, EventArgs e)
        {
            JeReal = rbReal.Checked;
            if (JeReal)
                Real = Convert.ToDouble(nudMocnina.Value);
            else
                KomplexMoc = new Complex(Convert.ToDouble(nudReal.Value), Convert.ToDouble(nudIma.Value));
            this.Close();
        }

        private void MocninaDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult != DialogResult.OK)
            //{
            //    DialogResult = DialogResult.Cancel;
            //}
        }
    }
}
