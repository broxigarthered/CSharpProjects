using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0MaximalSum
{
    class Program
    {
        

        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           int  rows = arr[0];
           int cols = arr[1];
            int[,] matrix = new int[rows, cols];
            int tempSum = int.MinValue;
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            //Readva cqla matrica
            for (int row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(currentRowNumbersAsStrings[col]);
                }
            }
            

            

            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (tempSum>bestSum)
                    {
                        bestSum = tempSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("Sum = {0}",bestSum);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol],  matrix[bestRow, bestCol + 1],  matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1,bestCol+2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        }
        
    }
}
