using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._0CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            Array.Sort(charArr);
            int counter = 0;
            for (int i = 0; i < charArr.Length - 1; i++)
            {
                counter++;
                if (charArr[i] != charArr[i + 1])
                {
                    Console.WriteLine("{0}: {1} time/s", charArr[i], counter);
                    counter = 0;
                }

                if (i == charArr.Length - 2)
                {
                    Console.WriteLine("{0}: {1} time/s", charArr[i + 1], ++counter);
                }
            }
        }
    }
}
