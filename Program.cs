using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Game
{
    static class Program
    {
        //Defines the difficulty of the game
        public static string difficulty = "";
        //Defines the player name
        public static string name = "";
        //Defines the bomb amount
        public static int BombAmountSet =  10;
        //Defines the default music player
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer("African Safari Loop.wav");
        public static bool isPlaying = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
