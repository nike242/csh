using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        // Назаров
        // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
        // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        static int Recurse(int a, int b)
        {
            Console.WriteLine(a);
            if (a == b) return b;
            else return Recurse(a + 1, b);
        }

        static int SumRecurse(int a, int b)
        {
            if (a > b) return 0;
            else return a + SumRecurse(a + 1, b);
        }
        static void Main(string[] args)
        {
            int a = 1, b = 30;
            Console.WriteLine(Recurse(a, b));
            Console.WriteLine(SumRecurse(a, b));
        }
    }
}
