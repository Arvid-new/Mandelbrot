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
    class kresleni
    {
        public kresleni() { }
        
        #region proměne
        public static List<Color> hezkebarvy = new List<Color>();

        public static Random nc = new Random();

        public static Double zacX = -2;
        public static Double konX = -2;
        public static Double zacY = -2;
        public static Double konY = -2;


        #region JS promene
        public static bool JuliasSet = false;
        public static double RealJS = 0;
        public static double ImaJS = 0;
        #endregion

        public static double naKolikat = 2;

        public static int counter = 0;

        public static bool zoomojem = false;
        
        public static int typBarvy = 0;

        #region barvy
        public static Color pozadi = Color.Blue;
        public static Color popredi = Color.Black;

        public static Color JB = Color.Aqua;

        public static Color[] barvyProfi = new Color[8] { Color.Blue, Color.Red, Color.Orange, Color.Green, Color.Lime, Color.Magenta, Color.Aqua, Color.PeachPuff};

        #endregion

        public static int PocetKroku = 15;

        public static int Limit = 2;
        #endregion
        
        public static Bitmap kresli(int vyz, int sir)
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

                    if (JuliasSet)
                    {
                        a = pomoc.Map(0, sir, w, zacX, konX);
                        b = pomoc.Map(0, vyz, h, zacY, konY);

                        real = RealJS;
                        ima = ImaJS;
                    }

                    komp z = new komp(a, b);
                    int coun = 0;
                    bool jev = false;

                    do
                    {
                        komp c = new komp(real, ima);
                        coun++;
                        z = z.mocina(kresleni.naKolikat);
                        z.scitani(c);
                        if(z.delka() >= Limit)
                        {
                            jev = true;
                            break;
                        }
                    } while (coun < counter);

                    bm.SetPixel(w, h, Barvy(coun, jev));
                }

            }
            zoomojem = false;
            return bm;
        }

        public static Color Barvy(int coun, bool jev)
        {
            Color bar = Color.FromArgb(0, 0, 0);
            #region normalni
            if (typBarvy == 0)
            {
               
                bar = hezkebarvy[coun];
            }
            #endregion
            #region jedna barva
            else if (typBarvy == 1)
            {
                int r = (int)pomoc.Map(0, counter, coun, pozadi.R, JB.R);
                int g = (int)pomoc.Map(0, counter, coun, pozadi.G, JB.G);
                int b = (int)pomoc.Map(0, counter, coun, pozadi.B, JB.B);
                bar = Color.FromArgb(r, g, b);
            }
            #endregion
            #region tmaveni
            else if (typBarvy == 2)
            {
                bar = Color.FromArgb((int)pomoc.Map(0, counter, coun, 0, pozadi.R), (int)pomoc.Map(0, counter, coun, 0, pozadi.G), (int)pomoc.Map(0, counter, coun, 0, pozadi.B));

            }
            #endregion
            #region svetleni
            else if (typBarvy == 3)
            {

                bar = Color.FromArgb((int)pomoc.Map(0, counter, coun, 255, pozadi.R), (int)pomoc.Map(0, counter, coun, 255, pozadi.G), (int)pomoc.Map(0, counter, coun, 255, pozadi.B));

            }
            #endregion
            #region tmavejsi
            else if (typBarvy == 4)
            {
                double i = coun / 15;
                int a = (int)Math.Floor(i);
                int b = coun - (15 * a);
                int pokus = 10;
                if ((coun - (coun % 15)) % 10 == 0)
                {

                    bar = Color.FromArgb((int)pomoc.Map(0, 15, b, pozadi.R, pozadi.R / pokus), (int)(pomoc.Map(0, 15, b, pozadi.G, pozadi.G / pokus)), (int)pomoc.Map(0, 15, b, pozadi.B, pozadi.B / pokus));

                }
                else
                {
                    bar = Color.FromArgb((int)pomoc.Map(0, 15, b, pozadi.R / pokus, pozadi.R), (int)(pomoc.Map(0, 15, b, pozadi.G / pokus, pozadi.G)), (int)pomoc.Map(0, 15, b, pozadi.B / pokus, pozadi.B));

                }
            }
            #endregion
            #region stivovani
            else if (typBarvy == 5)
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
            else if (typBarvy == 6)
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
            else if(typBarvy == 7)
            {

                Color zacatek;
                Color konec;

                int mezi = coun % PocetKroku;
                int jakaBarvaM = (coun - mezi) / PocetKroku;
                int jakaBarva = jakaBarvaM % barvyProfi.Length;

                zacatek = barvyProfi[jakaBarva];

                konec = barvyProfi[(jakaBarva == barvyProfi.Length - 1) ? (0) : (jakaBarva + 1)];


                int r = (int)pomoc.Map(0, PocetKroku, mezi, zacatek.R, konec.R);
                int g = (int)pomoc.Map(0, PocetKroku, mezi, zacatek.G, konec.G);
                int b = (int)pomoc.Map(0, PocetKroku, mezi, zacatek.B, konec.B);
                bar = Color.FromArgb(r, g, b);

            }
            #endregion


            #region mocnina
            if (!jev)
            {
                bar = popredi;
                #endregion

            }
            return bar;
        }
       
    
    }
}
