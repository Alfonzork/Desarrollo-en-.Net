using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.Test
{
    class Program
    {
        public static void ValidaRut(int rut)
        {
            int a,b,c,d,e,a1,b1,c1,d1,e1,f,f1,g,g1,h,yy,xx,zz;
            
            a = rut / 10000000;
            a1 = rut % 10000000;
            b = a1 / 1000000;
            b1 = a1 % 1000000;
            c = b1 / 100000;
            c1 = b1 % 100000;
            d = c1 / 10000;
            d1 = c1 % 10000;
            e = d1 / 1000;
            e1 = d1 % 1000;
            f = e1 / 100;
            f1 = e1 % 100;
            g = f1 / 10;
            g1 = f1 % 10;
            h = g1 / 1;

            yy = (h * 2) + (g * 3) + (f * 4) + (e * 5) + (d * 6)+ (c*7)+(b*2)+(a*3);
            xx = yy % 11;
            zz = 11 - xx;
            Console.WriteLine("  "+a+ b+ c+ d+ e+f+g+h+" digito verificador"+zz);

            

        }

        static void Main(string[] args)
        {
            Program.ValidaRut(15386552);
            Console.ReadKey();
        }
    }
}
