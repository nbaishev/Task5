using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();

            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }
                
            }

            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }

            }

            for (int i = 0; i < 10; i++)
            {

                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
