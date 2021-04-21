using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fataliti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первую сторону");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите второую сторону");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите третью сторону");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a*a==(b*b+c*c)) || (b*b==(a*a+c*c)) || (c * c == (a * a + b * b)))
            {
                Console.WriteLine("Прямоугольный");
            }
            else
            {
                Console.WriteLine("Не прямоугольный");
            }
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь равна" + s);
            Console.ReadKey();

        }
    }
}
