using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* My favorite number */

            Console.WriteLine("Try to guess my favorite number.");
            Console.WriteLine("Enter your first guess to begin.");

            string guess = Console.ReadLine();
            var myNum = 8;
            string statement = "help";

            do
            {
                if (guess == statement)
                {
                    Console.WriteLine("Lower than 50, but higher than 5.");
                }
                else if (Convert.ToInt32(guess) >= 1000)
                {
                    Console.WriteLine("Way too high!!");
                    Console.WriteLine("Consider typing 'help' to get a hint.");
                }
                else if (Convert.ToInt32(guess) >= 13)
                {
                    Console.WriteLine("Try reducing your number!");
                }
                else if (Convert.ToInt32(guess) <= 12 && Convert.ToInt32(guess) >= 9)
                {
                    Console.WriteLine("You are really close! A little lower.");
                }
                else if (Convert.ToInt32(guess) <= 7 && Convert.ToInt32(guess) >= 4)
                {
                    Console.WriteLine("You are really close! A little higher.");
                }
                else if (Convert.ToInt32(guess) <= 3)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Excellent! You guessed my favorite number!!");
                    break;
                }

                Console.WriteLine("Enter your next guess:");
                guess = Console.ReadLine();

                switch (guess)
                {
                    case "help":
                        break;
                    case "8":
                        Console.WriteLine("Excellent! You guessed my favorite number!!");
                        break;
                }
            }
            while (guess == statement || Convert.ToInt32(guess) != myNum);


            /* Computer generated random number picker*/ 

            var num = new Random();
            var systemNumber = num.Next(1, 50);
            int userInput;

            do
            {
                Console.WriteLine("Pick a number between 1 and 50?");
                userInput = int.Parse(Console.ReadLine());

                if (userInput > systemNumber)
                {
                    Console.WriteLine("Your number is too high!");
                }
                else if (userInput < systemNumber)
                {
                    Console.WriteLine("Your number is too low!");
                }
                else
                {
                    Console.WriteLine("Your number is correct!!");
                }
            }
            while (userInput != systemNumber);




        }
    }
}
