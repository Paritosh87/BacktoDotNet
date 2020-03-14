using System;
using System.Collections.Generic;
using System.Text;

namespace TikTacToe
{
    class Game
    {
        private Square[][] _board =
        {
            new Square[3],
            new Square[3],
            new Square[3]
        };
        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_board[i][j]);
                }
                Console.WriteLine("");
            }
        }

        public void PlayGame()
        {
            Player player = Player.Tik;
            bool @continue = true;

            while (@continue)
            {
                DisplayBoard();
                @continue = PlayMove(player);
                player = 3 - player;

            }
        }

        private bool PlayMove(Player player)
        {
            var userInput = Console.ReadLine();
            var uservalues = userInput.Split(',');
            if (uservalues.Length <= 0) return false;

            int.TryParse(uservalues[0], out int row);
            int.TryParse(uservalues[1], out int column);

            if (_board[row][column].Owner != Player.Empty)
            {
                Console.WriteLine("Input is already selected..quitting the game");
                return false;
            }

            _board[row - 1][column - 1] = new Square(player);
            return true;

        }
    }
}
