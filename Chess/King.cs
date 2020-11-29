using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King:CastlePiece
    {
        public King()
        {
            this.canCastle = true;
            Moves();
        }
        public King(int player)
        {
            base.Player = player;
            this.canCastle = true;
            Moves();
        }
        public King(bool castle)
        {
            this.canCastle = castle;
            Moves();
        }
        public override ChessPiece Moves()
        {
            availableMoves = new Point[8][];
            availableMoves[0] = GetMovementArray(1, Direction.Forward);
            availableMoves[1] = GetMovementArray(1, Direction.Backward);
            availableMoves[2] = GetMovementArray(1, Direction.Left);
            availableMoves[3] = GetMovementArray(1, Direction.Right);

            availableMoves[4] = GetDiagnalMovementArray(1, DiagnalDirection.Forward_Left);
            availableMoves[5] = GetDiagnalMovementArray(1, DiagnalDirection.Forward_Right);
            availableMoves[6] = GetDiagnalMovementArray(1, DiagnalDirection.Backward_Left);
            availableMoves[7] = GetDiagnalMovementArray(1, DiagnalDirection.Backward_Right);

            availableAttacks =new  Point[8][];
            Array.Copy(availableMoves, 0, availableAttacks, 0, 8);
            return this;
        }
        
    }
}
