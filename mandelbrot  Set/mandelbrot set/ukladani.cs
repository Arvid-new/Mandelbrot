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
using System.IO;

namespace mandelbrot_set
{
    class ukladani
    {
        private static Random nc = new Random();

        public static void Ulozeni(double zacX, double konX, double zacY, double konY, int counter, double naKolik, char poz) {

            string data = $@"{zacX}
{konX}
{zacY}
{konY}
{counter}
{naKolik}
";

            foreach (Color item in kresleni.hezkebarvy)
            {
                data += $@"{item.R}*{item.G}*{item.B}|";
            }
            data = data.TrimEnd('|');

            #region bar popredi poyadi JB
            data += $@"
{kresleni.pozadi.R}*{kresleni.pozadi.G}*{kresleni.pozadi.B}
{kresleni.popredi.R}*{kresleni.popredi.G}*{kresleni.popredi.B}
{kresleni.JB.R}*{kresleni.JB.G}*{kresleni.JB.B}
";
            #endregion

            #region typ popredi pozadi

            data += $@"{poz}
";

            #endregion

            #region uložení Profi barev
            foreach (Color item in kresleni.barvyProfi)
            {
                data += $@"{item.R}*{item.G}*{item.B}|";
            }
            data = data.TrimEnd('|');
            #endregion

            data += $@"
{kresleni.PocetKroku}
";
            #region ukladani souradnic priblizovani

            var MeziPole0 = MandelbrotSet.PzacX.Reverse<double>();

            foreach (double item in MeziPole0)
            {
                data += $"{item}*";
            }
            data = data.TrimEnd('*');
            data += @"
";


            var MeziPole1 = MandelbrotSet.PkonX.Reverse<double>();

            foreach (double item in MeziPole1)
            {
                data += $"{item}*";
            }
            data = data.TrimEnd('*');
            data += @"
";

            var MeziPole2 = MandelbrotSet.PzacY.Reverse<double>();
            foreach (double item in MeziPole2)
            {
                data += $"{item}*";
            }
            data = data.TrimEnd('*');
            data += @"
";

            var MeziPole3 = MandelbrotSet.PkonY.Reverse<double>();
            foreach (double item in MeziPole3)
            {
                data += $"{item}*";
            }
            data = data.TrimEnd('*');
            data += @"
";
            #endregion


            #region ulozeni dialog
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Soubor Mandelbrot|*.mbs";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(svf.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs,Encoding.Default);

                sw.WriteLine(data);

                sw.Close();
                fs.Close();
            }
            #endregion
        }

        public static void nacteni()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Soubor Mandelbrot|*.mbs";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string[] nacteno = File.ReadAllLines(opf.FileName);

                kresleni.zacX = Convert.ToDouble(nacteno[0]);
                kresleni.konX = Convert.ToDouble(nacteno[1]);
                kresleni.zacY = Convert.ToDouble(nacteno[2]);
                kresleni.konY = Convert.ToDouble(nacteno[3]);
                kresleni.counter = Convert.ToInt32(nacteno[4]);
                kresleni.naKolikat = Convert.ToInt32(nacteno[5]);


                kresleni.hezkebarvy.Clear();
                string[] HB = nacteno[6].Split('|');
                foreach (string item in HB)
                {
                    kresleni.hezkebarvy.Add(pomoc.PrevedeniBarvy(item));
                }


                kresleni.pozadi = pomoc.PrevedeniBarvy(nacteno[7]);
                kresleni.popredi = pomoc.PrevedeniBarvy(nacteno[8]);
                kresleni.JB = pomoc.PrevedeniBarvy(nacteno[9]);

                #region zjistovani barveni

                switch (nacteno[10])
                {
                    case "a":
                        kresleni.typBarvy = 0;
                        break;
                    case "b":
                        kresleni.typBarvy = 1;
                        break;
                    case "c":
                        kresleni.typBarvy = 2;
                        break;
                    case "d":
                        kresleni.typBarvy = 3;
                        break;
                    case "e":
                        kresleni.typBarvy = 4;
                        break;
                    case "f":
                        kresleni.typBarvy = 5;
                        break;
                    case "g":
                        kresleni.typBarvy = 6;
                        break;
                    default:
                        kresleni.typBarvy = 7;
                        break;
                }
                #endregion


                string[] PB = nacteno[11].Split('|');
                List<Color> ProfiBarvy = new List<Color>();
                foreach (string item in PB)
                {
                    ProfiBarvy.Add(pomoc.PrevedeniBarvy(item));
                }
                kresleni.barvyProfi = ProfiBarvy.ToArray();

                kresleni.PocetKroku = Convert.ToInt16(nacteno[12]);

                #region nacitani pribliz souradnic 
                MandelbrotSet.PzacX.Clear();
                string[] zacx = nacteno[13].Split('*');
                foreach (string item in zacx)
                {
                    MandelbrotSet.PzacX.Push(Convert.ToDouble(item));
                }
               // MandelbrotSet.PzacX.Reverse();

                MandelbrotSet.PkonX.Clear();
                string[] konx = nacteno[14].Split('*');
                foreach (string item in konx)
                {
                    MandelbrotSet.PkonX.Push(Convert.ToDouble(item));
                }
                //MandelbrotSet.PkonX.Reverse();

                MandelbrotSet.PzacY.Clear();
                string[] zacY = nacteno[15].Split('*');
                foreach (string item in zacY)
                {
                    MandelbrotSet.PzacY.Push(Convert.ToDouble(item));
                }
               // MandelbrotSet.PzacY.Reverse();

                MandelbrotSet.PkonY.Clear();
                string[] konY = nacteno[16].Split('*');
                foreach (string item in konY)
                {
                    MandelbrotSet.PkonY.Push(Convert.ToDouble(item));
                }
              //  MandelbrotSet.PkonY.Reverse();
                #endregion


            }
        }
    }
}
