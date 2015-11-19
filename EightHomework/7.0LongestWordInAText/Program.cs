using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._0LongestWordInAText
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (largestword.Length < buffer[i].Length)
            //{
            //    largestword = buffer[i];
            //}
            string[] input = Console.ReadLine().Split(new char[] {'.', ' '});
            string largestWord = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (largestWord.Length<input[i].Length)
                {
                    largestWord = input[i];
                }
            }
            Console.WriteLine("Largest word {0}, with length of  {1} characters.",largestWord,largestWord.Length);
            
        }
    }
}
