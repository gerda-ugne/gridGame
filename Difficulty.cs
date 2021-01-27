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
    public partial class Difficulty : Form
    {
        public Difficulty()
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

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            Program.difficulty = "Easy";
            DifficultyLbl.Text = "Difficulty: " + (Program.difficulty);
        }

        private void MedBtn_Click(object sender, EventArgs e)
        {
            Program.difficulty = "Medium";
            DifficultyLbl.Text = "Difficulty: " + (Program.difficulty);
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            Program.difficulty = "Hard";
            DifficultyLbl.Text = "Difficulty: " + (Program.difficulty);
        }

        private void UpdateNameBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                Program.name = NameTextBox.Text;
                NameLbl.Text = "Name: " + (Program.name);
            }
            else
            {
                MessageBox.Show("You need to enter a name");
            }

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (Program.name != "" && Program.difficulty != "")
            {
            }
            else if (Program.name == "")
            {
                MessageBox.Show("You need to enter a name");
            }
            else
            {
                MessageBox.Show("You need to select a difficulty");
            }
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {
            Program.name = "";
            Program.difficulty = "";
        }
    }
}

