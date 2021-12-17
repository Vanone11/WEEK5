using System;

namespace week5._8
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();

            for (int i = 0; i < 3; i++)

            {


                int cpuRandom = rnd.Next(1, 7);

                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"CPU {cpuRandom}. PLAYER {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("PLAYER WON. GOOD BOY!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("CPU WON.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("------!");
                }

                Console.WriteLine($"CPU SCORE:{cpuScore} and PLAYER SCORE:{userScore}");


            }
        }
    }
}

