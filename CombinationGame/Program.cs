using System;

namespace CombinationGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the Combination Game \n \n Instructions: \n Guess The 4 Digit Number Answer");
            Console.WriteLine(" You Have 10 Tries \n If A Number Is Correct AND In the Correct Position In The Sequence a + Will Appear" +
                " \n If A Number Is Correct AND In the WRONG Position In The Sequence a - Will Appear" +
                "\n If A Number Is INCORRECT The Hint Will Be BLANK \n Good Luck!");


            bool inAction = true;
            int attempts = 1;

            Random Random = new Random();
            int rand = Random.Next(1, 6);
            int randOne = Random.Next(1, 6);
            int randTwo = Random.Next(1, 6);
            int randThree = Random.Next(1, 6);
            Console.WriteLine($"\n (Random 4 digit answer is {rand}{randOne}{randTwo}{randThree})");


            while (inAction)
            {
                while (attempts < 11)
                {
                    Console.WriteLine("\n This Is Attempt Number: {0}", attempts);
                    Console.WriteLine(" What Is The First Digit of The Combination? Enter A Number 1-6:");
                    string combinationGuessOne = Console.ReadLine();
                    int combinationGuessOneInt = Convert.ToInt32(combinationGuessOne);

                    Console.WriteLine(" What Is The Second Digit of The Combination? Enter A Number 1-6:");
                    string combinationGuessTwo = Console.ReadLine();
                    int combinationGuessTwoInt = Convert.ToInt32(combinationGuessTwo);

                    Console.WriteLine(" What Is The Third Digit of The Combination? Enter A Number 1-6:");
                    string combinationGuessThree = Console.ReadLine();
                    int combinationGuessThreeInt = Convert.ToInt32(combinationGuessThree);

                    Console.WriteLine(" What Is The Final Digit of The Combination? Enter A Number 1-6:");
                    string combinationGuessFour = Console.ReadLine();
                    int combinationGuessFourInt = Convert.ToInt32(combinationGuessFour);

                    if (combinationGuessOneInt == rand)
                    {
                        Console.WriteLine(" Digit One In The Combination Is :   +   ");
                    }

                    else if (combinationGuessOneInt == randOne)
                    {
                        Console.WriteLine(" Digit One In The Combination Is :   -  ");
                    }
                    else if (combinationGuessOneInt == randTwo)
                    {
                        Console.WriteLine(" Digit One In The Combination Is :   -  ");
                    }
                    else if (combinationGuessOneInt == randThree)
                    {
                        Console.WriteLine(" Digit One In The Combination Is :   -  ");
                    }
                    else
                    {
                        Console.WriteLine(" Digit One In The Combination Is :     ");
                    }


                    if (combinationGuessTwoInt == randOne)
                    {
                        Console.WriteLine(" Digit Two In The Combination Is :   +   ");
                    }

                    else if (combinationGuessTwoInt == randOne)
                    {
                        Console.WriteLine(" Digit Two In The Combination Is :   -  ");
                    }
                    else if (combinationGuessTwoInt == randTwo)
                    {
                        Console.WriteLine(" Digit Two In The Combination Is :   -  ");
                    }
                    else if (combinationGuessTwoInt == randThree)
                    {
                        Console.WriteLine(" Digit Two In The Combination Is :   -  ");
                    }
                    else
                    {
                        Console.WriteLine(" Digit Two In The Combination Is :     ");
                    }


                    if (combinationGuessThreeInt == randTwo)
                    {
                        Console.WriteLine(" Digit Three In The Combination Is :   +   ");
                    }
                    else if (combinationGuessThreeInt == randOne)
                    {
                        Console.WriteLine(" Digit Three In The Combination Is :   -  ");
                    }
                    else if (combinationGuessThreeInt == randTwo)
                    {
                        Console.WriteLine(" Digit Three In The Combination Is :   -  ");
                    }
                    else if (combinationGuessThreeInt == randThree)
                    {
                        Console.WriteLine(" Digit Three In The Combination Is :   -  ");
                    }
                    else
                    {
                        Console.WriteLine(" Digit Three In The Combination Is :     ");
                    }


                    if (combinationGuessFourInt == randThree)
                    {
                        Console.WriteLine(" Digit Four In The Combination Is :   +   ");
                    }
                    else if (combinationGuessFourInt == randOne)
                    {
                        Console.WriteLine(" Digit Four In The Combination Is :   -  ");
                    }
                    else if (combinationGuessFourInt == randTwo)
                    {
                        Console.WriteLine(" Digit Four In The Combination Is :   -  ");
                    }
                    else if (combinationGuessFourInt == randThree)
                    {
                        Console.WriteLine(" Digit Four In The Combination Is :   -  ");
                    }
                    else
                    {
                        Console.WriteLine(" Digit Four In The Combination Is :     ");
                    }


                    if (combinationGuessOneInt == rand && combinationGuessTwoInt == randOne && combinationGuessThreeInt == randTwo && combinationGuessFourInt == randThree)
                    {
                        Console.WriteLine(" You Win! ");
                        Console.ReadKey();
                    }
                    else
                    {

                        if (attempts == 10)
                        {
                            Console.WriteLine(" You Loose! ");
                        }
                        else
                        {
                            Console.WriteLine(" Try Again! ");
                            //Console.ReadKey();
                            //Console.Clear();
                        }

                    }
                    attempts++;

                }

                if (attempts > 11)
                    break;


            }

        }
    }
}