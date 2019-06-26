using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Записать в массив-матрицу произвольного размера значение нуль в элементы по левую сторону главной диагонали, единицу – по правую. Пример:
//((2, 4, 3, 3)  =>  ((2, 1, 1, 1)
//(5, 7, 8, 5)       (0, 7, 1, 1)
//(2, 4, 3, 3)       (0, 0, 3, 1)
//(5, 7, 8, 5))      (0, 0, 0, 5))

namespace ConsoleTask2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 2, 4, 3, 3},
                              { 5, 7, 8, 5},
                              { 2, 4, 3, 3},
                              { 5, 7, 8, 5} };
            int lines = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i < j)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
