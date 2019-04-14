using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pritisnete 1 za random broevi / 2 za manuelen vlez");
            int k = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            if (k == 1)
            {
                int N;
                Console.WriteLine("Enter number:");
                N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    if (max < number1) max = number1;
                    if (min > number1) min = number1;
                    sum += number1;
                }
                Console.WriteLine("Sredna vrednost {0}, max:{1}, min:{2}", sum / N, max, min);
                Console.ReadKey();
            }
            else if (k == 2)
            {
                Random ran = new Random();
                
                for(int i = 0; i < 1000; i++)
                {
                   int br = Convert.ToInt32 (ran.Next(0, 1000));
                    if (max < br) max = br;
                    if (min > br) min = br;
                    sum += br;
                }
                Console.WriteLine("Sredna vrednost {0}, max:{1}, min:{2}", sum / 1000, max, min);
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Nevaliden vlez!");
                Console.ReadKey();

            }
        }
    }
}
