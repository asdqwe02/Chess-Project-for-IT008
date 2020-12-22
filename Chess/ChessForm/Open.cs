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
        public Open()
        {
            Thread t = new Thread(new ThreadStart(Loadingform));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
        }
        public void Loadingform()
        {
            Application.Run(new LoadingScreenForm());
        }
        private void ABbutton_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private void OTbutton_Click(object sender, EventArgs e)
        {
            Form options = new OptionForm();
            options.ShowDialog();
        }

        private void PRbutton_Click(object sender, EventArgs e)
        {
            Form Started = new Form2();
            Started.ShowDialog();
        }

        private void AIbutton_Click(object sender, EventArgs e)
        {

        }

        private void LANbutton_Click(object sender, EventArgs e)
        {
            Form Started = new Form1();
            Started.ShowDialog();
        }
    }
}
