using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    
    class Program
    {
        // Назаров. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static int SumNumbers(int n, int result)
        {
            if (n > 0 && (n % 2 != 0))
                return result += n;
            else
                return result;
        }

        static void EnterNumbers()
        {
            int result = 0;
            while (true)
            {

                Console.Write("Если число не 0 - программа будет складывать нечетные положительные числа, если 0 - программа останавливается. Введите число: ");
                int s = Convert.ToInt32(Console.ReadLine());
                if (s == 0)
                {
                    Console.WriteLine("Общая сумма нечетных чисел: " + result);
                    break;
                }
                else
                {
                    result = SumNumbers(s, result);
                    Console.WriteLine("Общая сумма нечетных чисел: " + result);
                }

            }
        }

        static void Main(string[] args)
        {
            EnterNumbers();
        }
    }
}
