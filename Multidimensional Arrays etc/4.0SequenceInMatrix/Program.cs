using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];
            List<string> tempList = new List<string>();
            List<string> resultList = new List<string>();
            

            //4etene na matricata
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();

                
                }
            }
            tempList.Add(matrix[0,0]);
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    // checks on single Line
                    if (matrix[row,col].Equals(matrix[row,col+1].Equals(matrix[row,col+2])))
                    {
                        tempList.Add(matrix[row,col]);
                        tempList.Add(matrix[row, col+1 ]);
                        tempList.Add(matrix[row, col + 2]);
                    }
                        //diagonal
                    else if(matrix[row,col].Equals(matrix[row+1,col+1]).Equals(matrix[row+2,col+2]))
                    {
                        tempList.Add(matrix[row , col ]);
                        tempList.Add(matrix[row+1, col+1]);
                        tempList.Add(matrix[row +2, col + 2]);
                    }
                    else if(matrix[row,col].Equals(matrix[row+1,col]).Equals(matrix[row+2,col]))
                    {
                        tempList.Add(matrix[row,col]);
                        tempList.Add(matrix[row+1, col]);
                        tempList.Add(matrix[row+1, col]);
                    }

                    if (tempList.Count>resultList.Count)
                    {
                        resultList.Clear();
                        resultList.AddRange(tempList);
                    }
                    else
                    {
                        tempList = new List<string>();
                        tempList.Add(matrix[row,col]);
                    }

                }
            }
            foreach (var VARIABLE in resultList)
            {
                Console.Write("{0}, ",VARIABLE);
            }
        }
    }
}
