using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0SortingNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //array with n elements
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            // input the numbers in the array
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //sorting the array
            Array.Sort(arr);
            //cando without this foreach
            foreach (int numbers in arr)
            {
                Console.WriteLine(numbers + " ");
            }
        }
    }
}
