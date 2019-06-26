using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//• Написать код определения суммы четных чисел в диапазоне целых значений n1 – n2, используя условные операторы if и операторы повторения.

namespace ConsoleApp2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int s = 8;
            for (int i = 4; i <= s; i += 1)
            {
                if (i % 2 == 0)
                    res += i;
            }
            Console.Write(res);
            Console.ReadKey();
        }
    }
}
