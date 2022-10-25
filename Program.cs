using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("n(>0) = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            if (CheckPrime(n))
            {
                Console.WriteLine(n + " est un nombre premier");
            }
            else
            {
                Console.WriteLine(n + " n\'est pas un nombre premier");
            }
            Console.ReadLine();
        }
        public static bool CheckPrime(int n)
        {
            int d;
            bool p;
            d = 2;
            p = true;
            while ((d*d <= n) && p)
            {
                if (n % d == 0)
                {
                    p = false;
                }
                else
                {
                    d++;
                }
            }
            return p;
        }

    }
}

