using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot_set
{
    public partial class MandelbrotSet : Form
    {
        #region proměné
        Random nc = new Random();

        public static Stack<double> PzacX = new Stack<double>();
        public static Stack<double> PkonX = new Stack<double>();
        public static Stack<double> PzacY = new Stack<double>();
        public static Stack<double> PkonY = new Stack<double>();
        
        int sirka, vyzka;
        bool zapinam = true;

        bool nerestaruj = false;


        //bool chciProgress = false;

        //List<Point> BodyProg = new List<Point>();

        bool chciZaverecnyD = false;
        #endregion

        public MandelbrotSet()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


            pbkresleni.Image = new Bitmap(pbkresleni.Width,pbkresleni.Height);
            for (int w = 0; w < pbkresleni.Width; w++)
            {
                for (int h = 0; h < pbkresleni.Height; h++)
                {
                    ((Bitmap)pbkresleni.Image).SetPixel(w, h, Color.Black);
                }
            }

            if (zapinam)
            {
                #region auto velikost
                int velDis = Screen.GetWorkingArea(this).Height - 200;
                if (velDis < 0) velDis = 100;
                if (velDis > 800) velDis = 800;

                nudZmenaVelikosti.Value = velDis;

                #endregion

                kresleni.counter--;
                //DialogResult dr = MessageBox.Show("Stiskem tlačítka ok stvrzujete, že nebudete bez povolení autora šížit jakýmkoliv způsobem obsah vytvořený touto aplikací", "Upozornění", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                //if (dr != DialogResult.OK)
                //{
                //    this.Close();
                //}
                chciZaverecnyD = true;
                
            }
          
            PzacX.Push(-2);
            PkonX.Push(2);
            PzacY.Push(-2);
            PkonY.Push(2);
            sirka = pbkresleni.Width;
            vyzka = pbkresleni.Height;
           kresleni.hezkebarvy.Add(Color.FromArgb(nc.Next(256), nc.Next(256), nc.Next(256)));
            kresleni.counter++;
            pbkresleni.Image = kresleni.kresli(vyzka, sirka);
        }

        #region tlacitka
        private void button1_Click(object sender, EventArgs e)
        {
            kresleni.counter++;
            pbkresleni.Image = kresleni.kresli(vyzka,sirka);
          /*  if (rbStinovani.Checked || rbTmaveni.Checked)
            {
                if (rbTmaveni.Checked)
                {
                    vyberMod(rbTmaveni, e);
                }
                else
                {
                    vyberMod(rbStinovani, e);
                }
            }*/
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            PzacX.Clear();
            PkonX.Clear();
            PkonY.Clear();
            PzacY.Clear();
            kresleni.zacX = -2;
            kresleni.konX = 2;
            kresleni.zacY = -2;
            kresleni.konY = 2;
            kresleni.counter = 0;
            kresleni.hezkebarvy.Clear();
            Form1_Load(sender, e);
            lblHR.Text = $"{kresleni.zacX} + {kresleni.zacY * -1}i";
        }
        #endregion

        #region kresleni 
        /*
        private Bitmap kresli(int vyz, int sir)
         {

              hezkebarvy.Add(Color.FromArgb(nc.Next(256), nc.Next(256), nc.Next(256)));

             Bitmap bm = new Bitmap(sir, vyz);

             for (int w = 0; w < sir; w++)
             {
                 for (int h = 0; h < vyz; h++)
                 {
                     //if (((Bitmap)pbkresleni.Image).GetPixel(w, h) != Color.FromArgb(popredi.R, popredi.G, popredi.B) && !zoomojem && !rbTmaveni.Checked && !rbSvetleni.Checked && !rbJednBar.Checked)
                     //{
                     //    bm.SetPixel(w, h, ((Bitmap)pbkresleni.Image).GetPixel(w, h));
                     //    continue;

                     //}
                     //if (((Bitmap)pbkresleni.Image).GetPixel(w, h) == Color.FromArgb(popredi.R, popredi.G, popredi.B) && barvujemPozadi)
                     //{
                     //    bm.SetPixel(w, h, ((Bitmap)pbkresleni.Image).GetPixel(w, h));
                     //    continue;
                     //}
                     double a = 0;
                         double b = 0;

                         double real = pomoc.Map(0, sir, w, zacX, konX);
                         double ima = pomoc.Map(0, vyz, h, zacY, konY);

                     if (chJuliasSet.Checked)
                     {
                          a = pomoc.Map(0, sir, w, zacX, konX);
                          b = pomoc.Map(0, vyz, h, zacY, konY);

                          real = (double)nudReal.Value;
                          ima = (double)nudIma.Value;
                     }


                     komp z = new komp(a, b);
                     int coun = 0;
                     bool jev = false;

                        do
                        {
                         komp c = new komp(real, ima);
                         coun++;
                         z.mocina(naKolikat);
                         z.scitani(c);

                             if (z.delka() >= 2)
                             {
                             jev = true;
                             break;
                             }
                         } while (coun < counter);

                     bm.SetPixel(w, h, Barvy(coun,jev));
                 }

             }
             zoomojem = false;
             return bm;
         }

         private Color Barvy(int coun, bool jev) {
             Color bar = Color.FromArgb(0, 0, 0);
             #region normalni
             if (rbNorm.Checked)
             {
                 bar = hezkebarvy[coun];
             }
             #endregion
             #region jedna barva
 else if (rbJednBar.Checked)
             {
                 int r = (int)pomoc.Map(0, counter, coun, pozadi.R, JB.R);
                 int g = (int)pomoc.Map(0, counter, coun, pozadi.G, JB.G);
                 int b = (int)pomoc.Map(0, counter, coun, pozadi.B, JB.B);
                 bar = Color.FromArgb(r,g,b);
             }
             #endregion
             #region tmaveni
  else if (rbTmaveni.Checked)
             {
                 bar = Color.FromArgb((int)pomoc.Map(0, counter, coun, 0, pozadi.R), (int)pomoc.Map(0, counter, coun, 0, pozadi.G), (int)pomoc.Map(0, counter, coun, 0, pozadi.B));

             }
             #endregion
             #region svetleni
  else if (rbSvetleni.Checked)
             {

                     bar = Color.FromArgb((int)pomoc.Map(0, counter, coun, 255, pozadi.R), (int)pomoc.Map(0, counter, coun, 255, pozadi.G), (int)pomoc.Map(0, counter, coun, 255, pozadi.B));

             }
             #endregion
             #region tmavejsi
  else if (rbTmavejsi.Checked)
             {
                 double i = coun / 15;
                 int a = (int)Math.Floor(i);
                 int b = coun - (15 * a);
                 int pokus = 10;
                 if ((coun - (coun % 15)) % 10 == 0)
                 {

                     bar = Color.FromArgb((int)pomoc.Map(0, 15, b, pozadi.R, pozadi.R/pokus), (int)(pomoc.Map(0, 15, b, pozadi.G , pozadi.G / pokus)), (int)pomoc.Map(0, 15, b, pozadi.B , pozadi.B / pokus));

                 }
                 else
                 {
                     bar = Color.FromArgb((int)pomoc.Map(0, 15, b,  pozadi.R / pokus, pozadi.R ), (int)(pomoc.Map(0, 15, b,  pozadi.G / pokus, pozadi.G)), (int)pomoc.Map(0, 15, b,  pozadi.B/pokus, pozadi.B));

                 }
             }
             #endregion
             #region stivovani
 else if (rbStinovani.Checked)
             {
                 int mezi = coun % 15;
                 int jakaBarva = (coun - mezi) / 15;
                 Color zacatek;
                 if (jakaBarva == 0)
                 {
                     zacatek = Color.FromArgb(0, 0, 255);
                 }
                 else
                 {
                     zacatek = hezkebarvy[jakaBarva - 1];
                 }

                 Color konec = hezkebarvy[jakaBarva];

                 int r = (int)pomoc.Map(0, 15, mezi, zacatek.R, konec.R); 
                 int g = (int)pomoc.Map(0, 15, mezi, zacatek.G, konec.G);
                 int b = (int)pomoc.Map(0, 15, mezi, zacatek.B, konec.B);

                 bar = Color.FromArgb(r, g, b);
             }
             #endregion
             #region negativ
  else if (rbNegativ.Checked)
             {
                 double i = coun / 15;
                 int a = (int)Math.Floor(i);
                 int b = coun - (15 * a);
                 if ((coun - (coun % 15)) % 10 == 0)
                 {

                     bar = Color.FromArgb((int)pomoc.Map(0, 15, b, pozadi.R, 255 - pozadi.R), (int)(pomoc.Map(0, 15, b, pozadi.G, 255 - pozadi.G)), (int)pomoc.Map(0, 15, b, pozadi.B, 255 - pozadi.B));

                 }
                 else
                 {
                     bar = Color.FromArgb((int)pomoc.Map(0, 15, b, 255 - pozadi.R, pozadi.R), (int)(pomoc.Map(0, 15, b, 255 - pozadi.G, pozadi.G)), (int)pomoc.Map(0, 15, b, 255 - pozadi.B, pozadi.B));

                 }

             }
             #endregion
             #region profesional
             else
             {

                 Color zacatek;
                 Color konec;

                 int mezi = coun % PocetKroku;
                 int jakaBarvaM = (coun - mezi) / PocetKroku;
                 int jakaBarva = jakaBarvaM % 8;

                 zacatek = barvyProfi[jakaBarva];

                 konec = barvyProfi[(jakaBarva == 7)?(0):(jakaBarva + 1)];


                 int r = (int)pomoc.Map(0, PocetKroku, mezi, zacatek.R, konec.R);
                   int g = (int)pomoc.Map(0, PocetKroku, mezi, zacatek.G, konec.G);
                   int b = (int)pomoc.Map(0, PocetKroku, mezi, zacatek.B, konec.B);
                 bar = Color.FromArgb(r, g, b);

             }
             #endregion


             #region mocnina
             if (!jev)
             {
                 if (rbCerneP.Checked)
                 {
                     bar = Color.FromArgb(0, 0, 0);
                 }
                 else if (rbVlastniM.Checked)
                 {
                     bar = popredi;
                 }
                 else
                 {
                     bar = Color.FromArgb(255, 255, 255);
                 }
                 #endregion
             }
             return bar;
         }*/
#endregion

        private void rbCerna_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender).Name.Contains("CerneP"))                             
                    kresleni.popredi = Color.Black;         
                else                
                    kresleni.popredi = Color.White;
                

                panPoprediM.Visible = false;
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
            }
            
        }

        bool dol = false;
        int aktX, aktY;
        private void pankresleni_MouseMove(object sender, MouseEventArgs e)
        {
            aktX = e.X;
            aktY = e.Y;
            if (dol)
            {
                pbkresleni.Refresh();
            }
           
            

            lblAktP.Text = $"{pomoc.Map(0, pbkresleni.Width, e.X, kresleni.zacX, kresleni.konX)} + {pomoc.Map(0, pbkresleni.Height, e.Y, kresleni.konY, kresleni.zacY)}i";
        }

        #region priblizovani
        int X1, X2, Y1, Y2;
        
        private void Odzoom(object sender, EventArgs e)
        {
            if (PzacY.Count != 0)
            {
                kresleni.zacX = PzacX.Pop();
                kresleni.konX = PkonX.Pop();
                kresleni.zacY = PzacY.Pop();
                kresleni.konY = PkonY.Pop();
                kresleni.zoomojem = true;
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
                lblHR.Text = $"{kresleni.zacX} + {kresleni.zacY * -1}i";
            }
            
        }
        
        private void mysdlo(object sender, MouseEventArgs e)
        {
            dol = true;
            if (e.Button == MouseButtons.Left)
            {
                X1 = e.X;
                Y1 = e.Y;
            }
            else if (e.Button == MouseButtons.Middle && !chJuliasSet.Checked)
            {


                kresleni.ImaJS = pomoc.Map(0, pbkresleni.Width, e.X, kresleni.zacX, kresleni.konX);
                kresleni.RealJS = pomoc.Map(0, pbkresleni.Height, e.Y, kresleni.konY, kresleni.zacY);
                kresleni.zoomojem = true;
                nerestaruj = true;
                chJuliasSet.Checked = true;
                
            }
            
        }
        
        private void mysnah(object sender, MouseEventArgs e)
        {
            dol = false;
            if (!nerestaruj && e.Button == MouseButtons.Left)
            {
                X2 = e.X;
                Y2 =  e.Y;
                if (X1 > X2) pomoc.Prohod(ref X1, ref X2);
                if (Y1 > Y2) pomoc.Prohod(ref Y1, ref Y2);

                int delka = X2 - X1;
                Y2 = Y1 + delka;

                PzacX.Push(kresleni.zacX);
                PkonX.Push(kresleni.konX);
                PzacY.Push(kresleni.zacY);
                PkonY.Push(kresleni.konY);

                kresleni.zacX = pomoc.Map(0, pbkresleni.Width, X1, PzacX.Peek(), PkonX.Peek());
                kresleni.konX = pomoc.Map(0, pbkresleni.Width, X2, PzacX.Peek(), PkonX.Peek());
                kresleni.zacY = pomoc.Map(0, pbkresleni.Width, Y1, PzacY.Peek(), PkonY.Peek());
                kresleni.konY = pomoc.Map(0, pbkresleni.Width, Y2, PzacY.Peek(), PkonY.Peek());
                kresleni.zoomojem = true;
                lblHR.Text = $"{kresleni.zacX} + {kresleni.konY * -1}i";
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);

                pbkresleni.Refresh();
            }
            //else if (e.Button == MouseButtons.Right)
            //{
            //    BodyProg.Add(e.Location);
            //    komp z = new komp(pomoc.Map(0, pbkresleni.Width, e.X, kresleni.zacX, kresleni.konX), pomoc.Map(0, pbkresleni.Height, e.Y, kresleni.zacY, kresleni.konY));
               
            //    double real = 0;
            //    double ima = 0;

            //    if (chJuliasSet.Checked)
            //    {
            //        real = pomoc.Map(0, pbkresleni.Width, e.X, kresleni.zacX, kresleni.konX);
            //        ima = pomoc.Map(0, pbkresleni.Height, e.Y, kresleni.zacY, kresleni.konY);
            //    }

            //    int coun = 0;
            //    chciProgress = true;
            //    do
            //    {
            //        komp c = new komp(real, ima);
            //        coun++;
            //        z = z.mocina(kresleni.naKolikat);
            //        z.scitani(c);
            //        if (z.delka() >= 2)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            BodyProg.Add(new Point(Convert.ToInt32(Math.Round(pomoc.Map(kresleni.zacX, kresleni.konX, z.a, pbkresleni.Width, 0))), Convert.ToInt32(Math.Round(pomoc.Map(kresleni.zacY, kresleni.konY, z.b, pbkresleni.Height, 0)))));

            //        }
            //    } while (coun < kresleni.counter);

            //    pbkresleni.Refresh();
            //    chciProgress = false;
            //}
            else
            {
                nerestaruj = false;
            }
        }
        
        #endregion
        
        private void colorDrb(object sender, EventArgs e)
        {
          /*  if (((Control)sender).Name == rbNorm.Name && rbNorm.Checked)
            {
                kresleni.zoomojem = true;
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
                return;
            }*/

            if (((RadioButton)sender).Checked)
            {
                ColorDialog cd = new ColorDialog() { Color = panPoprediM.BackColor};
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    kresleni.popredi = cd.Color;
                    panPoprediM.BackColor = cd.Color;
                    panPoprediM.Visible = true;
                    pbkresleni.Image = kresleni.kresli(vyzka, sirka);
                }
                else
                   rbCerneP.Checked = true;
                
            }
            
        }

        private void butLenost_Click(object sender, EventArgs e)
        {
            kresleni.counter += 25;
            for (int i = 0; i < 25; i++)
            {
                kresleni.hezkebarvy.Add(Color.FromArgb(nc.Next(256), nc.Next(256), nc.Next(256)));
            }
            pbkresleni.Image = kresleni.kresli(vyzka, sirka);
            
        }

        private void butVybrBar_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog() { Color = panBarva.BackColor };
            if (cd.ShowDialog() == DialogResult.OK)
            {
                kresleni.pozadi = cd.Color;
                panBarva.BackColor = kresleni.pozadi;
                if (!rbNorm.Checked || !rbStinovani.Checked)
                {
                    kresleni.zoomojem = true;
                    pbkresleni.Image = kresleni.kresli(vyzka, sirka);
                }                
            }
        }
        
        private void vyberMod(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender).Name == rbJednBar.Name)
                {
                    butZmenaBarvyJB.Visible = panJB.Visible = true;
                }
                else
                {
                    butZmenaBarvyJB.Visible = panJB.Visible = false;
                }

                #region hnusne boolvec
                RadioButton sen = (RadioButton)sender;
                if (sen.Name.Contains("Norm"))
                {
                    kresleni.typBarvy = 0;
                }
                else if (sen.Name.Contains("JednBar"))
                {
                    kresleni.typBarvy = 1;
                }
                else if (sen.Name.Contains("Tmaveni"))
                {
                    kresleni.typBarvy = 2;
                }
                else if (sen.Name.Contains("Svetleni"))
                {
                    kresleni.typBarvy = 3;
                }
                else if (sen.Name.Contains("Tmavejsi"))
                {
                    kresleni.typBarvy = 4;
                }
                else if (sen.Name.Contains("Stinovani"))
                {
                    kresleni.typBarvy = 5;
                }
                else if (sen.Name.Contains("Negativ"))
                {
                    kresleni.typBarvy = 6;
                }
                else
                {
                    int typBarvPred = kresleni.typBarvy;
                    kresleni.typBarvy = 7;
                    profiDialog pd = new profiDialog(kresleni.PocetKroku, kresleni.barvyProfi);
                    pd.ShowDialog();
                    if (pd.DialogResult == DialogResult.OK)
                    {
                        kresleni.barvyProfi = pd.Barvy;
                        kresleni.PocetKroku = pd.pocetKrok;
                    }
                    else
                    {
                        kresleni.typBarvy = typBarvPred; 
                        switch (typBarvPred)
                        {
                            case 0:
                                rbNorm.Checked = true;
                                break;
                            case 1:
                                rbJednBar.Checked = true;
                                break;
                            case 2:
                                rbTmaveni.Checked = true;
                                break;
                            case 3:
                                rbSvetleni.Checked = true;
                                break;
                            case 4:
                                rbTmavejsi.Checked = true;
                                break;
                            case 5:
                                rbStinovani.Checked = true;
                                break;
                            case 6:
                                rbNegativ.Checked = true;
                                break;
                        }
                        return;
                    }
                }
                #endregion

                /* barvujemPozadi = true;*/
                kresleni.zoomojem = true;
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
            }     
        }

        #region menu
        private void vypnoutAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PD2XgQOyCCk");
        }
        #region ukladani
        private void uložitObrázekToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "BMP|*.bmp|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                ResoDialog rd = new ResoDialog();
                if (rd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap uloz = kresleni.kresli(rd.Res, rd.Res);
                    uloz.Save(sv.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    MessageBox.Show("Saving picture was successful", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }

        }
        #endregion

        private void oAutoroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem tohoto díla je David Ployer, student střední smíchovské průmyslové školy.", "O autorovi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        #region tmavý/světlý režim
        public static bool tmavý = true;
        private void tmavýRežimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hodiny.Enabled = true;
        }

        private void hodiny_Tick(object sender, EventArgs e)
        {
            if (tmavý)
                {
                if (BackColor.R == 5)
                {
                    hodiny.Enabled = false;
                    tmavý = false;
                    return;
                }
                tabMnozna.BackColor = tabMocnina.BackColor = tabPozadi.BackColor = butOdzoom.BackColor = butVybrBar.BackColor =butZmackni.BackColor =butReset.BackColor = butLenost.BackColor = BackColor = Color.FromArgb(BackColor.R - 5, BackColor.G - 5, BackColor.B - 5);               
                ForeColor = Color.FromArgb(ForeColor.R + 5, ForeColor.G + 5, ForeColor.B + 5);
                foreach (Control item in tabPozadi.Controls)
                {
                    item.ForeColor = ForeColor;
                }
                foreach (Control item in tabMnozna.Controls)
                {
                    item.ForeColor = ForeColor;
                }
                
                nudZmenaVelikosti.ForeColor = Color.Black;
            }
            else
            {

                if (BackColor.R == 255)
                {
                    hodiny.Enabled = false;
                    tmavý = true;
                    return;
                }
                tabMnozna.BackColor = tabMocnina.BackColor = tabPozadi.BackColor = butVybrBar.BackColor = butOdzoom.BackColor = butZmackni.BackColor = butReset.BackColor = butLenost.BackColor = BackColor = Color.FromArgb(BackColor.R + 5, BackColor.G + 5, BackColor.B + 5);

                ForeColor = Color.FromArgb(ForeColor.R - 5, ForeColor.G - 5, ForeColor.B - 5);
                foreach (Control item in tabPozadi.Controls)
                {
                    item.ForeColor = ForeColor;
                }
                foreach (Control item in tabMnozna.Controls)
                {
                    item.ForeColor = ForeColor;
                }
                nudZmenaVelikosti.ForeColor = Color.Black;

            }

        }
        #endregion
        
        
        private void poděkováníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Tímto bych rád poděkoval všem, kteří se podíleli na tvorbě tohoto projektu. Jmenovitě bych ale rád zdůraznil několik jmen:

