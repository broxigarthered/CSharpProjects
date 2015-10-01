using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(GetCharUnicode(input[i]));
            }

        }

        public static string GetCharUnicode(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }

}
