using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace mandelbrot_set
{
    class pomoc 
    {
        
        public pomoc() { } 
        public static double Map(double Od, double Do, double co, double min, double max) {
            double ret;
            ret = ((co - Od) / (Do - Od)) * (max - min) + min;
            return ret;            
        } 
        public static void Prohod <T>(ref T a, ref T b)
        {
            
            T sw = a;
            a = b;
            b = sw;
        }
        public static Color PrevedeniBarvy(string s) {
            string[] dil = s.Split('*');
            return Color.FromArgb(Convert.ToInt16(dil[0]), Convert.ToInt16(dil[1]), Convert.ToInt16(dil[2]));
        }
        
    }
}
