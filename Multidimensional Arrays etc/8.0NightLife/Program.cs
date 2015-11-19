using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0NightLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,SortedDictionary<string,SortedSet<string>>> nightlifeDictionary = 
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            //promenlivi
            string[] eventTokens;
            string city = string.Empty;
            string venue = string.Empty;
            string performer = string.Empty;
            string eventInformation = Console.ReadLine();
            //body
            while (eventInformation!="END")
            {
                eventTokens = eventInformation.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                city = eventTokens[0];
                venue = eventTokens[1];
                performer = eventTokens[2];
                //adding the city
                if (!nightlifeDictionary.ContainsKey(city))
                {
                    nightlifeDictionary[city] = new SortedDictionary<string, SortedSet<string>>();
                }

                //adding the venue
                if (!nightlifeDictionary[city].ContainsKey(venue))
                {
                    nightlifeDictionary[city][venue] = new SortedSet<string>();
                }

                nightlifeDictionary[city][venue].Add(performer);
                eventInformation = Console.ReadLine();
            }

            foreach (var cityPair in nightlifeDictionary)
            {
                Console.WriteLine(cityPair.Key);
                foreach (var venuePair in cityPair.Value)
                {
                    Console.WriteLine("->{0}: {1}", venuePair.Key, String.Join(", ", venuePair.Value));
                }
            }
        }
    }
}
