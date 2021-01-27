using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            using (var DifficultyScreen = new Difficulty())
            {
                this.Hide();
                DifficultyScreen.ShowDialog();
            }
        }

        private void HighScoresBtn_Click(object sender, EventArgs e)
        {
            using (var HighScoreScreen = new HighScores())
            {
                this.Hide();
                HighScoreScreen.ShowDialog();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
