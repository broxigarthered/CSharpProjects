using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._0Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            Dictionary<string, string> phonebookResult = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split('-');
            string casualInput = string.Empty;
            //phonebook[input[0]] = input[1];

            while (!input.Contains("search"))
            {
                for (int i = 1; i < input.Length; i++)
                {
                    phonebook[input[i - 1]] = input[i];
                }


                input = Console.ReadLine().Split('-');
            }

            while (true)
            {
                casualInput = Console.ReadLine();
                if (phonebook.ContainsKey(casualInput))
                {

                    Console.WriteLine("{0} --> {1}", casualInput, phonebook[casualInput]);

                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist", casualInput);
                }
            }
        }
    }
}
