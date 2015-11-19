using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            while (true)
            {
                Console.Beep(r.Next(100, 10000), r.Next(60, 500));
            }
            
        }
    }
}
