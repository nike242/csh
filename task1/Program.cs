using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {

        // Назаров
        // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
        // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

        static void Main(string[] args)
        {
            Complex complexOne;
            complexOne.Re = 5;
            complexOne.Im = 10;

            Complex complexTwo;
            complexTwo.Re = 2;
            complexTwo.Im = 7;

            Complex newComplexNumber = complexOne.Plus(complexTwo);
            Console.WriteLine($"Сложение: {newComplexNumber.Re} + {newComplexNumber.Im}*i");

            newComplexNumber = complexOne.Multi(complexTwo);
            Console.WriteLine($"Умножение: {newComplexNumber.Re} + {newComplexNumber.Im}*i");

            newComplexNumber = complexOne.Subtruct(complexTwo);
            Console.WriteLine($"Вычитание: {newComplexNumber.Re} + {newComplexNumber.Im}*i");


            Console.WriteLine("\n\nТеперь тоже самое, только через класс ComplexClass");
            ComplexClass z1 = new ComplexClass(5, 10);
            ComplexClass z2 = new ComplexClass(2, 7);

            Console.WriteLine($"Сложение: {z1 + z2}");
            Console.WriteLine($"Умножение: {z1 * z2}");
            Console.WriteLine($"Вычитание: {z1 - z2}");

            Console.ReadKey();

        }

    }

    struct Complex
    {
        public double Im, Re;

        public Complex Plus(Complex complexX)
        {
            Complex complexY;
            complexY.Re = Re + complexX.Re;
            complexY.Im = Im + complexX.Im;

            return complexY;
        }

        public Complex Multi(Complex complexX)
        {
            Complex complexY;
            complexY.Re = Re * complexX.Re - Im * complexX.Im;
            complexY.Im = Re * complexX.Im + complexX.Re * Im;

            return complexY;
        }

        public Complex Subtruct (Complex complexX)
        {
            Complex complexY;
            complexY.Re = Re - complexX.Re;
            complexY.Im = Im - complexX.Im;

            return complexY;
        }
    }

    class ComplexClass
    {
        public double a, b;
        public ComplexClass(double re, double im)
        {
            a = re;
            b = im;
        }

        public override string ToString()
        {
            return $"{a} + {b}i";
        }

        public static ComplexClass operator +(ComplexClass c1, ComplexClass c2)
        {
            return new ComplexClass(
                re: c1.a + c2.a,
                im: c1.b + c2.b
                );
        }

        public static ComplexClass operator -(ComplexClass c1, ComplexClass c2)
        {
            return new ComplexClass(
                re: c1.a - c2.a,
                im: c1.b - c2.b
                );
        }

        public static ComplexClass operator *(ComplexClass c1, ComplexClass c2)
        {
            return new ComplexClass(
                re: c1.a * c2.a - c1.b * c2.b,
                im: c1.b * c2.a + c1.a * c2.b
                );
        }



    }
}
