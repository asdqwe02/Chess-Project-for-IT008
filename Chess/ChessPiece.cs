using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chess
{
    //Enum and Point Struct
    public enum Direction
    {
        Forward,
        Backward,
        Left,
        Right
    }
    public enum DiagnalDirection
    {
        Forward_Left,
        Forward_Right,
        Backward_Left,
        Backward_Right
    }

    public struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return (String.Format("({0}, {1})", x, y));
        }
    }
    public abstract class ChessPiece
    {
        protected const int Max_Distance= 7;

        //Pawn fields
        protected bool canEnPassantLeft;
        protected bool canEnPassantRight;
        protected bool canDoubleJump;

        //Other fields
        protected bool canCastle; //Rooks and King
        protected Point[][] availableMoves;
        protected Point[][] availableAttacks;
        private int player;

      
        public Point[][] AvailableMoves
        {
            get { return availableMoves; }
        }

        public Point[][] AvailableAttacks
        {
            get { return availableAttacks; }
        }

        public int Player
        {
            get { return player; }
            set { player = value; }
        }

        public abstract ChessPiece Moves();

        //use by King, Queen, Pawn, Rook
        public static Point[] GetMovementArray(int distance, Direction direction)
        {
            Point[] movement = new Point[distance];
            int xPosition = 0;
            int yPosition = 0;

            for (int i = 0; i < distance; i++)
            {
                switch (direction)
                {
                    case Direction.Forward:
                        yPosition++;
                        break;
                    case Direction.Backward:
                        yPosition--;
                        break;
                    case Direction.Left:
                        xPosition++;
                        break;
                    case Direction.Right:
                        xPosition--;
                        break;
                    default:
                        break;
                }
                movement[i] = new Point(xPosition, yPosition);
            }
            return movement;
        }

        //use by King, Queen, Bishop, possibly pawn
        public static Point[] GetDiagnalMovementArray(int distance, DiagnalDirection direction)
        {
            Point[] attack = new Point[distance];
            int xPosition = 0;
            int yPosition = 0;

            for (int i = 0; i < distance; i++)
            {
                switch (direction)
                {
                    case DiagnalDirection.Forward_Left:
                        xPosition--;
                        yPosition++;
                        break;
                    case DiagnalDirection.Forward_Right:
                        xPosition++;
                        yPosition++;
                        break;
                    case DiagnalDirection.Backward_Left:
                        xPosition--;
                        yPosition--;
                        break;
                    case DiagnalDirection.Backward_Right:
                        xPosition++;
                        yPosition--;
                        break;
                    default:
                        break;
                }
                attack[i] = new Point(xPosition, yPosition);
            }
            return attack;
        }

    }

}
