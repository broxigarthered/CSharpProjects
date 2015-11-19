using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0LongestAreaInArray
{
    class Program
    {
        static void Main(string[] args)
            //Doesn't really work
        {
            int nlength = int.Parse(Console.ReadLine());
            string[] words = new string[nlength];
            int streak = 0;
            int bestStreak = 0;

            for (int i = 0; i < nlength; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 1; i < nlength; i++)
            {
                if (words[i] == words[i - 1])
                {
                    streak++;
                    if (streak > bestStreak)
                    {
                        bestStreak = streak;
                    }

                }
                else bestStreak = 1;
                 

            }
            Console.WriteLine(bestStreak);


        }
    }
}
