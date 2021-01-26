using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static double Road(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            double x1 = 5;
            double x2 = 10;
            double y1 = 6;
            double y2 = 12;

            Console.WriteLine($"{Road(x1, x2, y1, y2):0.00}");
            Console.Read();

        }
    }
}
