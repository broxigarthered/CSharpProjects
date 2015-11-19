using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class Program
    {
        
                 static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {20, 40, 10, 10, 30, 80};

            List<int> removeNumbers = new List<int> {25, 20, 40, 30, 10 };
           

             RemoveEqualNumbers(removeNumbers, numbers);
        }

        static void RemoveEqualNumbers(List<int> removeNumbers, List<int> numbers)
        {
            int counter = 1;
            for (int i = 0; i < removeNumbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (removeNumbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        counter = 0;
                    }
                }
                
            }
            if (counter == 1)
            {
                PrintNumbers(removeNumbers, numbers);
                return;
            }
            RemoveEqualNumbers(removeNumbers, numbers);
        }

        static void PrintNumbers(List<int> removeNumbers, List<int> numbers)
        {
            numbers.AddRange(removeNumbers);
            numbers.Sort();

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}