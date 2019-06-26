using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание 2
//• Поменять местами значения первого и последнего элементов массива, второго и предпоследнего и тд. Пример: (10, 5, 3, 4) => (4, 3, 5, 10).

namespace ConsoleTask2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = { 10, 5, 3, 4, 7 };
            int swap;
            for (int i = 0; i < mas1.Length / 2; i++)
            {
                swap = mas1[i];
                mas1[i] = mas1[mas1.Length - i - 1];
                mas1[mas1.Length - i - 1] = swap;
            }
            int count = 0;
            while (count < mas1.Length)
            {
                Console.Write(mas1[count] + " ");
                count++;
            }
            Console.ReadKey();
        }
    }
}
