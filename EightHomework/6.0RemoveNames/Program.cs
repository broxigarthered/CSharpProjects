

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class Remove
    {
        static void Main(string[] args)
        {
            //INPUT
            List<string> names = new List<string>();
            List<string> equalNames = new List<string>();
            string[] input = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            
            //Adding the input ot the lists
            for (int i = 0; i < input.Length; i++)
            {
                names.Add(input[i]);
            }
            for (int j = 0; j < input2.Length; j++)
            {
                equalNames.Add(input2[j]);
            }

            //Finding the equal

            for (int i = 0; i < equalNames.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (equalNames[i] == names[j])
                    {
                        names.RemoveAt(j);
                        if (j == names.Count)
                        {
                            break;
                        }
                        if (equalNames[i] == names[j])
                        {
                            names.RemoveAt(j);
                            j--;
                            continue;
                        }
                    }
                }
            }

            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
