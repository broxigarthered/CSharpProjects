
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0EncrtyptedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string number = "";

           
            StringBuilder list = new StringBuilder("");
            StringBuilder resultList = new StringBuilder("");
            // 4rez tova vzimame ASCII nomerata na nqkva duma 
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(input);

            // 4rez  tozi ciukul advame poslednite cifri kum string
            foreach (byte b in ASCIIValues)
            {
                number += b%10;
            }

            for (int i = 0; i < number.Length; i++)
            {
                list.Append(number[i]);
            }

            //Then you should encrypt the converted number digit by digit. The formula is the following: If the digit is even or '0' - you should multiply it by itself.
            //If the digit is odd – you should add to its value the neighboring digits. 
            //If there is a missing neighboring digit, you should add 0 instead of it.
              for (int i = 0; i < list.Length; i++)
                {
                    int currentDigit = list[i] - '0';

                    int resultingDigit;

                    if (currentDigit % 2 == 0)
                    {
                        resultingDigit = currentDigit * currentDigit;
                    }
                    else
                    {
                        int leftDigit = i == 0 ? 0 : list[i - 1] - '0';
                        int rightDigit = i == list.Length - 1 ? 0 : list[i + 1] - '0';
                        resultingDigit = currentDigit + leftDigit + rightDigit;
                    }

                    resultList.Append(resultingDigit);
                }
                


                int position = 0;
                int update = 0;
                switch (secondInput)
                {       // main diagonal
                    case "\\":
                        position = 0;
                        update = 1;

                        for (int i = 0; i <resultList.Length; i++)
                        {
                            for (int j = 0; j < resultList.Length; j++)
                            {
                                if (j==position)
                                {
                                    Console.Write(resultList[j] + " ");
                                }
                                else
                                {
                                    Console.Write("0 ");
                                }
                            }
                            Console.WriteLine();
                            position += update;
                        }
                        break;
                        

                    case"/":
                        position = resultList.Length - 1;
                        update = -1;
                        for (int i = 0; i <resultList.Length; i++)
                        {
                            for (int j = 0; j < resultList.Length; j++)
                            {
                                if (j==position)
                                {
                                    Console.Write(resultList[j] + " ");
                                }
                                else
                                {
                                    Console.Write("0 ");
                                }
                            }
                            Console.WriteLine();

                            position += update;
                        }
                        break;

                        //0 0 0 0 0 0 0 0 5
                        //0 0 0 0 0 0 0 0 0
                        //0 0 0 0 0 0 7 0 0
                        //0 0 0 0 0 4 0 0 0
                        //0 0 0 0 6 0 0 0 0
                        //0 0 0 3 0 0 0 0 0
                        //0 0 4 0 0 0 0 0 0
                        //0 6 0 0 0 0 0 0 0
                        //4 0 0 0 0 0 0 0 0

                        

                    
                }
            }
            
            
        }
    }

