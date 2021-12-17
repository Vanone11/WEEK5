using System;

namespace week5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will skateboard in the halls.

            string message = "I will not skateboard in the halls.".ToUpper();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}.I will skateboard in the halls.".ToUpper());
            }
        }
    }
}
