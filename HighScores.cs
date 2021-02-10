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

            /** Sets transparency for the labels */
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            DifficultyLbl.Parent = pictureBox1;
            DifficultyLbl.BackColor = Color.Transparent;
        }

        /** Returns the player to the main menu */
        private void BackBtn_Click(object sender, EventArgs e)
        {
            using (var MainMenuScreen = new MainMenu())
            {
                this.Hide();
                MainMenuScreen.ShowDialog();
            }
        }

        /** Displays the highscores of the easy difficulty*/
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


        /** Displays the highscores of the medium difficulty*/
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

        /** Displays the highscores of the hard difficulty*/
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /** Controls the mute button */
        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.isPlaying)
            {
                Program.player.Stop();
                button2.BackgroundImage = Image.FromFile("unmute.png");
                Program.isPlaying = false;
            }
            else
            {
                Program.isPlaying = true;
                Program.player.PlayLooping();
                button2.BackgroundImage = Image.FromFile("mute.png");
            }
        }

        private void DifficultyLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
