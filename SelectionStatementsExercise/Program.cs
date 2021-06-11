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

            string guess = (Console.ReadLine());

            do
            {
                if (Convert.ToInt32(guess) >= 1000)
                {
                    Console.WriteLine("Way too high!!");
                    Console.WriteLine("Consider typing 'help' to get a hint.");
                }
                else if (Convert.ToInt32(guess) >= 12)
                {
                    Console.WriteLine("Try reducing your number!");
                }
                else if (Convert.ToInt32(guess) <= 11 && Convert.ToInt32(guess) >= 9)
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
                else if (guess == "help")
                {
                    Console.WriteLine("Lower than 50, but higher than 5.");
                }
                else
                {
                    Console.WriteLine("Excellent! You guessed my favorite number!!");
                    break;
                }

                Console.WriteLine("Enter your next guess again:");
                guess = (Console.ReadLine());
            }
            while (Convert.ToInt32(guess) != 8);
            Console.WriteLine("Excellent! You guessed my favorite number!!");
            
            
           





        }
    }
}
