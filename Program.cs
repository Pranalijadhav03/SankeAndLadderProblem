// See https://aka.ms/new-console-template for more information
using SankeAndLadder;
using SnakeAndLadder;
using SnakeAnLladder;

    //static void Main(String[] args)
    {
        Console.WriteLine("Sanke and Ladder  Game");
        SnakeGameUC1.Player();
        SnakeGameUC2.RollDice();
        SnakeGameUC3 game = new SnakeGameUC3();
        game.gamestart();
       SnakeGameUC5.ExactWinningPosition();
    }
