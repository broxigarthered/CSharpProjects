using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string searchedWord = Console.ReadLine();

            int count = input.Select((c, i) => input.Substring(i))
                .Count(x => x.StartsWith(searchedWord, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(count);
        }
    }
}
