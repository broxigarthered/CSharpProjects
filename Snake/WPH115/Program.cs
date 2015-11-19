using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{ // deque razkarva posledniq element, enque slaga nai-otpred

    struct Position// konstruktora koito 6te sudirja kordinatite
    {
        public int row;
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        class Program
        {
            static void Main(string[] args)
            {
                byte right = 0;
                byte left = 1;
                byte down = 2;
                byte up = 3;
                Position[] directions = new Position[]{
                    new Position(0,1), //right
                    new Position(0,-1),//left
                    new Position(1,0), // down
                    new Position(-1,0), // up
                };
                int sleepTime = 100;
                int direction = right; // 0 teku6tat posoka // saotvetno kat elementi na masiva positoin
                Random randomNumberGenerator = new Random();
                Console.BufferHeight = Console.WindowHeight; // consolata da nqma scrollbar i buffera da bude golqm kolkoto consolata

                Position food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), // slaga qbalkata na random mesto
                    randomNumberGenerator.Next(0, Console.WindowWidth)); // tuka 6te ni se generira slu4aino 4islo koeto 6te opredelq kade e qbalkata

                Queue<Position> snakeElements = new Queue<Position>(); // tova 6te e opa6kata TUKA SE PRAVQT ZMIQTA 
                Position position1 = new Position();



                for (int i = 0; i <= 5; i++)
                {
                    snakeElements.Enqueue(new Position(0, i));
                }
                foreach (Position position in snakeElements) // obxojda vsi4kite elementi i postavqme kursora tam kadeto se namira zmiqta
                {
                    Console.SetCursorPosition(position.col, position.row); // tazi poziciq priema left top kolona
                    Console.WriteLine('*');
                }

                while (true)
                {
                    if (Console.KeyAvailable) // proverqva dali potrebitelq e natisnal nqkakvo kop4e
                    {

                        ConsoleKeyInfo userInput = Console.ReadKey(); // pro4ita ne6to tam
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right) // ako posokata ne e nadqsno 4ak togava da se mesti nalqvo
                            {
                                direction = left;
                            }
                        }
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left)
                            {
                                direction = right;
                            }

                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down)
                            {
                                direction = up;
                            }

                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if (direction != up) // ako posokata ne e nagore 4ak togava da se mestim nadolo
                            {
                                direction = down;
                            }
                        }

                    }
                    Position snakeHead = snakeElements.Last(); // tozi method vru6ta posledniq element ot opa6kata

                    Position nextDirection = directions[direction]; // s tozi red vzimame na kade da se dviji zmiqta kato directions e masiva a direction 0,1,2,3

                    //novata poziciq na zmiqta
                    Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);// purvo e X posle e Y kato za primer vzimame stariq direction na row i go
                    //Position newHead = snakeElements.Last();// tova ni vru6ta glavata na na6ta zmiq i q zapisva v promenlivata new head
                    snakeElements.Enqueue(snakeNewHead); // tozi kod slaga nova glava vseki put na novata poziciq
                    // tova proverqva dali glavata na zmiqta ne e izlezla ot ekrana bukvalno
                    if (snakeNewHead.row < 0 ||
                        snakeNewHead.col < 0 ||
                        snakeNewHead.row >= Console.WindowHeight ||
                        snakeNewHead.col >= Console.WindowWidth) // row = red
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine();
                        Console.WriteLine("Game over");
                        Console.WriteLine("Your points are: {0}", (snakeElements.Count - 6) * 100); // tova vru6ta broq elementi na zmiqta
                        return; // prikliu4va izpulnenieto na teku6tiq method
                    }


                    //TOVA E KODA AKO ZMIQTA APNE QBALKATA
                    if (snakeNewHead.col == food.col && snakeNewHead.row == food.row) // tuka slagame statement koito proverqva dali glavata na zmiqta se zasi4a s tazi na xranata
                    {
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), // slaga qbalkata na random mesto, no tozi put prosto vzima novi stoinosti za novata qbalka
                    randomNumberGenerator.Next(0, Console.WindowWidth)); // tuka 6te ni se generira slu4aino 4islo koeto 6te opredelq kade e qbalkata
                        sleepTime -= 10; // da stava s 20 milisekundi po-burza
                    }
                    else // samo kogato zmiqta ne udrq lqbalkata 6te se maxa edna zvezda ot opajkata
                    {
                        snakeElements.Dequeue();
                    }


                    // garanciqta 4e 6te imame nova qbalka i zmiq e 4e console clear e predi tqx a ne sled tqx


                    Console.Clear(); // 4isti konzolata

                    foreach (Position position in snakeElements) // obxojda vsi4kite elementi i postavqme kursora tam kadeto se namira zmiqta
                    {
                        Console.SetCursorPosition(position.col, position.row); // tazi poziciq priema left top kolona
                        Console.WriteLine('*');
                    }
                    Console.SetCursorPosition(food.col, food.row); // S TOZI KOD RISUVAME QBALKATA NA RANDOM MESTO V KONZOLATA
                    Console.Write('@');



                    Thread.Sleep(sleepTime); // konzolata spira prosto bavi zmiqta s opredeleno vreme
                }
            }
        }
    }
}
//KOMENTARI
/*position1.X=0;
               position1.Y=0;
               snakeElements.Enqueue(position1);
                * Position position1 = new Position(0,0) - x i y
                */