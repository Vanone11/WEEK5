using System;

namespace Week5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("Enter Username");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string userPassword = Console.ReadLine();
                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("GET IN!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Something wrong, {3 - i} attempts more");
                }
            }
        }
    }
}
