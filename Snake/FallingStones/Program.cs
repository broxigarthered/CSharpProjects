using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingStones
{
    struct Position
    {
        public int row; // reda
        public int col; // kolonata

        public Position(int row, int col) // konstruktora za mestoto
        {
            this.row = row;
            this.col = col;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Definiciq na polojeniqta, nakade 6te se dviiji
            byte right = 0;
            byte left = 1;

            int sleepTime = 2000;

            Position[] directions = new Position[]{ // masiv
                new Position(0,0), //edno nadqsno e nadqsno // 0 element
                new Position(0,-1), // edno -1 nalqvo   // purvi element
                
            };
            int direction = right; // teku6tata posoka nakade da trugne
            Console.BufferHeight = Console.WindowHeight= 20; // maxame scrollbara
            Console.BufferWidth = Console.WindowWidth = 30;

            // 
            Queue<Position> dwarfElements = new Queue<Position>();//
            Position position1 = new Position();

            for (int i = 0; i < 1; i++)
            {
                dwarfElements.Enqueue(new Position(0, 1));
            }

            foreach (Position position in dwarfElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.WriteLine('0');
            }

            while (true)
            {
                if (Console.KeyAvailable) // proverqva dali e natisnato kop4e
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(); // 4ete inputa
                    if (userInput.Key == ConsoleKey.LeftArrow) // ako e natisnato nalqvo
                    {
                        direction = left;
                    }
                    if (userInput.Key==ConsoleKey.RightArrow)
                    {
                        direction = right;
                    }

                }
                Position dwarfHead = dwarfElements.Last();

                Position nextDirection = directions[direction]; // kade se dviji

                Position dwarfNewHead = new Position(dwarfHead.row + nextDirection.row,dwarfHead.col + nextDirection.col);
                dwarfElements.Enqueue(dwarfNewHead);


                // ako dwarfa izleze ot buffera
                if (dwarfNewHead.row < 0 ||
                    dwarfNewHead.col < 0 ||
                    
                    dwarfNewHead.row > Console.WindowWidth)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine();
                    Console.WriteLine("Game over");
                    return;
                }
                dwarfElements.Dequeue();

                Console.Clear();
                foreach (Position position in dwarfElements)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.WriteLine('0');
                }

                Thread.Sleep(sleepTime);
                
            }
        }
    }
}
