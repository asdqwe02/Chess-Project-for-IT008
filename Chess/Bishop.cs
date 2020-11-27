using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chess
{
    class Bishop:ChessPiece
    {
        public Bishop()
        {
            Moves();
        }
        public Bishop(int player)
        {
            base.Player = player;
            Moves();
        }
        public override ChessPiece Moves()
        {
            availableMoves = new Point[4][];
            availableMoves[0] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Forward_Left);
            availableMoves[1] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Forward_Right);
            availableMoves[2] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Backward_Left);
            availableMoves[3] = GetDiagnalMovementArray(Max_Distance, DiagnalDirection.Backward_Right);
            availableAttacks = availableMoves;
            return this;

        }
    }
}
