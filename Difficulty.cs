﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * 
 * Group 8
 * Gerda Ugne Pupelyte 190013631
 * Laura Naslenaite 190013642
 * Cameron Sutcliffe 190005288
 
 
 */
namespace Grid_Game
{
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();

            /** Assinging image as a parent to hide the background of the labels*/
            this.NameTitleLbl.Parent = this.TitleImg;
            this.NameLbl.Parent = this.TitleImg;
            this.DiffTitleLbl.Parent = this.TitleImg;
            this.DifficultyLbl.Parent = this.TitleImg;
            this.EnterNameLbl.Parent = this.TitleImg;


            this.NameTitleLbl.BackColor = Color.Transparent;
            this.NameLbl.BackColor = Color.Transparent;
            this.DiffTitleLbl.BackColor = Color.Transparent;
            this.DifficultyLbl.BackColor = Color.Transparent;
            this.EnterNameLbl.BackColor = Color.Transparent;

        }

        /** Returns player to the main menu*/
        private void BackBtn_Click(object sender, EventArgs e)
        {
            using (var MainMenuScreen = new MainMenu())
            {
                this.Hide();
                MainMenuScreen.ShowDialog();
            }
        }

        /** Sets easy difficulty */
        private void EasyBtn_Click(object sender, EventArgs e)
        {
            Program.difficulty = "Easy";
            DifficultyLbl.Text = "Difficulty: " + (Program.difficulty);
        }

        /** Sets medium difficulty */
        private void MedBtn_Click(object sender, EventArgs e)
        {
            Program.difficulty = "Medium";
            DifficultyLbl.Text = "Difficulty: " + (Program.difficulty);
        }

        /** Sets hard difficulty */
        private void HardBtn_Click(object sender, EventArgs e)
        {
            Program.difficulty = "Hard";
            DifficultyLbl.Text = "Difficulty: " + (Program.difficulty);
        }

        /** Sets player's name */
        private void UpdateNameBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                Program.name = NameTextBox.Text;
                NameLbl.Text = "Name: " + (Program.name);
            }
            else
            {
                MessageBox.Show("You need to enter a name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /** Starts a new game with the set settings */
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (Program.name != "" && Program.difficulty != "")
            {
                if (Program.difficulty == "Easy")
                {
                    Program.BombAmountSet = 15;
                }
                else if (Program.difficulty == "Medium")
                {
                    Program.BombAmountSet = 25;
                }
                else if (Program.difficulty == "Hard")
                {
                    Program.BombAmountSet = 35;
                }
                else
                {
                    MessageBox.Show("Error: Difficulty selection error");
                }

                using (var GameForm = new Minesweeper())
                {
                    this.Hide();
                    GameForm.ShowDialog();
                }
            }
            else if (Program.name == "")
            {
                MessageBox.Show("You need to enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You need to select a difficulty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {
            Program.name = "";
            Program.difficulty = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TitleImg_Click(object sender, EventArgs e)
        {

        }

        /** Controls for the mute button*/
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
    }
}

