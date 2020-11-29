using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chess
{
    class Knight:ChessPiece
    {
        public Knight()
        {
            Moves();
        }
        public Knight(int player)
        {
            base.Player = player;
            Moves();
        }
        public override ChessPiece Moves()
        {
            availableMoves = new Point[8][] 
            {
                new[] { new Point(1, 2) },      new[] {new Point(2, 1)},
                new[] { new Point(-1, -2) },    new[] {new Point(-2, -1)},
                new[] { new Point(-1, 2) },     new[] {new Point(-2, 1)},
                new[] { new Point(1, -2) },     new[] {new Point(2, -1)},
            };
            availableAttacks = availableMoves;
            return this;
        }
    }
}
