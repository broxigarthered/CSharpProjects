using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._0ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
            string pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                string url = item.Groups[1].ToString();
                string text = item.Groups[2].ToString();
                regex.Replace(input, item.ToString());
                string replace = @"[URL href=" + item.Groups[1] + "]" + item.Groups[2] + "[/URL]";
                Console.WriteLine(Regex.Replace(input,pattern,replace));
            }
        }
    }
}
