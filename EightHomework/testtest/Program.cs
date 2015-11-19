using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtest
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<string> names = new List<string>();
            List<string> secondNames = new List<string>();
            string[] input = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                names.Add(input[i]);
            }
            for (int j = 0; j < input2.Length; j++)
            {
                secondNames.Add(input2[j]);
            }



            for (int i = 0; i < secondNames.Count; i++)
            {
                for (int p = 0; p < names.Count; p++)
                {
                   // if (names[j].Contains(secondNames[i]))
                    if (secondNames[i] == names[p])
                    {
                        names.RemoveAt(p);
                        if (p == names.Count)
                        {
                            break;
                        }
                        if (secondNames[i] == names[p])
                        {
                            names.RemoveAt(p);
                            p--;
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
