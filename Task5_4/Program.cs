using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write("{0}  ", array[i]);
            }

            for (int i = 1; i < 20; i+=2)
            {
                if (((array[i] % 2) == 1) && (array[i] > 0))
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество искомых чисел {0}", count);
            Console.ReadKey();
        }
    }
}
