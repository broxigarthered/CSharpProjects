using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int Rest = 0;

            Rest = 20-input.Length;

            if (input.Length<20)
            {
                Console.WriteLine(input+new string('*',Rest));
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
            }

        }
    }
}
