using System;

class Program
{
    static void Main()
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 

        Console.WriteLine("Guess My Number game!");
        Console.WriteLine("Think  of a number between 1 and 100...");

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();

            
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Enter a valid number.");
                continue;
            }

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
