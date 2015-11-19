using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingStonesReal
{
    class Program
    {
        struct Objects
        {
            public int x;
            public int y;
            public char c;
            public ConsoleColor color;
        }

        static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            // here is where we are saying where the cursor should be placed
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.ForegroundColor = color;
        }

        static void PrintStringPosition(int x, int y, string info, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(info);
            Console.ForegroundColor = color;
        }
        static void Main(string[] args)
        {
            //Console 
            int speed = 100;
            int playFieldWidth = 15;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 35;

            Objects userDwarf = new Objects();
            userDwarf.x = 2;
            userDwarf.y = Console.WindowHeight - 1;
            userDwarf.c = '@';
            userDwarf.color = ConsoleColor.White;

            List<Objects> objectss = new List<Objects>();
            Random randomGenerator = new Random();

            while (true)
            {
                if (speed >= 400)
                {
                    speed = 400;
                }
                Objects newEnemy = new Objects();
                newEnemy.color = ConsoleColor.Green;
                newEnemy.x = randomGenerator.Next(0, playFieldWidth); // 0-5
                newEnemy.y = 0; // poqvqva se nai-otgore
                newEnemy.c = '#';
                // newCar.c = randomGenerator.Next(randomKoli4ki[0],randomKoli4ki[duljina]);
                objectss.Add(newEnemy);
            }

        }
    }
}
