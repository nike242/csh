using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        // Назаров
        /*
          а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
          б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        */

        static string DataInput(string n)
        {
            Console.Write(n);
            string s = Console.ReadLine();
            return s;
        }

        static double Imt(string weight, string height)
        {
            double h = Convert.ToDouble(height) / 100;
            double w = Convert.ToDouble(weight);
            double result = w / (h * h);
            return result;
        }

        static void WeightMin(double weight, double height)
        {
            double result = weight - (18.5 * (height * height));
            Console.WriteLine("Вам нужно набрать {0:0.00} кг", result);
        }

        static void WeightMax(double weight, double height)
        {
            double result = weight - (24.98 * (height * height));
            Console.WriteLine("Вам нужно скинуть {0:0.00} кг", result);
        }

        static void Calc(double i, string weight, string height)
        {
            double h = Convert.ToDouble(height);
            double w = Convert.ToDouble(weight);
            h /= 100;

            if (i < 16)
            {
                Console.WriteLine("У вас ярковыраженный дефицит массы тела. ИМТ - {0:0.00}", i);
                WeightMin(w, h);
            }
            else if (i >= 16 && i < 18.5)
            {
                Console.WriteLine("Недостаточная масса тела. ИМТ - {0:0.00}", i);
                WeightMin(w, h);
            }
            else if (i >= 18.5 && i < 24.99)
            {
                Console.WriteLine("Идеальный вес! ИМТ - {0:0.00}", i);
            }
            else if (i >= 25 && i < 30)
            {
                Console.WriteLine("Избыточная масса тела. ИМТ - {0:0.00}", i);
                WeightMax(w, h);
            }
            else if (i >= 30 && i < 35)
            {
                Console.WriteLine("Ожирение первой степени. ИМТ - {0:0.00}", i);
                WeightMax(w, h);
            }
            else if (i >= 35 && i < 40)
            {
                Console.WriteLine("Ожирение второй степени. ИМТ - {0:0.00}", i);
                WeightMax(w, h);
            }
            else
            {
                Console.WriteLine("Ожирение третьей степени! Больше уже некуда... ИМТ - {0:0.00}", i);
                WeightMax(w, h);
            }
        }

        static void Main(string[] args)
        {
            string weight = DataInput("Введите ваш вес: ");
            string height = DataInput("Введите ваш рост: ");

            Calc(Imt(weight, height), weight, height);
        }
    }
}
