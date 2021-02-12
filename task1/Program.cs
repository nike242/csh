using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    // Назаров
    // Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
    // Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
    // В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            int[] array = methods.RandomArray(-10000, 10000, 20);

            for (int с = 0; с < array.Length; с++)
                Console.Write(array[с] + " ");

            int count = 0;
                
            for (int b = 0; b < array.Length - 1; b++)
                if (array[b] % 3 == 0 || array[b + 1] % 3 == 0) count++;

            Console.WriteLine("\n");
            Console.WriteLine($"Количество пар: {count}");

        }
    }

    public class Methods
    {
        public int[] RandomArray(int a, int b, int elements)
        { 
            Random random = new Random();
            int[] result = new int[elements];

            for(int i = 0; i < elements; i++)
            {
                int d = random.Next(a, b);
                result[i] = d;
            }
            return result;
        }
    }
}
