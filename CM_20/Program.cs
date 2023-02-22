using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_20
{
    class Program
    {
        delegate double MyDelegate(double r);
        
        static void Main(string[] args)
        {
          Console.WriteLine("Введите радиус");
          double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Getline;
            myDelegate += Getsqw;
            myDelegate += GetV;
            myDelegate(r);
            Console.ReadKey();

        }
        static double Getline(double r)
        {
            double d = Math.PI*2*r;
            Console.WriteLine("Длина оружности {0:f2}", d);
            return d;
        }
        static double Getsqw(double r)
        {
            double s = Math.PI*r*r;
            Console.WriteLine("Площадь круга {0:f2}", s);
            return s;
        }
        static double GetV(double r)
        {
            double v = (4/3.0)*(Math.PI * r * r*r);
            Console.WriteLine("Объем шара {0:f2}", v);
            return v;
        }

    }
}
