
using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Is higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Is lower");
            }
            else
            {
                Console.WriteLine("You guessed it!!");
            }
        }
    }
}