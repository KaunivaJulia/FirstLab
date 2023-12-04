using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    public class SecondPart
    {
        private readonly int[,] matrix;

        public SecondPart(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows) + " or " + nameof(cols));
            }

            matrix = new int[rows, cols];

            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
        }


        public int[,] Matrix
        {
            get
            {
                return matrix;
            }
        }

        public void DoSdvig(int sdvig, int count)
        {

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Неверное значение для сдвига");
            }
            if (sdvig != 0 & sdvig != 1)
            {
                throw new ArgumentOutOfRangeException("Неверное значение для сдвига");
            }

            int stol = matrix.GetLength(0); // длина столбца
            int str = matrix.GetLength(1);
            int inew, jnew;
            if (sdvig == 1)
            {
                Console.WriteLine("Сдвиг вправо: ");
                int nnew = str - count % str; // Выносим повторяющиеся вычисления за пределы цикла
                for (int i = 0; i < stol; i++)
                {
                    inew = i;
                    for (int j = 0; j < str; j++)
                    {
                        jnew = (j + nnew) % str;
                        Console.Write("{0,4}", matrix[inew, jnew]);
                    }
                    Console.WriteLine();
                }
            }
            if (sdvig == 0)
            {
                Console.WriteLine("Сдвиг вниз: ");
                int nnnew = stol - count % stol; // Выносим повторяющиеся вычисления за пределы цикла
                for (int i = 0; i < stol; i++)
                {
                    for (int j = 0; j < str; j++)
                    {
                        jnew = j;
                        inew = (i + nnnew) % stol;
                        Console.Write("{0,4}", matrix[inew, jnew]);
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadLine();
        }
    }
}

