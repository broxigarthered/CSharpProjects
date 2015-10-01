using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._0ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([a-z]+.[a-z]+@[a-z]+.[a-z]+.[a-z]+)";

            Regex regex = new Regex(pattern);
            

            
            //MatchCollection matches = pattern.Matches(input);
            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}


     