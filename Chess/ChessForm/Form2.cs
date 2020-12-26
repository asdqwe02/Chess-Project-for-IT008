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
    public partial class Form2 : Form
    {
        bool attacksAvailable = false;
        int Player0MovesCount, Player1MovesCount, PlayerXMadelastMoved = 0;
        ChessBoard chessboard = new ChessBoard();
        Chess.Point selectedPiece = new Chess.Point();
        int selectedPlayer = -1;
        
        public Form2()
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
                    //pawn Promotion
                    if (Board[x, y] != null && Board[x, y].GetType().ToString() == "Chess.Pawn")
                    {
                            switch (Board[x,y].Player)
                            {
                                case 0:
                                if (y == 7)
                                    PawnPromotion(chessboard, x, y);
                                    break;
                                case 1:
                                    if (y == 0)
                                        PawnPromotion(chessboard, x, y);
                                    break;
                                default:
                                    break;
                            }
                    }
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
            if (Player0MovesCount >= 0 && Player0MovesCount >= 0)
                if (CheckMate(PlayerXMadelastMoved, chessboard))
                {
                    MessageBox.Show($"Check Mate Player {Math.Abs(PlayerXMadelastMoved - 1)}", "CHECK MATE!!!");
                    this.Close();
                    System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory +"/Resources/Wav/Opening.wav");
                    player1.PlayLooping();
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private static void PawnPromotion(ChessBoard board,int x,int y)
        {
            Form ppf = new Pawn_Promotion();
            ppf.ShowDialog();
            int TPlayer=board[x, y].Player;
            string PieceTyoe = Chess.ChessBoard.PP;
            board.Pawn_Promotion(x, y, PieceTyoe);
            board[x, y].Player = TPlayer;

        }

        private void Form2_Load_1(object sender, EventArgs e)
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
            ChessPiece chessPiece = (ChessPiece)butt.Tag;
            //move without attack
            if (!(butt.Tag is ChessPiece))
            {
                attacksAvailable = false;
                if (selectedPlayer > -1)
                {
                    
                    playerMoved = chessboard.ActionPiece(selectedPiece.x, selectedPiece.y, pos.Column, pos.Row);
                    if (playerMoved)
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory +"/Resources/Wav/Move.wav");
                        player.Play();
                        CountPlayerMoved();
                        //Pawn Promote
        
                        
                    }
                    selectedPlayer = -1;
                    DrawPiece(chessboard);
                }
                Console.WriteLine($"attack available: {attacksAvailable}");
                return;
            }
            
            Console.WriteLine("({2}, {3}) - {0} from player {1}", chessPiece.GetType(), chessPiece.Player, pos.Column, pos.Row);


            ///player player turn
            ///if (Player1MovesCount == Player0MovesCount)
            ///    switch (chessPiece.Player)
            ///    {
            ///        case 1:
            ///            if (attacksAvailable)
            ///               break;
            ///            if (!attacksAvailable && PlayerXMadelastMoved == 1)
            ///            {
            ///                Console.WriteLine("not player 1 turn"); return;
            ///            }
            ///            break;
            ///        case 0:
            ///            if (attacksAvailable)
            ///                break;
            ///            if (!attacksAvailable && PlayerXMadelastMoved == 0)
            ///            {
            ///                Console.WriteLine("not player 0 turn"); return;
            ///            }
            ///            break;
            ///        default:
            ///            break;
            ///    }
            ///else switch (chessPiece.Player)
            ///    {
            ///        case 1:
            ///            if (Player1MovesCount > Player0MovesCount && !attacksAvailable)
            ///            {
            ///                Console.WriteLine("not player 1 turn - count 1 > count 0");
            ///                return;
            ///            }
            ///            break;
            ///        case 0:
            ///            if (Player0MovesCount > Player1MovesCount && !attacksAvailable)
            ///            {
            ///                Console.WriteLine("not player 0 turn - count 0 > count 1"); return;
            ///            }
            ///            break;
            ///        default:
            ///            break;
            ///    }

            if (selectedPlayer > -1 && selectedPlayer != chessPiece.Player)
            {
                
                playerMoved = chessboard.ActionPiece(selectedPiece.x, selectedPiece.y, pos.Column, pos.Row);
                if (playerMoved)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Wav/Move.wav");
                    player.Play();
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
