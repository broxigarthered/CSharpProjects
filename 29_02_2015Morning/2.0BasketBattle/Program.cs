using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0BasketBattle
{
    class Program
    {
        static int simoPoints = 0;
        static int simoPointsResult = 0;
        static int nakovPoints = 0;
        static int nakovPointsResult = 0;
        static string secondInput = "";
        static int rounds = 0;
        static int roundsPlayedS = 0;
        static int roundsPlayedN = 0;
        static bool nakov = false;
        static bool simo = false;
        static int Npoints = 0;
        static int Spoints = 0;
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();

            
            
            rounds = int.Parse(Console.ReadLine());
            
            switch (firstInput)
            {
                case "Simeon":
                    simo = true;
                    break;

                case "Nakov":
                    nakov = true;
                    break;

            }
            


            while (Spoints < 500 || Npoints < 500)
            {
                if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                {
                    break;
                }
                if (Spoints > 500)
                {
                    Spoints = 500;
                    break;
                }
                if (Npoints > 500)
                {
                    Npoints = 500;
                    break;
                }

                

                    if (nakov == true)
                    {
                        NakovInput();
                    }
                    else
                    {
                        SimoInput();
                    }

   
            }

            
              if (Spoints == Npoints)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(Spoints);
            }
            else if (Npoints > Spoints)
            {
                Npoints -= Spoints;
                Console.WriteLine("Nakov");
                Console.WriteLine(roundsPlayedN);
                Console.WriteLine(Spoints);

            }
            else if (Spoints > Npoints)
            {
                Spoints -= Npoints;
                Console.WriteLine("Simeon");
                Console.WriteLine(roundsPlayedS);
                Console.WriteLine(Npoints);
            }
           
        }

        public static int SimoInput()
        {
            simoPoints = int.Parse(Console.ReadLine());
            secondInput = Console.ReadLine();
            switch (secondInput)
            {

                case "fail":
                    roundsPlayedS++;
                    simoPoints = int.Parse(Console.ReadLine());
                    secondInput = Console.ReadLine();
                    
                    if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                    {
                        return Spoints ;
                    }
                    while (secondInput != "success")
                    {
                        simoPoints = int.Parse(Console.ReadLine());
                        secondInput = Console.ReadLine();
                        roundsPlayedS++;
                        if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                        {
                            return Spoints ;
                        }
                    }
                    if (secondInput == "success")
                    {
                        simoPointsResult += simoPoints;
                        roundsPlayedS++;
                        if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                        {
                            return Spoints ;
                        }
                        nakov = true;
                        simo = false;
                    }
                    break;
                case "success":
                    simoPointsResult += simoPoints;
                    roundsPlayedS++;
                    nakov = true;
                    simo = false;
                    break;

            }
            return Spoints+=simoPointsResult;
        }

        public static int NakovInput()
        {
            nakovPoints = int.Parse(Console.ReadLine());
            secondInput = Console.ReadLine();
            switch (secondInput)
            {
                case "fail":
                    roundsPlayedN++;
                    nakovPoints = int.Parse(Console.ReadLine());
                    secondInput = Console.ReadLine();
                    if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                    {
                        return Npoints+=nakovPoints;
                    }
                    while (secondInput != "success")
                    {
                       nakovPoints= int.Parse(Console.ReadLine());
                        secondInput = Console.ReadLine();
                        roundsPlayedN++;
                        if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                        {
                            return Npoints ;
                        }
                        
                    }
                    if (secondInput == "success")
                    {
                        nakovPointsResult += nakovPoints;
                        roundsPlayedN++;
                        if (roundsPlayedN >= rounds || roundsPlayedS >= rounds)
                        {
                            return Npoints ;
                        }
                        simo = true;
                        nakov = false;
                    }
                    break;
                case "success":
                    nakovPointsResult += nakovPoints;
                    roundsPlayedN++;
                    simo = true;
                    nakov = false;
                    break;
            }
            return Npoints+=nakovPointsResult;

        }
    }
}
