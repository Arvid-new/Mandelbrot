using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace mandelbrot_set
{
    public class komp
    {
        public static Complex kompMoc;
        public static bool chcikompl = false; 

        public double a;
        public double b;
        public komp(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public komp mocina(double naKol)
        {
            
                double f = a;
                double g = b;
                double moc;
            switch (naKol)
            {
                case 2 :
                    moc = (f * f) - (g * g);
                    g = 2 * f * g;
                    f = moc;
                    break;
                case 3:
                    moc = (f * f * f) - 3 * f * g * g;
                    g = (3 * f * f * g) - (g * g * g);
                    f = moc;
                    break;
                case 4:
                    moc = (f * f * f * f) - (6 * f * f * g * g) + (g * g * g * g);
                    g = (4 * f * f * f * g) - (4 * f * g * g * g);
                    f = moc;
                    break;
                case 5:
                    moc = (f * f * f * f * f) - (10 * f * f * f * g * g) + (5 * f * g * g * g * g);
                    g = (5 * f * f * f * f * g) - (10 * f * f * g * g * g) + (g * g * g * g * g);
                    f = moc;
                    break;
                case 6:
                    moc = (f * f * f * f * f * f) - (15 * f * f * f * f * g * g) + (15 * f * f * g * g * g * g) - (g * g * g * g * g * g);
                    g = (6 * f * f * f * f * f * g) - (20 * f * f * f * g * g * g) + (6 * f * g * g * g * g * g);
                    f = moc;
                    break;
                default:
                    if (!chcikompl)
                    {
                        kompMoc = new Complex(naKol, 0); 
                    }
                    Complex c = new Complex(a, b);
                    c = Complex.Pow(c, kompMoc);
                    return new komp(c.Real, c.Imaginary);

        }
            return new komp(f, g);



    }

        public double delka()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void scitani(komp c)
        {
            a += c.a;
            b += c.b;
        }
    }
}
