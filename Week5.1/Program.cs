using System;

namespace Week5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("User name");
            string userName = Console.ReadLine();
            Console.WriteLine("Password");
            string userPassword = Console.ReadLine();

           

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Get In!");
            }
            else
            {
                Console.WriteLine("Something wrong. TRY AGAIN.");
            }

        }
    }
}
