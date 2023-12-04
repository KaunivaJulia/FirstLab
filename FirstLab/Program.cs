using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1:");
            Console.Write("Введите размер массива: ");

            int size = int.Parse(Console.ReadLine());
            Console.Write("Введите начало диапазона ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона ");
            int B = int.Parse(Console.ReadLine());

            var firstPart = new FirstPart(size);

            Console.WriteLine("Исходный массив: ");
            PrintVector(firstPart.Vector);

            Console.WriteLine("Количество в диапазоне: " + firstPart.GetCountOfArrayBetweenAB(A,B));

            Console.WriteLine("Сумма после максимального: " + firstPart.GetSumAfterMax());
            firstPart.Sort();
            Console.WriteLine("После сортировки:");
            PrintVector(firstPart.Vector);
            
            Console.WriteLine("Часть 2:");
            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int cols = int.Parse(Console.ReadLine());
            var secondPart = new SecondPart(rows, cols);
            Console.WriteLine("Исходный массив: ");
            PrintMatrix(secondPart.Matrix);
            Console.Write("Введите количество элементов для сдвига: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите способ сдвига: если вниз, то 0, если вправо, то 1: ");
            int sdvig = int.Parse(Console.ReadLine());
            Console.WriteLine("После сдвига:");
            secondPart.DoSdvig(sdvig, count);


        }
        
        static void PrintVector(IEnumerable<int> vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}