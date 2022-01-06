using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array2D = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (((i + j) % 2) == 0)
                    {
                        array2D[i, j] = 1;
                    }
                    else
                    {
                        array2D[i, j] = 0;
                    }
                    Console.Write("{0} ", array2D[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
