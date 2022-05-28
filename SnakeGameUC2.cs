using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLadder
{
    internal class SnakeGameUC2
    {
        public static void RollDice()
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");
            Random random = new Random();
            int rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is :" + rollDice);
            Console.ReadLine();
        }
    }
}


