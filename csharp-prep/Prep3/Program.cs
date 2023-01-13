using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 10);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("you guessed it!");
            }
        }
    }
}