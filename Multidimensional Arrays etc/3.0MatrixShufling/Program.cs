using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0MatrixShufling
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];

            //4etene na matricata
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();

                }
            }
            string[] input = Console.ReadLine().Split(' ');
            while (!input.Contains("END"))
            {

                if (!input.Contains("swap"))
                {
                    Console.WriteLine("Invalid Input!");
                }
                else
                {
                    int x1 = int.Parse(input[1]);
                    int y1 = int.Parse(input[2]);
                    int x2 = int.Parse(input[3]);
                    int y2 = int.Parse(input[4]);

                    if (x1 <= rows && x2 <= rows && y1 <= cols && y2 <= cols)
                    {

                        //Swaping
                        string temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;

                        //Printing the matrix
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(" " + matrix[row, col]);
                            }
                            Console.WriteLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
                input = Console.ReadLine().Split(' ');
            }

        }
    }
}
