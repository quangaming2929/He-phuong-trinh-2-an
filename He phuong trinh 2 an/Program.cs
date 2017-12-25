using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_phuong_trinh_2_an
{
   
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            #region display
            Console.WriteLine("tinh he phuong trinh 2 an");
            Console.WriteLine("{ a x + b y = c");
            Console.WriteLine("{ a'x + b'y = c'");
            #endregion

            Console.Write("a=  ");
            a = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" {0}x + by = c", a);
            Console.WriteLine(" a'x + b'y = c'");
            Console.WriteLine("b= ");
            b = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" {0}x + {1}y = c" ,a,b);
            Console.WriteLine(" a'x + b'y = c'");
            Console.WriteLine("c= ");
            c = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("{0}x + {1}y = {2}", a, b, c);
            Console.WriteLine(" a'x + b'y = c'");
            Console.WriteLine("d= ");
            d = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" {0}x + {1}y = {2}", a, b, c);
            Console.WriteLine(" {0}x + b'y = c'",d);
            Console.WriteLine("e= ");
            e = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" {0}x + {1}y = {2}", a, b, c);
            Console.WriteLine(" {0}x + {1}y = c'",d,e);
            Console.WriteLine("f= ");
            f = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" {0}x + {1}y = {2}", a, b, c);
            Console.WriteLine(" {0}x + {1}y = {2}",d,e,f);
            HPT2an hpt = new HPT2an(a, b, c, d, e, f);
            if (!double.IsInfinity(hpt.getX()) && !double.IsNaN(hpt.getX()))
            {
                Console.WriteLine("\nResult:");
                Console.WriteLine("X = {0}", hpt.getX());
                Console.WriteLine("Y = {0}", hpt.getY());
            }
            if (double.IsInfinity(hpt.getX()))
            {
                Console.WriteLine("No Solution");
            }
            if (double.IsNaN(hpt.getX()))
            {
                Console.WriteLine("Infinity Solution");
            }
            Console.Read();
        }
    }
}
