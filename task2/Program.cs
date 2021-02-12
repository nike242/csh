using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    // Назаров
    //  а) Дописать класс для работы с одномерным массивом. 
    //  Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
    //  Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, 
    //  умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
    //  В Main продемонстрировать работу класса.
    class Program
    {
        
        static void Main(string[] args)
        {
            int size = 20;
            int[] Array = new int[size];
            Arrays array = new Arrays(1, 200, size, Array);

            array.Print(Array);

            array.Inverse(Array);
            array.Print(Array);

            array.Sum(Array);
            array.Multi(Array);

            Console.WriteLine(array.MaxCount);

        }
    }

    class Arrays
    {
        private int size;
        public Arrays(int startRandom, int endRandom, int size, int[] Array)
        {
            Random random = new Random();
            this.size = size;
            for (int i = 0; i < size; i++)
            {
                int d = random.Next(startRandom, endRandom);
                Array[i] = d;
            }
        }

        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public void Sum(int[] array)
        {
            int s = 0;
            foreach (int arr in array)
                s += arr;
            Console.WriteLine(s);
        }

        public void Multi(int[] array)
        {
            int s = 1;
            foreach (int arr in array)
                s *= arr;
            Console.WriteLine(s);
        }

        public void Inverse(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] *= -1;
        }

        public int MaxCount
        {
            get { return size; }
        }



    }
}
