using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_phuong_trinh_2_an
{
    class HPT2an
    {
        double a, b, c, d, e, f, x, y;
        public HPT2an(double aa, double bb, double cc, double dd, double ee, double ff)
        {
            a = aa;
            b = bb;
            c = cc;
            d = dd;
            e = ee;
            f = ff;
            Calcualtion();
        }
        private void Calcualtion()
        {
            y = (c * d - f * a) / (b * d - e * a);
            x = (c - b * y) / a;
        }
        public double getX()
        {
            return x + 1;
        }
        public double getY()
        {
            return y;
        }
        
    }
}
