using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(-|\s)(\d{1})(-|\s)(\d{3})(-|\s)(\d{4})";

            List<string> numbersList = new List<string>()
            {
                " 359-2-222-2222",
                "+359/2/222/2222",
                "+359-2 222 2222",
                "+359 2-222-2222",
                "+359-2-222-222",
                "+359-2-222-22222",
                "+359 2 222 2222",
                "+359-2-222-2222"
            };

            Regex regex = new Regex(pattern);
            foreach (var email in numbersList)
            {
                Console.WriteLine(regex.IsMatch(email));
            }
        }
    }
}
