using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба-");
            int x = Convert.ToInt32(Console.ReadLine());
            CalcKub(x, out double v, out double s);
            Console.WriteLine("Объём куба равен  {0} ",v);
            Console.WriteLine("Площадь поверхности куба равна {0} ",s);
            Console.ReadKey();

        }
        static void CalcKub (int x, out double v, out double s)
        {
            v = Math.Pow(x, 3);
            s = 6 * Math.Pow(x, 2);
            
        }


    }
}
