using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessForm
{
    public partial class Open : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory +"/Resources/Wav/Opening.wav");
        public Open()
        {
            player.PlayLooping();
            Thread t = new Thread(new ThreadStart(Loadingform));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        public void Loadingform()
        {
            Application.Run(new LoadingScreenForm());
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("You want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void SingleButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            FormWithAI ai = new FormWithAI();
            ai.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }

        private void SingleButton_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.White;
            b.ForeColor = Color.Black;
        }

        private void SingleButton_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Black;
            b.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            label2.ForeColor = label3.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Nqqc2FHf9Ug");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vietnamchess.vn/index.php/vi/databank/lawofchess/1920-lawofchess2018");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }
    }
}
