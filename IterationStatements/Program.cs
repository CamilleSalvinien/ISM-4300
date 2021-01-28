using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 100:");

            try
            {
                string input = Console.ReadLine();

                int numbOfLoop = int.Parse(input);

                if ((numbOfLoop >= 1) && (numbOfLoop <= 100))
                {
                    for (int i = 1; i <= numbOfLoop; i++)
                    {
                        Console.WriteLine("You have entered " + numbOfLoop + "." + " This is the current integer value in the loop: " + i.ToString());
                    }

                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100.");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);
                }
                       
            }

            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100.");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);

            }

        }
    }
}
