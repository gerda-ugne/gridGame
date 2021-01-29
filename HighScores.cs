using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            ScoreBox.Items.Clear();
            DifficultyLbl.Text = "Difficulty: Easy";
            String path = "..\\SaveGames\\Easy.txt";
            StreamReader reader = File.OpenText(path);
            string line;
            while ((line=reader.ReadLine()) != null)
            {
                string[] SaveData = line.Split('.');
                String score = SaveData[1];
                String name = SaveData[0];

                String combined = name + " " + score;

                ScoreBox.Items.Add(combined);
            }

        }

        private void MediumBtn_Click(object sender, EventArgs e)
        {
            ScoreBox.Items.Clear();
            DifficultyLbl.Text = "Difficulty: Medium";
            String path = "..\\SaveGames\\Medium.txt";
            StreamReader reader = File.OpenText(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] SaveData = line.Split('.');
                String score = SaveData[1];
                String name = SaveData[0];

                String combined = name + " " + score;

                ScoreBox.Items.Add(combined);
            }
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            ScoreBox.Items.Clear();
            DifficultyLbl.Text = "Difficulty: Hard";
            String path = "..\\SaveGames\\Hard.txt";
            StreamReader reader = File.OpenText(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] SaveData = line.Split('.');
                String score = SaveData[1];
                String name = SaveData[0];

                String combined = name + " " + score;

                ScoreBox.Items.Add(combined);
            }
        }

        private void HighScores_Load(object sender, EventArgs e)
        {

        }
    }
}
