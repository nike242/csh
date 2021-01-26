using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
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
            double weight = Convert.ToDouble(Question("Введите вес: "));
            double height = Convert.ToDouble(Question("Введите рост: ")) / 100;


            double imt = weight / (height * height);

            Console.WriteLine(imt);
            Console.Read();

        }
    }
}
