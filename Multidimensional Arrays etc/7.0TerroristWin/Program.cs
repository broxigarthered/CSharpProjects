using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._0TerroristWin
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 0;
            int Length = input.Length;
            int sumAscii = 0;

            int bombStart = input.IndexOf("|");
            int bombEnd = input.LastIndexOf("|");
            int whatsInside = bombEnd - bombStart;

            string substringOfChars = input.Substring(bombStart+1, whatsInside-1);
            string substringWith = input.Substring(bombStart, whatsInside + 1);
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(substringOfChars);

            foreach (byte b in ASCIIValues)
            {
                sumAscii += b;
            }

            int lastNumber = sumAscii%10;
            
            string totalDots = new string('.',lastNumber+4);


            string resultString = string.Empty;
            //Console.WriteLine(resultString);

            for (int i = 0; i < input.Length; i++)
            {
                if (i<bombStart-2 || i>bombEnd+3)
                {
                    resultString += input[i];
                }
                
                if (i == bombStart-2)
                {
                    resultString += totalDots;
                }
                if (i==bombEnd+2)
                {
                    resultString += input[i];
                }
            }
            Console.WriteLine(resultString);

        }
    }
}
