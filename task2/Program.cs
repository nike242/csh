using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        // Назаров
        //  а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        //     Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        //  б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
        static void Main(string[] args)
        {
            EnterNumbers();
        }

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
                int.TryParse(Console.ReadLine(), out int s);

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

    }
}
