using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            int Min = 50;
            int Max = 0;
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = rnd.Next(0,51);
                Console.WriteLine(array[i]);
                if (array[i]<Min)
                {
                    Min = array[i];
                }
                if (array[i] > Max)
                {
                    Max = array[i];
                }
            }
            Console.WriteLine("Сумма макс и мин {0}", Max+Min);
            Console.ReadKey();
        }
    }
}
