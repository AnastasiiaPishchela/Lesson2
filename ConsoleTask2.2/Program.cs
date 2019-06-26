using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать код определения суммы четных чисел в диапазоне целых значений 0 – n1, используя только операторы повторения (использование if запрещено).

namespace ConsoleTask2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            for (int i = 0; i <= 4; i += 2)
            {
                res += i;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }

}
