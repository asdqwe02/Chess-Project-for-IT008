using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chess
{
    public class ChessBoard
    {
        private ChessPiece[,] Board;
        private const int Columns = 8;
        private const int Rows = 8;
        public ChessBoard()
        {
            setupBoard();
        }
        public int GetLength(int l)
        {
            return Board.GetLength(l);
        }
        public ChessPiece this[int x, int y]
        {
            get { return Board[x, y]; }
        }
        private ChessBoard setupBoard()
        {
            Board = new ChessPiece[Columns, Rows];
            string[] PlayerPieces =
            {
                "Rook","Knight","Bishop","Queen","King","Bishop","Knight","Rook",
                "Pawn","Pawn","Pawn","Pawn","Pawn","Pawn","Pawn","Pawn"
            };
            for (int i = 0; i < Columns; i++)
            {
                //player 0 pieces
                Board[i, 0] = (ChessPiece)Activator.CreateInstance(Type.GetType("Chess." + PlayerPieces[i]));
                Board[i, 1] = (ChessPiece)Activator.CreateInstance(Type.GetType("Chess." + PlayerPieces[Columns + i]));

                //player 1 pieces
                Board[i, Rows - 1] = (ChessPiece)Activator.CreateInstance(Type.GetType("Chess." + PlayerPieces[i]), new object[] { 1});
                Board[i, Rows - 2] = (ChessPiece)Activator.CreateInstance(Type.GetType("Chess." + PlayerPieces[Columns + i]),new object[] { 1});
            }
            return this;
        }
        public bool CheckSquareVulnerable(int squareX, int squareY, int player, ChessPiece[,] board = null)
        {
            if (board == null)
            {
                board = this.Board;
            }

            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] != null && board[x, y].Player != player)
                    {
                        foreach (Point point in PieceActions(x, y, true, true, false, board))
                        {
                            if (point.x == squareX && point.y == squareY)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool KingInCheck(int player)
        {
            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    ChessPiece chessPiece = Board[x, y];
                    if (chessPiece != null  && chessPiece.Player == player && chessPiece is King)
                    {
                        if (CheckSquareVulnerable(x, y, player))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            throw new Exception("King wasn't found!");
        }
        private void AddMove(List<Point> availableActions, Point fromPoint, Point toPoint, bool ignoreCheck = false)
        {
            bool kingInCheck = false;

            if (!ignoreCheck)
            {
                ChessPiece movingPiece = Board[fromPoint.x, fromPoint.y];
                ChessPiece[,] BoardBackup = (ChessPiece[,])Board.Clone();
                ActionPiece(fromPoint, toPoint, true);
                kingInCheck = KingInCheck(movingPiece.Player);
                Board = BoardBackup;
            }

            if (ignoreCheck || !kingInCheck) availableActions.Add(toPoint);
        }
        public IEnumerable<Point> PieceActions(int x, int y, bool ignoreCheck = false, bool attackActions = true, bool moveActions = true, ChessPiece[,] board = null)
        {
            if (board == null)
                board = this.Board;
            bool[,] legalActions = new bool[board.GetLength(0), board.GetLength(1)];
            List<Point> availableActions = new List<Point>();
            ChessPiece movingPiece = board[x, y];
            if (attackActions)
                foreach (Point[] direction in movingPiece.AvailableAttacks)
                {
                    foreach (Point attackPoint in direction)
                    {
                        Point adjustedPoint = new Point(attackPoint.x + x, attackPoint.y + y);
                        if (ValidatePoint(adjustedPoint))
                        {
                            if (board[adjustedPoint.x, adjustedPoint.y] != null
                                && board[adjustedPoint.x, adjustedPoint.y].Player == movingPiece.Player)
                                break;
                            if (board[adjustedPoint.x, adjustedPoint.y] != null)
                            {
                                AddMove(availableActions, new Point(x, y), adjustedPoint, ignoreCheck);
                                break;
                            }
                        }
                    }
                }
            if (moveActions)
            {
                foreach (Point[] direction in movingPiece.AvailableMoves)
                {
                    foreach (Point movePoint in direction)
                    {
                        Point adjustedPoint = new Point(movePoint.x + x, movePoint.y + y);
                        if (ValidatePoint(adjustedPoint))
                        {
                            if (board[adjustedPoint.x, adjustedPoint.y] != null) break;
                            AddMove(availableActions, new Point(x, y), adjustedPoint, ignoreCheck);
                        }
                    }
                }
            }

            // TODO: reREAD this block of code
            if (movingPiece is King && ((King)movingPiece).CanCastle)
            {
                int rookX = 0;
                if (board[rookX, y] is Rook && ((Rook)board[rookX, y]).CanCastle)
                {
                    bool missedCondition = false;
                    foreach (int rangeX in Enumerable.Range(rookX + 1, Math.Abs(rookX - x) - 1))
                    {
                        if (board[rangeX, y] != null)
                            missedCondition = true;
                        // TODO: Validate that the king won't move through check
                    }
                    // TODO: Validate that king isn't currently in check
                    missedCondition = missedCondition || KingInCheck((movingPiece.Player));
                    if (!missedCondition)
                        AddMove(availableActions, new Point(x, y), new Point(x - 2, y), ignoreCheck);
                }
                rookX = Columns - 1;
                if (board[rookX, y] is Rook && ((Rook)board[rookX, y]).CanCastle)
                {
                    bool missedCondition = false;
                    foreach (int rangeX in Enumerable.Range(x + 1, Math.Abs(rookX - x) - 1))
                    {
                        if (board[rangeX, y] != null) missedCondition = true;
                        // TODO: Validate that the king won't move through check
                    }
                    // TODO: Validate that king isn't currently in check
                    missedCondition = missedCondition || KingInCheck(movingPiece.Player);
                    if (!missedCondition)
                        AddMove(availableActions, new Point(x, y), new Point(x + 2, y), ignoreCheck);
                }
            }

            // TODO: might not implement this 
            if (movingPiece is Pawn)
            {
                Pawn pawn = (Pawn)movingPiece;
                int flipDirection = 1;

                if (pawn.Player == 1) flipDirection = -1;
                if (pawn.CanEnPassantLeft)
                {
                    Point attackPoint;
                    attackPoint = ChessPiece.GetDiagnalMovementArray(1, DiagnalDirection.Forward_Left)[0];
                    attackPoint.y *= flipDirection;
                    attackPoint.y += y;
                    attackPoint.x += x;
                    if (ValidatePoint(attackPoint))
                    {
                        AddMove(availableActions, new Point(x, y), attackPoint, ignoreCheck);
                    }
                }
                if (pawn.CanEnPassantRight)
                {
                    Point attackPoint;
                    attackPoint = ChessPiece.GetDiagnalMovementArray(1, DiagnalDirection.Forward_Right)[0];
                    attackPoint.y *= flipDirection;
                    attackPoint.y += y;
                    attackPoint.x += x;
                    if (ValidatePoint(attackPoint))
                    {
                        AddMove(availableActions, new Point(x, y), attackPoint, ignoreCheck);
                    }
                }
            }
            return availableActions;
        }
        public IEnumerable<Point> PieceActions(Point position, bool ignoreCheck = false, bool attackActions = true, bool moveActions = true, ChessPiece[,] boardArray = null)
        {
            return PieceActions(position.x, position.y, ignoreCheck, attackActions, moveActions, boardArray);
        }

        public bool ActionPiece(Point from, Point to, bool bypassValidaiton = false)
        {
            if (bypassValidaiton || PieceActions(from).Contains(to))
            {
                ChessPiece movingPiece = Board[from.x, from.y];
                if (movingPiece is Pawn)
                {
                    Pawn pawn = (Pawn)movingPiece;
                    // If this was a double jump, check enpassant
                    if (Math.Abs(from.y - to.y) == 2)
                    {
                        int adjasentX = to.x - 1;
                        if (adjasentX > -1
                            && Board[adjasentX, to.y] != null
                            && Board[adjasentX, to.y].Player != movingPiece.Player
                            && Board[adjasentX, to.y] is Pawn)
                        {
                            if (!bypassValidaiton)
                                ((Pawn)Board[adjasentX, to.y]).CanEnPassantRight = true;
                        }
                        adjasentX += 2;
                        if (adjasentX < Columns
                            && Board[adjasentX, to.y] != null
                            && Board[adjasentX, to.y].Player != movingPiece.Player
                            && Board[adjasentX, to.y] is Pawn)
                        {
                            if (!bypassValidaiton)
                                ((Pawn)Board[adjasentX, to.y]).CanEnPassantLeft = true;
                        }
                    }
                    // If this was a sideways jump to null, it was enpassant!
                    if (from.x != to.x && Board[to.x, to.y] == null)
                    {
                        Board[to.x, from.y] = null;
                    }

                    if (!bypassValidaiton) // Pawns can't double jump after they move.
                        pawn.CanDoubleJump = false;
                }
                if (movingPiece is CastlePiece)
                {
                    CastlePiece RookOrKing = (CastlePiece)movingPiece;
                    if (!bypassValidaiton) // Castling can't be done after moving
                        RookOrKing.CanCastle = false;
                }
                if (movingPiece is King)
                {
                    King king = (King)movingPiece;
                    if (from.x - to.x == 2)
                    {   // Move rook for Queenside castle
                        Board[to.x + 1, from.y] = Board[0, from.y];
                        Board[0, from.y] = null;
                    }
                    if (from.x - to.x == -2)
                    {   // Move rook for Kingside castle
                        Board[to.x - 1, from.y] = Board[Columns - 1, from.y];
                        Board[Columns - 1, from.y] = null;
                    }
                }
                movingPiece.Moves();
                Board[from.x, from.y] = null;
                Board[to.x, to.y] = movingPiece;
                return true;
            }
            return false;
        }
        public bool ActionPiece(int fromX, int fromY, int toX, int toY)
        {
            return ActionPiece(new Point(fromX, fromY), new Point(toX, toY));
        }


        //Check and validate if point is out of chessboard bound of 8x8
        private bool ValidateRange(int value, int high, int low = -1)
        {
            return value > low && value < high;
        }

        public bool ValidateX(int value)
        {
            return ValidateRange(value, Board.GetLength(0));
        }

        public bool ValidateY(int value)
        {
            return ValidateRange(value, Board.GetLength(1));
        }

        public bool ValidatePoint(Point point)
        {
            return ValidateX(point.x) && ValidateY(point.y);
        }
    }
}
