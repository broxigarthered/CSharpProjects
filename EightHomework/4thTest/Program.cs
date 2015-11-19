using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string[,] matrix = new string[c, r];
            int[,] matrix1 = new int[c, r];
            char[] masiv = { 'a', 'b', 'c', 'd', 'e', 'g' };



            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write(masiv[row] + "" + masiv[col] + "" + masiv[row] + " ");

                }
                Console.WriteLine();
            }

        }
    }
}
