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

        
    }
}
