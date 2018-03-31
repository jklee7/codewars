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
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Console.WriteLine(Number(peopleList));
            Console.ReadKey();

        }

        static int Number(List<int[]> peopleListInOut)
        {
            int onboard = 0;
            foreach (var people in peopleListInOut)
            {
                onboard += people[0];
                onboard -= people[1];
            }

            return onboard;
        }

        /*
          public static int Number(List<int[]> peopleListInOut)
          {
            return peopleListInOut.Sum(Item => Item[0] - Item[1]);
          }
        */

    }
}
