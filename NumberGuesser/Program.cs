using System;

namespace NumberGuesser
{
    class Program
    {

        static void GetAppInfo()
        {
            // Setting App Details
            string appName = "Number Guesser";
            string appVersion = "1.1.0.0";
            string appAuthor = "Musthafa CP";

            //Change the text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Display the app Details
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset the text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Asks user Name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Lets play a game...", userName);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change the text color
            Console.ForegroundColor = color;

            // Display the message
            Console.WriteLine(message);

            // Reset the text color
            Console.ResetColor();
        }

        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Set correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init guess
                int guess = 0;

                // ask user for guessing number 
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //make sure the input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please try again by using a number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "Correct! The number was "+ correctNumber.ToString());

                // ask to play again
                Console.WriteLine("Play again? (Y or N)");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}