using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : ChessPiece
    {
        public Pawn()
        {
            this.canDoubleJump = true;
            Moves();
        }
        public Pawn(int player)
        {
            base.Player = player;
            this.canDoubleJump = true;
            Moves();
        }
        public Pawn(int player = 0, bool doubleJump = true, bool enPassantLeft = false, bool enPassantRight = false)
        {
            base.Player = player;
            this.canDoubleJump = doubleJump;
            this.canEnPassantLeft= enPassantLeft;
            this.canEnPassantRight= enPassantRight;
            Moves();
        }

        public override ChessPiece Moves()
        {
            Direction forward;
            DiagnalDirection forwardLeft, forwardRight;
            if (base.Player==1)
            {
                forward = Direction.Backward;
                forwardLeft = DiagnalDirection.Backward_Left;
                forwardRight = DiagnalDirection.Backward_Right;
            }
            else
            {
                forward = Direction.Forward;
                forwardLeft = DiagnalDirection.Forward_Left;
                forwardRight = DiagnalDirection.Forward_Right;
            }
            availableMoves = new Point[1][];
            if (this.canDoubleJump)
            {
                availableMoves[0] = GetMovementArray(2, forward);
            }
            else
            {
                availableMoves[0] = GetMovementArray(1, forward);
            }
            availableAttacks = new Point[2][];
            availableAttacks[0] = GetDiagnalMovementArray(1, forwardLeft);
            availableAttacks[1] = GetDiagnalMovementArray(1, forwardRight);
            return this;
        }
        public bool CanDoubleJump
        {
            get
            {
                return this.canDoubleJump;
            }
            set
            {
                this.canDoubleJump = value;
            }
        }
        public bool CanEnPassantLeft
        {
            get
            {
                return this.canEnPassantLeft;
            }
            set
            {
                this.canEnPassantLeft = value;
            }
        }
        public bool CanEnPassantRight
        {
            get
            {
                return this.canEnPassantRight;
            }
            set
            {
                this.canEnPassantRight = value;
            }
        }
    }
}
