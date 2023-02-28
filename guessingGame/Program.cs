using System;
namespace classes
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please type the difficulty level you want. 'Easy', 'Medium', 'Hard', 'Cheater'");
            string difficulty = Console.ReadLine().ToLower();
            int maxIntValue = int.MaxValue;
            int guessAllowance = 0;
            if (difficulty == "easy")
            {
                guessAllowance = 8;
                Console.WriteLine("Please guess the magic sacred number!");
            }
            else if (difficulty == "medium")
            {
                guessAllowance = 6;
                Console.WriteLine("Please guess the magic sacred number!");
            }
            else if (difficulty == "hard")
            {
                guessAllowance = 4;
                Console.WriteLine("Please guess the magic sacred number!");
            }
            else if (difficulty == "cheater")
            {
                guessAllowance = maxIntValue;
                Console.WriteLine($"You have {guessAllowance} tries. Please guess the magic sacred number!");
            }
            

            Random r = new Random();
           
            int secretAnswer = r.Next(1,100);
            int userTries = 0;

            while (userTries < guessAllowance)
            {
                int answer = int.Parse(Console.ReadLine());
                    userTries++;
                if (answer == secretAnswer)
                {
                    Console.WriteLine("Success!");
                    break;
                }
                else if (userTries < guessAllowance )
                {
                    int remainingGuesses = guessAllowance - userTries;
                    if (answer > secretAnswer)
                    {
                        Console.WriteLine("failure. Your guess was HIGHER than the secret number. Try again.");
                    }
                    else 
                    {
                        Console.WriteLine("failure. Your guess was LOWER than the secret number. Try again.");
                    }
                    Console.WriteLine($"current guess: {userTries}, you have {remainingGuesses} tries left.");
                    
                }
                else
                {
                    Console.WriteLine("Failure. You're out of guesses.");
                }

            }
        }
    }
}
