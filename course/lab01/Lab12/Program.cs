using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double sum = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            Console.WriteLine("Enter number:");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++) {
               int number1 = Convert.ToInt32(Console.ReadLine());
                if (max < number1) max = number1;
                if (min > number1) min = number1;
                sum += number1;
            }
            Console.WriteLine("Sredna vrednost {0}, max:{1}, min:{2}", sum/N, max, min);
            Console.ReadKey();

        }
    }
}
