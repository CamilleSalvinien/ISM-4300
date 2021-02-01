using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi! What is your name?");

            try
            {
                string userName = Console.ReadLine();
                nameOutput(userName);
            }

            catch
            {
                Console.WriteLine("You must enter your name.");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }
        }

        private static void nameOutput(string userName)
            {

            Console.WriteLine("Hello" + userName + " !");

            }
    }
}
