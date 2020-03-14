using System;

namespace TikTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("Let's start the game!");
            Console.WriteLine("Enter row,column to select the empty slots. Game quits if an incorrect value is entered");
            game.PlayGame();
        }
    }
}
