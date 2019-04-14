using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{

    enum PasswordStrength : byte
    {
        easy,
        normal,
        hard
    }

    class Program
    {
       
        public static String psw(PasswordStrength p)
        {
            String pass = "";
            StringBuilder sb = new StringBuilder();
            Random ran = new Random();
            if (p == PasswordStrength.easy)
            {
                for (int i = 0; i < 6; i++)
                {
                    char c = Convert.ToChar(ran.Next(97, 123));
                    sb.Append(c);
                }
            }
            else if (p == PasswordStrength.normal)
            {
                for (int i = 0; i < Convert.ToInt32(ran.Next(6, 11)); i++)
                {
                    int k = ran.Next(1, 3);
                    char c = Convert.ToChar(0);
                    if (k == 1) { c = Convert.ToChar(ran.Next(65, 91)); }
                    if (k == 2)
                    {
                        c = Convert.ToChar(ran.Next(48, 58));
                    }
                    sb.Append(c);
                }

            }
            else if (p == PasswordStrength.hard)
            {
                for (int i = 0; i < Convert.ToInt32(ran.Next(10, 16)); i++)
                {
                    int k = ran.Next(1, 4);
                    char c = Convert.ToChar(0);
                    if (k == 1) { c = Convert.ToChar(ran.Next(65, 91)); }
                    if (k == 2)
                    {
                        c = Convert.ToChar(ran.Next(48, 58));
                    }
                    if (k == 3)
                    {
                        c = Convert.ToChar(ran.Next(97, 123));
                    }
                    sb.Append(c);

                }

                
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi 3 lozinki");
            string line = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = line.Split(delimiter);

            String pass1 = psw(PasswordStrength.easy);
            String pass2 = psw(PasswordStrength.normal);
            String pass3 = psw(PasswordStrength.hard);

            Console.WriteLine("Vie vnesovte {0} - {1} bese izgenerirano", parts[0], pass1);
            Console.WriteLine("Vie vnesovte {0} - {1} bese izgenerirano", parts[1], pass2);
            Console.WriteLine("Vie vnesovte {0} - {1} bese izgenerirano", parts[2], pass3);
            Console.ReadKey();

        }
    }
}
