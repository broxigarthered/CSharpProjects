using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0ReverseString
{
    //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] result = input.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);

        }
    }
}
