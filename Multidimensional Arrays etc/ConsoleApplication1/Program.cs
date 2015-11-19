using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            Console.WriteLine("Pattern A or Pattern B?");
            char pattern = (char)Console.Read();
            int currentNumber = 1;


            if (Char.ToUpper(pattern).Equals('A'))
            {

                for (int cols = 0; cols < n; cols++)
                {
                    for (int rows = 0; rows < n; rows++)
                    {
                        //Console.WriteLine("matrix[{0}, {1}] = ", rows, cols);
                        matrix[rows, cols] = currentNumber;
                        currentNumber++;
                    }
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(" " + matrix[row, col]);
                    }
                    Console.WriteLine();
                }

            }
            else if (Char.ToUpper(pattern).Equals('B'))
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (cols % 2 == 0)
                    {
                        for (int rows = 0; rows < n; rows++)
                        {
                            //Console.WriteLine("matrix[{0}, {1}] = ", rows, cols);
                            matrix[rows, cols] = currentNumber;
                            currentNumber++;
                        }
                    }
                    else
                    {
                        for (int rows = n - 1; rows >= 0; rows--)
                        {
                            //Console.WriteLine("matrix[{0}, {1}] = ", rows, cols);
                            matrix[rows, cols] = currentNumber;
                            currentNumber++;
                        }
                    }

                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(" " + matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