Olga Kaiferová - Mé učitelce na PVA, která mi vždy ochotně poradila s každým mým poblémem.

Pierre Fatou - Objeviteli Mandelbrotovi množiny, za to, že mi dal téma na mou závěrečnou práci.

Benoît Mandelbrot - Matematikovi, který zpopularizoval fraktály a jako první Mandelbrotovu množinu nechal vykteslit počítačem.", "Poděkování", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }

        private void wikipediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cs.wikipedia.org/wiki/Mandelbrotova_mno%C5%BEina#Historie");

        }
        #endregion

        #region napady na JM
        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = -0.4;
            kresleni.ImaJS = 0.6;
        }

        private void iToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = 0.285;
            kresleni.ImaJS = 0;
        }
        
        private void iToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = 0.285;
            kresleni.ImaJS = 0.01;
        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = -0.7017;
            kresleni.ImaJS = -0.3842;
        }
        

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = -0.835;
            kresleni.ImaJS = -0.2321;
        }
        

        private void iToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = -0.8;
            kresleni.ImaJS = 0.156;
        }
       

        private void iToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = -0.7269;
            kresleni.ImaJS = 0.1889;
        }

        

        private void iToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            kresleni.RealJS = 0;
            kresleni.ImaJS = -0.8;
        }

        #endregion

        private void butZmenaBarvyJB_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog() {Color = panJB.BackColor};
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                kresleni.JB = panJB.BackColor = cd.Color;
                //counter--;
                kresleni.zoomojem = true;

                // button1_Click(sender, e);
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
                
            }
        }
        
        #region kravesove zkratky
        private void MandelbrotSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.K)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.Z)) 
            {
                Odzoom(new object(), new EventArgs());
            }
            else if (e.KeyData == Keys.J)
            {
                kresleni.counter--;
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
            }
        }
        #endregion

        #region kresleni ctverce
        private void pbkresleni_Paint(object sender, PaintEventArgs e)
        {
            //if (chciProgress)
            //{
            //    Pen pero = new Pen(Color.Red, 5);
            //    foreach (Point item in BodyProg)
            //    {
            //        e.Graphics.DrawEllipse(pero, item.X, item.Y, 5, 5);
            //    }
            //    e.Graphics.DrawLines(pero, BodyProg.ToArray());
            //    BodyProg.Clear();
            //}



            if (dol)
            {
                Pen pero = new Pen(Color.Red, 5);
            Graphics gr = e.Graphics;
            int xx1, xx2, yy1, yy2;

            if (X1 < aktX)
            {
                xx1 = X1;
                xx2 = aktX;
            }
            else
            {
                xx1 = aktX;
                xx2 = X1;
            }


            if (Y1 < aktY)
            {
                yy1 = Y1;
                yy2 = aktY;
            }
            else
            {
                yy1 = aktY;
                yy2 = Y1;
            }

            
                gr.DrawRectangle(pero, xx1,yy1,xx2-xx1, xx2 - xx1);
            }
            
           

        }
        #endregion

        private void ZmenaPoctuKroku(object sender, EventArgs e)
        {
            kresleni.PocetKroku = (int)((NumericUpDown)sender).Value;
            if (rbProfi.Checked) pbkresleni.Image = kresleni.kresli(vyzka, sirka);
        }

        private void rbVlastMoc_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                MocninaDialog md = new MocninaDialog(kresleni.naKolikat,komp.kompMoc,komp.chcikompl);
                md.ShowDialog();
                if (md.DialogResult == DialogResult.OK)
                {
                    kresleni.naKolikat = md.Real;
                    komp.kompMoc = md.KomplexMoc;
                    if (md.JeReal)
                    {
                        komp.chcikompl = false;
                    }
                    else
                    {
                        komp.chcikompl = true;
                    }
                    pbkresleni.Image = kresleni.kresli(vyzka, sirka);
                }
            }
        }
        

        private void MandelbrotSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chciZaverecnyD)
            {
                DialogResult dr = MessageBox.Show("Do you want to save your position?", "Closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    UlozeniPozice(sender, e);
                    return;
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
                else
                {
                    e.Cancel = true;
                }
            }
           
        }

        private void butZmenJS_Click(object sender, EventArgs e)
        {
            JuliaSetDialog jsd = new JuliaSetDialog();
            jsd.ShowDialog();

            pbkresleni.Image = kresleni.kresli(vyzka, sirka);
        }

        private void nudZmenaVelikosti_ValueChanged(object sender, EventArgs e)
        {
            vyzka = sirka = (int)nudZmenaVelikosti.Value;

            Width = 1013 - (800 - (int)nudZmenaVelikosti.Value);
            panelPosuv.Left = 814 - (800 - (int)nudZmenaVelikosti.Value);

            pbkresleni.Size = new Size(sirka, vyzka);


            if (nudZmenaVelikosti.Value >= 530)
            {
                this.Height = 888 - (800 - (int)nudZmenaVelikosti.Value);

            }
            else
            {
                Height = 616;
            }
            if (!zapinam)
            {
                kresleni.hezkebarvy.Add(Color.FromArgb(nc.Next(256), nc.Next(256), nc.Next(256)));
                pbkresleni.Image = kresleni.kresli(vyzka, sirka);
            }
            else
            {
                zapinam = false;

                butReset_Click(sender, e);
            }
           
        }
        
        private void naKolik(object sender, EventArgs e)
        {
            Control sen = (Control)sender;
            if (sen.Name == rbNa2.Name)
            {
           kresleni.naKolikat = 2;
            }
            else if (sen.Name == rbNa3.Name)
            {
                kresleni.naKolikat = 3;
            }
            else if (sen.Name == rbNa4.Name)
            {
                kresleni.naKolikat = 4;
            }
            else if (sen.Name == rbNa5.Name)
            {
                kresleni.naKolikat = 5;
            }
            else if (sen.Name == rbNa6.Name)
            {
                kresleni.naKolikat = 6;
            }


            butReset_Click(sender, e);
            
        }

        private void chJuliasSet_CheckedChanged(object sender, EventArgs e)
        {
            kresleni.JuliasSet = !kresleni.JuliasSet;

            pbkresleni.Image = kresleni.kresli(vyzka, sirka);
          
            
        }

        private void UlozeniPozice(object sender, EventArgs e)
        {
            char Poz = ((rbNorm.Checked) ? 'a' : (rbJednBar.Checked) ? 'b' : ((rbTmaveni.Checked) ? 'c' : ((rbSvetleni.Checked) ? 'd' : ((rbTmavejsi.Checked) ? 'e' : ((rbStinovani.Checked) ? 'f' : ((rbNegativ.Checked) ? 'g' : (rbProfi.Checked) ? 'h' : 'i'))))));
                                                                                                                                                             


            ukladani.Ulozeni(kresleni.zacX, kresleni.konX, kresleni.zacY, kresleni.konY, kresleni.counter, kresleni.naKolikat, Poz);
        }

        private void NacistPozici(object sender, EventArgs e)
        {
            ukladani.nacteni();
            lblHR.Text = $"{kresleni.zacX} + {kresleni.zacY * -1}";

            #region nakolik

            if (kresleni.naKolikat == 2)
            {
                rbNa2.Checked = true;
            }
            else if (kresleni.naKolikat == 3)
            {
                rbNa3.Checked = true;
            }
            else if (kresleni.naKolikat == 4)
            {
                rbNa4.Checked = true;
            }
            else if (kresleni.naKolikat == 5)
            {
                rbNa5.Checked = true;
            }
            else if (kresleni.naKolikat == 6)
            {
                rbNa6.Checked = true;
            }
            #endregion

            #region barvy
            panBarva.BackColor = kresleni.pozadi;
            panJB.BackColor = kresleni.JB;
            panPoprediM.BackColor = kresleni.popredi;

            if (kresleni.popredi == Color.FromArgb(0,0,0))
                rbCerneP.Checked = true;
            else if (kresleni.popredi == Color.FromArgb(255, 255, 255))
                rbBileP.Checked = true;
            else
                rbVlastniM.Checked = true;
            #endregion

            #region typ okolí
            butZmenaBarvyJB.Visible = false;
            panJB.Visible = false;
            switch (kresleni.typBarvy)
            {
                case 0:
                    rbNorm.Checked = true;
                    break;
                case 1:
                    butZmenaBarvyJB.Visible = true;
                    panJB.Visible = true;
                    rbJednBar.Checked = true;
                    break;
                case 2:
                    rbTmaveni.Checked = true;
                    break;
                case 3:
                    rbSvetleni.Checked = true;
                    break;
                case 4:
                    rbTmavejsi.Checked = true;
                    break;
                case 5:
                    rbStinovani.Checked = true;
                    break;
                case 6:
                    rbNegativ.Checked = true;
                    break;
                case 7:
                    rbProfi.Checked = true;
                    break;
            }

            #endregion

            pbkresleni.Image = kresleni.kresli(vyzka, sirka);
        }
    }
}
