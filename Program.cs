using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Get app info
            GetAppInfo();

            // Greet user
            GreetUser();

            while(true)
            {
                // Init correct number

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure valid input
                    if (!int.TryParse(input, out guess))
                    {
                        // Match guess to correct number
                        if (guess != correctNumber)
                        {
                            // Print error message
                            PrintColorMessage(ConsoleColor.Red, "Please enter a valid number!");
                            continue;
                        }
                    }

                    // Cast to int and set guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                } 
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            

        }

        //Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "C# .Net Practice: Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Leo Belanger";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Get and display app info
        static void GreetUser()
        {
            // Ask user for name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }


        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text to red
            Console.ForegroundColor = color;

            // Tell user they chose wrong
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
