using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace justCars
{

    struct Car // v tazi struktura 6te se pazi info za 1 kola
    {
        public int x;
        public int y;
        public char c;
        public ConsoleColor color; // cveta
    }
    class Program
    {
        static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c); // na tazi poziciq da zapi6em simvola c
            Console.ForegroundColor = color;
        }
        static void PrintStringPosition(int x, int y, string info, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(info); // na tazi poziciq da zapi6em simvola c
            Console.ForegroundColor = color;
        }

        static void Main(string[] args)
        {
            double speed = 100.0;
            double acceleration = 0.5;

            int livesCount = 5; // jivoti
            char[] randomKoli4ki = { '!', 'o', '%', '&', '8' };
            int duljina = randomKoli4ki.Length;

            int playFieldWidth = 10;
            Console.BufferHeight = Console.WindowHeight = 25;
            Console.BufferWidth = Console.WindowWidth = 30;

            // user Car
            Car userCar = new Car();
            userCar.x = 2;
            userCar.y = Console.WindowHeight - 1; // kazvame 4e poziciqta i e nai-otdolo
            userCar.c = '@';
            userCar.color = ConsoleColor.Yellow;


            //tova 6te sa koli4kite koito suzdavame
            List<Car> cars = new List<Car>();
            Random randomGenerator = new Random();


            // The actual game is happening here
            while (true)
            {

                speed += acceleration;
                if (speed >= 400)
                {
                    speed = 400;
                }
                bool hitted = false;
                {
                    // vseki put suzdava nova koli4ka
                    Car newCar = new Car();
                    newCar.color = ConsoleColor.Green;
                    newCar.x = randomGenerator.Next(0, playFieldWidth); // 0-5
                    newCar.y = 0; // poqvqva se nai-otgore
                    newCar.c = '#';
                    // newCar.c = randomGenerator.Next(randomKoli4ki[0],randomKoli4ki[duljina]);
                    cars.Add(newCar);
                }



                // proverqva dali potrebitelq natiska kop4e
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true); // tozi red e za da napravi igrata po-plavna
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (userCar.x - 1 >= 0) // ideqta e da ne izleze ot konzolata
                        {
                            userCar.x--;
                        }
                        // nadqsno   
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    { // 6te dava na kolata da se dviji samo ako ne izlezne ot predefiniraniq playfield
                        if (userCar.x + 1 < playFieldWidth) // ideqta e da ne izliza ot widtha na consolata
                        {
                            userCar.x = userCar.x + 1;
                        }
                    }
                }
                List<Car> newList = new List<Car>();
                // za vseki xod koli4kite da slizat s 1 nadolo
                for (int i = 0; i < cars.Count; i++)
                {
                    Car oldCar = cars[i];
                    Car newCar = new Car();
                    newCar.x = oldCar.x;
                    newCar.y = oldCar.y + 1;
                    // kogato se blusnat
                    if (newCar.y == userCar.y && newCar.x == userCar.x)
                    {
                        speed += 20;
                        if (speed >= 400)
                        {
                            speed = 400;
                        }
                        hitted = true;
                        livesCount--;
                        PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
                        if (livesCount <= 0)
                        {
                            PrintStringPosition(8, 10, "GAME OVER", ConsoleColor.Red);
                            PrintStringPosition(8, 12, "Press enter to exit", ConsoleColor.Red);
                            Console.ReadLine();
                            return;
                            // return ili Environment.Exit(0); quitvat vednaga
                        }
                    }
                    newCar.c = oldCar.c;
                    newCar.color = oldCar.color;

                    // ako y e po-malak ot viso4inata na konzolata da pravi nova kola
                    // oba4e ako e po-malak NI6TO da ne se slu4va
                    if (newCar.y < Console.WindowHeight)
                    {
                        newList.Add(newCar);
                    }
                }
                cars = newList;

                Console.Clear();
                if (hitted)
                {
                    // da se 4istat koli4kite
                    cars.Clear();
                    PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
                }
                else PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);

                // za vsqka edna koli4ka v listata koli4ki
                foreach (Car car in cars)
                {
                    PrintOnPosition(car.x, car.y, car.c, car.color);
                }

                // Ako budem odareni da go markira s X za da se znae

                // pisane na ne6to v kozolata
                PrintStringPosition(playFieldWidth + 5, 2, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringPosition(playFieldWidth + 5, 3, "Speed: " + (int)speed, ConsoleColor.White);
                PrintStringPosition(playFieldWidth + 5, 4, "Acceleration: " + (int)acceleration, ConsoleColor.White);
                //Console.Beep();
                Thread.Sleep((int)(600 - speed));
            }

        }
    }
}
