using System;
using System.Collections.Generic;
using System.Text;

namespace TikTacToe
{
    public enum Player { Empty, Tik, Tac};
    struct Square
    {
        public Player Owner;
        public Square(Player player)
        {
            this.Owner = player;
        }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.Empty:
                    return ".";
                case Player.Tik: return "X";
                case Player.Tac: return "O";
                default:
                    throw new Exception("Invalid state");
            }
        }
    }
}
