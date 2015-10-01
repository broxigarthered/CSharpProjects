using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6._0Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> result = Regex.Matches(input, @"\w+").Cast<Match>()
                           .Select(m => m.Value)
                           .Where(w => String.Join("", w.Reverse()) == w).ToList();
            Console.WriteLine(string.Join(", ", result));    
        }
    }
}
