using System;

namespace CombinationGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Combination Game");

            bool inAction = true;
            int attempts = 1;

            Random Random = new Random();
            int rand = Random.Next(1, 6);
            int randOne = Random.Next(1, 6);
            int randTwo = Random.Next(1, 6);
            int randThree = Random.Next(1, 6);
            Console.WriteLine($"Random 4 digit answer is {rand}{randOne}{randTwo}{randThree}");


            while (inAction)
            {
                while (attempts < 11)
                {
                    Console.WriteLine("This Is Attempt Number: {0}", attempts);
                    Console.WriteLine("What Is Your Guess");
                    attempts++;
                }

                if (attempts > 11)
                    Console.WriteLine("You Lose");
                //break;
            }
            
        }
    
    }
}
