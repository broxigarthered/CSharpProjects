using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineStrings = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double result1 = 0;
            double result2 = 0;

            for (int i = 0; i < lineStrings.Length; i++)
            {
                string temp = lineStrings[i];

                string first = Regex.Match(temp, @"\d+").Value;
                int number = int.Parse(first);

                char firstChar = temp[0];
                char lastChar = temp[temp.Length - 1];


                //mainLogic

                //before the number
                if (char.IsUpper(firstChar))
                {
                    double divisior = PositionUpper(firstChar);
                    result1 += number / divisior;
                }
                if (char.IsLower(firstChar))
                {
                    double multiply = PositionLower(firstChar);
                    result1 += number * multiply;
                }
                //Letter after the number
                if (char.IsUpper(lastChar))
                {
                    double substract = PositionUpper(lastChar);
                    result1 -= substract;
                }
                if (char.IsLower(lastChar))
                {
                    double addition = PositionLower(lastChar);
                    result1 += addition;
                }


            }
            
            Console.WriteLine("{0:f2}", result1);
        }

        public static double PositionUpper(char input)
        {
            List<char> alphabet = new List<char>();
            //TheAlphaBet
            for (char c = 'A'; c <= 'Z'; ++c)
            {
                alphabet.Add(c);
            }
            for (int i = 0; i < alphabet.Count; i++)
            {
                if (alphabet[i] == input)
                {
                    double result = i + 1;
                    return result;
                }
            }
            return -1;
        }

        public static double PositionLower(char input)
        {
            List<char> alphabet = new List<char>();
            //TheAlphaBet
            for (char c = 'a'; c <= 'z'; ++c)
            {
                alphabet.Add(c);
            }
            for (int i = 0; i < alphabet.Count; i++)
            {
                if (alphabet[i] == input)
                {
                    double result = i + 1;
                    return result;
                }
            }
            return -1;
        }



    }
}

