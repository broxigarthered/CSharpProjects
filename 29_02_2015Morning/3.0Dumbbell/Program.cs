using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0Dumbbell
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int const1 = n / 2;
            Console.WriteLine("{0}{1}{2}{1}{0}",new string ('.',const1),
            new string ('&',n/2+1),
            new string ('.',n)
            );

            int const2Zvezdi = n/2;
            for (int i = 0; i <n/3; i++,const1--,const2Zvezdi++)
            {
                //7 -- 2     5 ---- 1
                string outerDots = new string('.', const1-1);
                string zvezdi4ki = new string('*', const2Zvezdi);
                string innerDots = new string('.', n);

                Console.WriteLine("{0}&{1}&{2}&{1}&{0}",outerDots,zvezdi4ki,innerDots);

            }

            Console.WriteLine("&{0}&{1}&{0}&", new string('*', n - 2), new string('=', n));

            int const3 = n-3;
            for (int i = 0; i < n/3; i++,const3--)
            {
                string outerDots = new string('.', i + 1);
                string zvezdi = new string('*', const3);
                string innerDots = new string('.', n);
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}",outerDots,zvezdi,innerDots);
            }

            int const5 = n / 2;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', const5),
            new string('&', n / 2 + 1),
            new string('.', n)
            );
        }
    }
}

//5	
//..&&&.....&&&..
//.&**&.....&**&.
//&***&=====&***&
//.&**&.....&**&.
//..&&&.....&&&..

//7
//...&&&&.......&&&&...
//..&***&.......&***&..
//.&****&.......&****&.
//&*****&=======&*****&
//.&****&.......&****&.
//..&***&.......&***&..
//...&&&&.......&&&&...

