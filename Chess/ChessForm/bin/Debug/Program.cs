using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessForm
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Chess-Project-for-IT007-main - Copy\Chess\ChessForm\Resources\Wav\Opening.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Wav/Opening.wav");

            player.PlayLooping();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Open());
        }
    }
}
