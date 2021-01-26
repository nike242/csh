using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task1
{
    
    class Program
    {
        static string Question(string a)
        {
            Console.Write(a);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string name = Question("Введите ваше имя: ");
            string lastname = Question("Введите вашу фамилию: ");
            string age = Question("Введите ваш возраст: ");
            string height = Question("Введите ваш рост: ");
            string weight = Question("Введите ваш вес: ");

            Console.WriteLine("Склеивание. Вы " + name + " " + lastname + ", ваш вес " + weight + ", рост " + height + ", и вам " + age + " лет.");
            Console.WriteLine("Форматирование. Вы {0} {1}, вам {2} лет, ваш вес {3} и рост {4}", name, lastname, age, weight, height);
            Console.WriteLine($"Вы {name} {lastname}, вам {age} лет, ваш вес {weight}, рост {height}");

            Console.Read();
        }
    }
}
