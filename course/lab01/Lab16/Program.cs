using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void hesyam(out int max,int[] a,out int min) {
            max = a.Max();
            min = a.Min();
            
        }

        static void Main(string[] args)
        {
            int N;
            int max=0, min=0;
            double sum = 0;
            Console.WriteLine("Enter number:");
            
            N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                array[i] = number1;
                sum += number1;
            }
            hesyam(out max, array,out  min);
            Console.WriteLine("Sredna vrednost {0}, max:{1}, min:{2}", sum / N, max, min);
            Console.ReadKey();
        }
    }
}
