using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Найти расстояние между первым и последним вхождением максимального значения в массиве.

namespace ConsoleTask2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 10, 20, 30, 50, 500, 7, 9, 50 };
            int max = mas[0], maxFirstIndex = 0, maxLastIndex = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (max < mas[i + 1])
                {
                    max = mas[i + 1];
                    maxFirstIndex = i + 1;
                }
                if (max == mas[i + 1])
                {
                    maxLastIndex = i + 1;
                }
            }
            Console.WriteLine(maxLastIndex - maxFirstIndex);

            Console.ReadKey();
        }
    }
}

