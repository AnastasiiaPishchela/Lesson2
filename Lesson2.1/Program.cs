using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//• Вычислить среднее арифметическое значений в диапазоне n – m включительно.

namespace ConsoleTask2
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = 1, m = 8;
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                sum += i;
            }
            double ave = (double)sum / (m - n + 1);

            Console.Write(ave);
            Console.ReadKey();
        }

    }
}
