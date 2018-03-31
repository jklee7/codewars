using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {

        /*
         * Your task is to sort a given string. Each word in the String will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input String is empty, return an empty String. The words in the input String will only contain valid consecutive numbers.

For an input: "is2 Thi1s T4est 3a" the function should return "Thi1s is2 3a T4est"

your_order("is2 Thi1s T4est 3a")
[1] "Thi1s is2 3a T4est"

         * */
        static void Main(string[] args)
        {
            string x = "is2 Thi1s T4est 3a";

            Console.WriteLine($"{Order(x)}!!!");
            Console.ReadKey();

        }


        public static string Order(string words)
        {
            if (words == "")
            {
                return "";
            }

            string[] splitted = words.Split(' ');
            string[] sorted = new string[splitted.Length];

            foreach (var word in splitted)
            {
                foreach (char i in word)
                {
                    if (Char.IsNumber(i))
                    {
                        sorted[int.Parse((i).ToString()) - 1] = word;
                        break;
                    }
                }
            }

            return String.Join(" ", sorted);

        }

    }
}
