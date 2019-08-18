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
    public partial class JuliaSetDialog : Form
    {
        bool predJuliaSet;
        double predRealJS;
        double predImaJS;
        double predXz;
        double predYz;
        double predXk;
        double predYk;

        public JuliaSetDialog()
        {
            predJuliaSet = kresleni.JuliasSet;
            predRealJS = kresleni.RealJS;
            predImaJS = kresleni.ImaJS;

            predXz = kresleni.zacX;
            predYz = kresleni.zacY;
            predXk = kresleni.konX;
            predYk = kresleni.konY;

            kresleni.zacX = kresleni.zacY = 2;
            kresleni.konX = kresleni.konY = -2;

            kresleni.JuliasSet = true;
            
            InitializeComponent();

            nudIma.Value = Convert.ToDecimal(predImaJS);
            nudReal.Value = Convert.ToDecimal(predRealJS);
        }

        private void JuliaSetDialog_Load(object sender, EventArgs e)
        {
            if (!MandelbrotSet.tmavý)
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                this.ForeColor = Color.White;
            }

            pbPrev.Image = kresleni.kresli(pbPrev.Height, pbPrev.Width);
        }

        private void nudReal_ValueChanged(object sender, EventArgs e)
        {
            kresleni.RealJS = Convert.ToDouble(nudReal.Value);
            pbPrev.Image = kresleni.kresli(pbPrev.Height, pbPrev.Width);
        }

        private void nudIma_ValueChanged(object sender, EventArgs e)
        {
            kresleni.ImaJS = Convert.ToDouble(nudIma.Value);
            pbPrev.Image = kresleni.kresli(pbPrev.Height, pbPrev.Width);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JuliaSetDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                kresleni.zacX = predXz;
                kresleni.zacY = predYz;
                kresleni.konX = predXk;
                kresleni.konY = predYk;

                kresleni.JuliasSet = predJuliaSet;
                kresleni.ImaJS = predImaJS;
                kresleni.RealJS = predRealJS;
            }
            else
            {
                kresleni.zacX = predXz;
                kresleni.zacY = predYz;
                kresleni.konX = predXk;
                kresleni.konY = predYk;

                kresleni.JuliasSet = predJuliaSet;
            }
        }
    }
}
