using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessForm
{
    public partial class Pawn_Promotion : Form
    {
        public Pawn_Promotion()
        {
            InitializeComponent();
        }

        private void Bishop_Butt_Click(object sender, EventArgs e)
        {
            Chess.ChessBoard.PP = "Bishop";
            this.Close();
        }

        private void Rook_Butt_Click(object sender, EventArgs e)
        {
            Chess.ChessBoard.PP = "Rook";
            this.Close();
        }

        private void Knight_Butt_Click(object sender, EventArgs e)
        {
            Chess.ChessBoard.PP = "Knight";
            this.Close();
        }

        private void Queen_Butt_Click(object sender, EventArgs e)
        {
            Chess.ChessBoard.PP = "Queen";
            this.Close();
        }
    }
}
