using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen:ChessPiece
    {
        public Queen()
        {
            Moves();
        }
        public Queen(int player)
        {
            base.Player = player;
            Moves();
        }
        public override ChessPiece Moves()
        {
            availableMoves = new Point[8][];
            availableMoves[0] = GetMovementArray(Max_Distance, Direction.Forward);
            availableMoves[1] = GetMovementArray(Max_Distance, Direction.Backward);
            availableMoves[2] = GetMovementArray(Max_Distance, Direction.Left);
            availableMoves[3] = GetMovementArray(Max_Distance, Direction.Right);

            availableMoves[4] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Forward_Left);
            availableMoves[5] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Forward_Right);
            availableMoves[6] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Backward_Left);
            availableMoves[7] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Backward_Right);
            availableAttacks = availableMoves;
           
            return this;
        }
    }
}
