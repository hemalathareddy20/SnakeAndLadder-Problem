using System;

namespace SnakeAndLadder
{
    class Program
    {
        int START_POSITION = 0;
        int PLAYER = 1;
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome to Sanke and Ladder program");
            int diceNum = rollingDice();
            Console.WriteLine(" diceNum: " + diceNum); 
            int rollingDice()
            {
                int diceNum = random.Next(1,7);
                return diceNum;
            }

        }
    }
}
