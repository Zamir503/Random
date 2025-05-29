using System;
class Game
{
    static void Main(string[] args)
    {
        Console.WriteLine("Random by Chill-Astro : Welcome to the Number Guessing Game!\n");
        Console.WriteLine("Try to Guess the Number in 5 tries!\n");
        int noOfTries = 5; // Number of tries allowed
        for (int i = 1; i <= 5; i++)
        {
            int randNum = new Random().Next(1, 6); // Generates a random number between 1 and 5
            Console.Write("Enter a number [ 1 - 5 ] : ");
            int inNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            if (inNum < 1 || inNum > 5)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.\n");
            }
            else if (inNum == randNum)
            {
                Console.WriteLine("Congratulations! You guessed it right!");
                if ((5 - noOfTries) == 0)
                {
                    Console.WriteLine("You guessed it in the first try! \n");
                }
                else
                {
                    Console.WriteLine("You guessed it in " + (6 - noOfTries) + " tries! \n");
                }
                break;
            }
            else if (noOfTries == 0)
            {
                Console.WriteLine("You have used all your tries. Game Over!\nThe number was : " + randNum + ".\n");
                break;
            }
            else if (inNum < randNum)
            {
                Console.WriteLine("Your guess is too low!");
                noOfTries--;
                Console.WriteLine("You have " + noOfTries + " tries left.\n");
            }
            else if (inNum > randNum)
            {
                Console.WriteLine("Your guess is too high!");
                noOfTries--;
                Console.WriteLine("You have " + noOfTries + " tries left.\n");
            }            
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
            }
        }
        Console.Write("Thank's for playing! Press Enter to exit. ");
        string exit = Console.ReadLine();
        Console.WriteLine();
    }
}
