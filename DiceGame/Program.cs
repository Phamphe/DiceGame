using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace DiceGame
{
    class Dice
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int oppRandomNum;
            int playerPoints = 0;
            int oppPoints = 0;

            Random random = new Random();
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Press any Key to roll the dice!...");
                    Console.ReadKey();
                    playerRandomNum = random.Next(1, 7);
                    Console.WriteLine("Player rolled a " + playerRandomNum);


                    Console.WriteLine(".......");
                    System.Threading.Thread.Sleep(1000);

                    oppRandomNum = random.Next(1, 7);
                    Console.WriteLine("Opponent rolled a " + oppRandomNum);

                    if (playerRandomNum > oppRandomNum)
                    {
                        playerPoints++;
                        Console.WriteLine("Player has won this round");
                    }
                    else if (playerRandomNum < oppRandomNum)
                    {
                        oppPoints++;
                        Console.WriteLine("Opponent has won this round");
                    }
                    else
                    {
                        Console.WriteLine("DRAW!!! ");
                    }

                    Console.WriteLine("The score is now player : " + playerPoints + "  and opponent : " + oppPoints);
                }

                if (oppPoints > playerPoints)
                {
                    Console.WriteLine("You lost!!!");
                }
                else if (playerPoints > oppPoints)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("It ended up as a draw");
                }

                Console.WriteLine("Do you want to play again?...[Y] or [N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }

        }
    }
}
