using System;
using System.Text.RegularExpressions;

namespace _15_ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MatchCollection urls = Regex.Matches(text, @"\b(?:http://|www\.)+([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
            //\b(?:http://|www\.)

            foreach (var url in urls)
            {
                Console.WriteLine(url);
            }
        }
    }
}