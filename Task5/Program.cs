using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            double mean = Sum / 7;
            Console.WriteLine("Среднее арифмитическое {0}", mean);
            Console.ReadKey();
        }
    }
}
