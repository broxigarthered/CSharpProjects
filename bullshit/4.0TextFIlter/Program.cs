using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0TextFIlter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] bannedWords = input.Split(new char[]
                {',',' '},StringSplitOptions.RemoveEmptyEntries);

            string secondInput = Console.ReadLine();

            string replaced = secondInput.Replace(bannedWords[0],new string('*',bannedWords[0].Length))
                .Replace(bannedWords[1], new string('*', bannedWords[1].Length));;

            Console.WriteLine();
            Console.WriteLine(replaced);

        }
    }
}
