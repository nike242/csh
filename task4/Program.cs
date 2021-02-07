using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        // Назаров
        /* 
           Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
           На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
           Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
           С помощью цикла do while ограничить ввод пароля тремя попытками. 
        */

        static bool CheckLogin(string user, string pass)
        {
            if (user == "root" & pass == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int count = 0;
            int count_max = 3;
            Console.WriteLine("Введите логин: ");
            string user = Console.ReadLine();
            do
            {
                Console.WriteLine("Введите пароль: ");
                string pass = Console.ReadLine();
                count++;
                if (CheckLogin(user, pass))
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные.\n");
                    if (count == count_max)
                        Console.WriteLine("Вы исчерпали попытки ввода.");
                }

            }
            while (count < count_max);
        }
    }
}
