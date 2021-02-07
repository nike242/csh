using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        #region Задание 1
        // Назаров. Написать метод, возвращающий минимальное из трех чисел.
        #endregion

        static int Min(int a, int b, int c)
        {
            if (a <= b & a <= c)
                return a;
            else if (b <= a & b <= c)
                return b;
            else
                return c;
        }
        static void Main(string[] args)
        {
            int a = 15, b = 222, c = -60;
            Console.WriteLine(Min(a, b, c));
        }
    }
}
