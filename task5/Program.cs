using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static string Question(string a)
        {
            Console.Write(a);
            return Console.ReadLine();
        }

        static string Info(string name, string family, string city)
        {
            return $"{name} {family}, {city}";
        }
        static void Main(string[] args)
        {
            string name = Question("Введите ваше имя: ");
            string family = Question("Введите вашу фамилию: ");
            string city = Question("Введите ваш город проживания: ");

            Console.WriteLine(Info(name, family, city));

            double width = Console.WindowWidth;
            double padding = width / 2 + Info(name, family, city).Length / 2;
            Console.WriteLine("{0," + padding + "}", Info(name, family, city));
        }
    }
}
