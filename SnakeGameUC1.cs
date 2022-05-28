// Snake and Ladder game played with single player at start position 0 & with single player at start position

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeGameUC1
    {
        public static void Player()
        {
            Console.WriteLine("Lets begin the game");
            int player_position = 0;
            Random rm2 = new Random();
            int playerMove = rm2.Next(1, 7);
            Console.WriteLine("Number of player On GAME: Single Player");
            Console.WriteLine("player_position: {0}", player_position);
            Console.ReadKey();
        }

    }
}
