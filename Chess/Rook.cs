using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook:CastlePiece
    {
        public Rook()
        {
            this.canCastle = true;
            Moves();
        }
        public Rook(bool castle)
        {
            this.canCastle = castle;
            Moves();
        }
        public Rook(bool castle,int player =0)
        {
            base.Player = player;
            this.canCastle = castle;
            Moves();
        }
        public Rook(int player)
        {
            base.Player = player;
            this.canCastle = true;
            Moves();
        }
        public override ChessPiece Moves()
        {
            availableMoves = new Point[4][];
            availableMoves[0] = GetMovementArray(Max_Distance, Direction.Forward);
            availableMoves[1] = GetMovementArray(Max_Distance, Direction.Backward);
            availableMoves[2] = GetMovementArray(Max_Distance, Direction.Left);
            availableMoves[3] = GetMovementArray(Max_Distance, Direction.Right);
            availableAttacks = availableMoves;
            return this;
        }
    }
}
