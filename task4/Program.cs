using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine($"a = {a}, b = {b}");

            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"С использованием трёх переменных: a = {a}, b = {b}");

            Console.WriteLine(" --------- ");
            a = 10;
            b = 5;

            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"А теперь с использованием двух переменных: a = {a}, b = {b}");

        }
    }
}
