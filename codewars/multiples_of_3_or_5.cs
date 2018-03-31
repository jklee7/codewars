using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Kata(10));
            Console.ReadKey();
        }

        static int Kata(int value)
        {
            int sum = 0;
            for (var i = 0; i < value; i++)
            {
                Console.WriteLine($"{i} {sum}");
                var mod3 = i % 3;
                var mod5 = i % 5;

                if (mod3 == 0 && mod5 == 0)
                {
                    sum += i;
                    Console.WriteLine($"Adding {i}");
                }
                else if (mod3 == 0)
                {
                    sum += i;
                    Console.WriteLine($"Adding {i}");
                }
                else if (mod5 == 0)
                {
                    sum += i;
                    Console.WriteLine($"Adding {i}");
                }
            }

            return sum;
            // return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }

    }
}
