using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chess;


namespace ChessForm
{
    public partial class FormWithAI : Form
    {
        bool attacksAvailable = false;
        int Player0MovesCount, Player1MovesCount, PlayerXMadelastMoved = 0;
        ChessBoard chessboard = new ChessBoard();
        Chess.Point selectedPiece = new Chess.Point();
        int selectedPlayer = -1;
        Random rnd = new Random();

        struct AI_Moves
        {
            public int attack;
            public Chess.Point AI_pos;
            public Chess.Point[] AI_Moves_p;
        }

        public FormWithAI()
        {
            InitializeComponent();
        }
        //PlXMLM is PlayerXMadeLastMoved    condition for checkmate if (Player1MovesCount>1&&Player0MovesCount>1)
        public bool CheckMate(int PlXMLM, ChessBoard Board)
        {
            int tempCount = 0;
            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    if (Board[x, y] != null)
                    {
                        switch (PlXMLM)
                        {
                            case 0:
                                if (Board.PieceActions(x, y).Count() != 0 && Board[x, y].Player == 1)
                                    tempCount++;
                                break;
                            case 1:
                                if (Board.PieceActions(x, y).Count() != 0 && Board[x, y].Player == 0)
                                    tempCount++;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            if (tempCount == 0)
                return true;
            else
            {
                Console.WriteLine("player {0} can have {1} pieces allow to move", Math.Abs(PlayerXMadelastMoved - 1), tempCount);
                return false;
            }

        }
        public void CountPlayerMoved()
        {
            PlayerXMadelastMoved = selectedPlayer;
            if (selectedPlayer == 0)
            {
                Player0MovesCount++;
            }
            else
            {
                Player1MovesCount++;
            }
            Console.WriteLine("player 1 moves count: {0} | player 0 moves count: {1}", Player1MovesCount, Player0MovesCount);
            Console.WriteLine("last moved was made by player {0}", PlayerXMadelastMoved);

        }
        public void DrawPiece(ChessBoard Board)
        {
            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {

                    Button butt = (Button)tableLayoutPanel1.GetControlFromPosition(x, y);
                    butt.FlatStyle = FlatStyle.Flat;
                    if ((x + y) % 2 == 1)
                        butt.BackColor = Color.Black;
                    else butt.BackColor = Color.White;
                    if (Board[x, y] != null)
                    {
                        ChessPiece chessPiece = Board[x, y];
                        butt.Tag = chessPiece;
                        switch (chessPiece.ToString())
                        {
                            case "Chess.King":
                                if (chessPiece.Player == 1)
                                    butt.Image = PiecesImageList.Images[7];
                                else butt.Image = PiecesImageList.Images[1];
                                break;
                            case "Chess.Bishop":
                                if (chessPiece.Player == 1)
                                    butt.Image = PiecesImageList.Images[6];
                                else butt.Image = PiecesImageList.Images[0];
                                break;
                            case "Chess.Queen":
                                if (chessPiece.Player == 1)
                                    butt.Image = PiecesImageList.Images[10];
                                else butt.Image = PiecesImageList.Images[4];
                                break;
                            case "Chess.Knight":
                                if (chessPiece.Player == 1)
                                    butt.Image = PiecesImageList.Images[8];
                                else butt.Image = PiecesImageList.Images[2];
                                break;
                            case "Chess.Rook":
                                if (chessPiece.Player == 1)
                                    butt.Image = PiecesImageList.Images[11];
                                else butt.Image = PiecesImageList.Images[5];
                                break;
                            case "Chess.Pawn":
                                if (chessPiece.Player == 1)
                                    butt.Image = PiecesImageList.Images[9];
                                else butt.Image = PiecesImageList.Images[3];
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        butt.Image = null;
                        butt.Tag = null;
                    }
                    this.coordinates.SetToolTip(butt, String.Format("({0},{1})", x, y));

                }
            }
            if (Player0MovesCount > 1 && Player0MovesCount > 1)
                if (CheckMate(PlayerXMadelastMoved, chessboard))
                {
                    MessageBox.Show($"Check Mate Player {Math.Abs(PlayerXMadelastMoved - 1)}", "CHECK MATE!!!");
                    this.Close();
                }
            if (PlayerXMadelastMoved == 1)
                AIMoves(Board);
        }

        private void FormWithAI_Load(object sender, EventArgs e)
        {

            for (int x = 0; x < tableLayoutPanel1.ColumnCount; x++)
            {
                for (int y = 0; y < tableLayoutPanel1.RowCount; y++)
                {
                    Button butt = new Button();
                    butt.Dock = DockStyle.Fill;
                    butt.Margin = new Padding(0);
                    butt.FlatStyle = FlatStyle.Flat;
                    butt.Dock = DockStyle.Fill;
                    butt.FlatAppearance.BorderSize = 0;
                    if ((x + y) % 2 == 1)
                        butt.BackColor = Color.Black;
                    else butt.BackColor = Color.White;
                    tableLayoutPanel1.Controls.Add(butt);
                    butt.Click += Board_Click;
                }
            }
            DrawPiece(chessboard);
        }
        private void AIMoves(ChessBoard Board)
        {
            // AI might not need to use attacksAvailable flag bc it doesn't need to click
            int count = 0;
            int index = 0;
            selectedPlayer = 0;
            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    if (Board[x, y] != null && Board[x, y].Player != 1 && Board.PieceActions(x,y).Count()!=0)
                    {
                        count++;
                    }
                }
            }

            AI_Moves[] Bob = new AI_Moves[count];

            //Generate move for Bob (Bob is kinda dumb just like his programmer). Bob will prioritize the first piece that can attack and move it 
            //If there are no piece that can attack Bob will choose a random piece and move it randomly as long as it can move
            for (int x = 0; x < Board.GetLength(0); x++)
            {
                for (int y = 0; y < Board.GetLength(1); y++)
                {
                    if (Board[x, y] != null && Board[x, y].Player != 1 && Board.PieceActions(x, y).Count() != 0)
                    {
                        //get Bob[Index] move count
                        int countTemp = 0;
                        Bob[index].AI_Moves_p = new Chess.Point[Board.PieceActions(x, y).Count()];
                        Bob[index].AI_pos = new Chess.Point(x, y); // index is out of range error need to be fix 
                        

                        foreach (Chess.Point point in chessboard.PieceActions(x, y))
                        {
                            Bob[index].attack = 0;
                            Button actionButton = (Button)tableLayoutPanel1.GetControlFromPosition(point.x, point.y);
                            if (actionButton.Tag is ChessPiece)
                            {
                                Bob[index].attack = 1;
                                chessboard.ActionPiece(x, y, point.x, point.y);
                                CountPlayerMoved();
                                DrawPiece(chessboard);
                                selectedPlayer = -1;
                                return;
                            }
                            Bob[index].AI_Moves_p[countTemp] = point;
                            countTemp++;
                        }
                        index++;
                    }
                }
            }
            int Piece_Bob_Will_Move = rnd.Next(count);
            int Piece_Moves_Bob_Will_Choose = rnd.Next(Bob[Piece_Bob_Will_Move].AI_Moves_p.Count());
            chessboard.ActionPiece(Bob[Piece_Bob_Will_Move].AI_pos, Bob[Piece_Bob_Will_Move].AI_Moves_p[Piece_Moves_Bob_Will_Choose]);
            CountPlayerMoved();
            DrawPiece(chessboard);
            selectedPlayer = -1;
        }
        //Event Handler for button click
        private void Board_Click(object sender, EventArgs e)
        {
            bool playerMoved;
            //Console.WriteLine($"attack available: {attacksAvailable}");
            DrawPiece(chessboard);
            Button butt = (Button)sender;
            if (!(sender is Button)) return;
            butt.FlatStyle = FlatStyle.Standard;
            TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetPositionFromControl((Control)sender);
            if (!(butt.Tag is ChessPiece))
            {
                attacksAvailable = false;
                if (selectedPlayer > -1)
                {
                    playerMoved = chessboard.ActionPiece(selectedPiece.x, selectedPiece.y, pos.Column, pos.Row);
                    if (playerMoved)
                    {
                        CountPlayerMoved();
                    }
                    selectedPlayer = -1;
                    DrawPiece(chessboard);
                }
                Console.WriteLine($"attack available: {attacksAvailable}");
                return;
            }
            ChessPiece chessPiece = (ChessPiece)butt.Tag;
            Console.WriteLine("({2}, {3}) - {0} from player {1}", chessPiece.GetType(), chessPiece.Player, pos.Column, pos.Row);

            //player turn calculation
            if (Player1MovesCount == Player0MovesCount)
                switch (chessPiece.Player)
                {
                    case 1:
                        if (attacksAvailable)
                            break;
                        if (!attacksAvailable && PlayerXMadelastMoved == 1)
                        {
                            Console.WriteLine("not player 1 turn"); return;
                        }
                        break;
                    case 0:
                        if (attacksAvailable)
                            break;
                        if (!attacksAvailable && PlayerXMadelastMoved == 0)
                        {
                            Console.WriteLine("not player 0 turn"); return;
                        }
                        break;
                    default:
                        break;
                }
            else switch (chessPiece.Player)
                {
                    case 1:
                        if (Player1MovesCount > Player0MovesCount && !attacksAvailable)
                        {
                            Console.WriteLine("not player 1 turn - count 1 > count 0");
                            return;
                        }
                        break;
                    case 0:
                        if (Player0MovesCount > Player1MovesCount && !attacksAvailable)
                        {
                            Console.WriteLine("not player 0 turn - count 0 > count 1"); return;
                        }
                        break;
                    default:
                        break;
                }

            //Click A chess piece on the board cal 
            if (selectedPlayer > -1 && selectedPlayer != chessPiece.Player)
            {
                playerMoved = chessboard.ActionPiece(selectedPiece.x, selectedPiece.y, pos.Column, pos.Row);
                if (playerMoved)
                {
                    CountPlayerMoved();
                    attacksAvailable = false;
                }
                selectedPlayer = -1;
                DrawPiece(chessboard);
            }
            else //Show legal moves when click a piece
            {
                selectedPlayer = chessPiece.Player;
                selectedPiece.x = pos.Column;
                selectedPiece.y = pos.Row;
                foreach (Chess.Point point in chessboard.PieceActions(pos.Column, pos.Row))
                {
                    Button actionButton = (Button)tableLayoutPanel1.GetControlFromPosition(point.x, point.y);
                    if (actionButton.Tag is ChessPiece)
                    {
                        attacksAvailable = true;
                        actionButton.BackColor = Color.Red;
                    }
                    else actionButton.BackColor = Color.Chartreuse;
                    actionButton.FlatStyle = FlatStyle.Standard;
                    Console.WriteLine("({0}, {1})", point.x, point.y);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\battack available: {attacksAvailable}");

        }
    }
 }

