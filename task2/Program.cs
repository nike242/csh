using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    // Назаров. Написать метод подсчета количества цифр числа
    class Program
    {
        static int Count(int a)
        {
            return a.ToString().Length;
        }
        static void Main(string[] args)
        {
            int n = 45654682;
            Console.WriteLine(Count(n));
        }
    }
}
