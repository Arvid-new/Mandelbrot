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
    public partial class profiDialog : Form
    {
        public Color[] Barvy = new Color[16];
        public int pocetKrok;
        Color[] PredBarvy;


        public profiDialog(int PocetKroku, Color[] BarvIn)
        {
            InitializeComponent();
            nudKolikBar.Value = BarvIn.Length;
            nudPocKroku.Value = Convert.ToDecimal(PocetKroku);

            if (!MandelbrotSet.tmavý)
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                gbTlac.ForeColor = this.ForeColor = Color.White;
            }

            #region barvy 
            Button on = new Button();
            for (int i = 0; i < BarvIn.Length ; i++)
            {
                foreach (Button item in gbTlac.Controls)
                {
                    if (Convert.ToInt16(item.Text) == i + 1)
                    {
                        on = item;
                    }
                }
                on.BackColor = BarvIn[i];
                float Prumer = (on.BackColor.R + on.BackColor.G + on.BackColor.B);

                if (Prumer > 200)
                {
                    on.ForeColor = Color.Black;
                }
                else
                {
                    on.ForeColor = Color.White;
                }
            }

            ZobrazButny();
            
            #endregion


        }

        private void ZobrazButny() {
            int pocetZobrazenych = 0;

            foreach (Control item in gbTlac.Controls)
            {
                if (Convert.ToInt16(item.Text) > nudKolikBar.Value)
                {
                    item.Visible = false;
                }
                else {
                    item.Visible = true;
                    pocetZobrazenych++;
                }
            }

            if (pocetZobrazenych == 1)
            {
                this.Width = 179;
                gbTlac.Width = this.Width - 30;
            }
            else if (pocetZobrazenych<9)
            {
                this.Width = 202;
                gbTlac.Width = this.Width - 30;
            }
            else if (pocetZobrazenych==9)
            {
                this.Width = 289;
                gbTlac.Width = this.Width - 30;
            }
            else
            {
                this.Width = 377;
                gbTlac.Width = this.Width - 30;
            }
        }
        
        private void nudKolikBar_ValueChanged(object sender, EventArgs e)
        {
            ZobrazButny();
        }

        private void butok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Barvy = new Color[Convert.ToInt16(nudKolikBar.Value)];
            foreach (Button item in gbTlac.Controls)
            {
                if (item.Visible)
                {
                    Barvy[Convert.ToInt16(item.Text)- 1] = item.BackColor;
                }
            }
            pocetKrok = Convert.ToInt16(nudPocKroku.Value);

            this.Close();
        }

        private void profiDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                return;
            }

            DialogResult = DialogResult.Cancel;
        }

        private void vyberBarvy(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog() {Color=((Control)sender).BackColor};
            if (cd.ShowDialog() == DialogResult.OK)
            {
                ((Control)sender).BackColor = cd.Color;

                float Prumer = (((Control)sender).BackColor.R + ((Control)sender).BackColor.G + ((Control)sender).BackColor.B);

                if (Prumer > 200)
                {
                    ((Control)sender).ForeColor = Color.Black;
                }
                else
                {
                    ((Control)sender).ForeColor = Color.White;
                }
                kresleniPrev();
            }
        }

        private void kresleniPrev() {
            kresleni.barvyProfi = new Color[Convert.ToInt16(nudKolikBar.Value)];
            foreach (Button item in gbTlac.Controls)
            {
                if (item.Visible)
                {
                    kresleni.barvyProfi[Convert.ToInt16(item.Text) - 1] = item.BackColor;
                }
            }
            pbPre.Image = kresleni.kresli(pbPre.Width, pbPre.Height);
        }

        private void butstorno_Click(object sender, EventArgs e)
        {
            kresleni.barvyProfi = PredBarvy;
            this.Close();
        }

        private void profiDialog_Load(object sender, EventArgs e)
        {
            PredBarvy = kresleni.barvyProfi;
            kresleniPrev();
        }
    }
}
