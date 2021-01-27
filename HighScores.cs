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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            using (var MainMenuScreen = new MainMenu())
            {
                this.Hide();
                MainMenuScreen.ShowDialog();
            }
        }
    }
}
