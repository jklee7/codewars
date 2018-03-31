using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in humanYearsCatYearsDogYears(1))
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }


        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            if (humanYears == 1)
            {
                return new int[] { 1, 15, 15 };
            }
            else if (humanYears == 2)
            {
                return new int[] { 2, 24, 24 };
            }

            int catAge = 24 + (humanYears - 2) * 4;
            int dogAge = 24 + (humanYears - 2) * 5;
            return new int[] { humanYears, catAge, dogAge };
        }

    }
}
