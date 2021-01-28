using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the expected grade:");

            try
            {
                string input = Console.ReadLine();

                decimal grade = decimal.Parse(input);

                if (grade >= 98 )
                {
                    Console.WriteLine("Your grade will be an A+.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 92 )
                {
                    Console.WriteLine("Your grade will be an A.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 90)
                {
                    Console.WriteLine("Your grade will be an A-.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 88)
                {
                    Console.WriteLine("Your grade will be an B+.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 82)
                {
                    Console.WriteLine("Your grade will be an B.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 80)
                {
                    Console.WriteLine("Your grade will be an B-.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 78)
                {
                    Console.WriteLine("Your grade will be an C+.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 72)
                {
                    Console.WriteLine("Your grade will be an C.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 70)
                {
                    Console.WriteLine("Your grade will be an C-.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 68)
                {
                    Console.WriteLine("Your grade will be an D+.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 62)
                {
                    Console.WriteLine("Your grade will be an D.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 60)
                {
                    Console.WriteLine("Your grade will be an D-.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Your grade will be an F.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Please use an integer data type for your grade next time.");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }
        }
    }
}
