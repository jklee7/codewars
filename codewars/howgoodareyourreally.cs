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



            Console.ReadKey();

        }

        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > ClassPoints.Concat(new int[] { YourPoints }).Average() ? true : false;
            /*
            if (YourPoints > ClassPoints.Concat(new int[] { YourPoints }).Average())
            {
                return true;
            }
            return false;
            */
        }

    }
}
