using System;

namespace Week5._2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Something wrong! TRY AGAIN!.");
            }
            else
            {
                Console.WriteLine("GET IN!");
            }
        }
    }
}
