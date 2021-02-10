using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Grid_Game
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();

            /** Sets the label to have transparent background */
            this.TitleLbl.Parent = this.TitleImg;
            this.TitleLbl.BackColor = Color.Transparent;
            Program.player.PlayLooping();


        }

        /** Displays the difficulty screen */
        private void StartBtn_Click(object sender, EventArgs e)
        {
            using (var DifficultyScreen = new Difficulty())
            {
                this.Hide();
                DifficultyScreen.ShowDialog();
            }
        }

        /** Displays the highscore screen */
        private void HighScoresBtn_Click(object sender, EventArgs e)
        {
            using (var HighScoreScreen = new HighScores())
            {
                this.Hide();
                HighScoreScreen.ShowDialog();
            }
        }

        /** Exits the game */
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Program.player.Stop();
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /** Shows information about Magawa*/
        private void MagawaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An African giant pouched rat has been awarded a prestigious gold medal for his work detecting land mines. Magawa has sniffed out 39 landmines and 28 unexploded munitions in his career. The UK veterinary charity PDSA has presented him with its Gold Medal for life-saving devotion to duty, in the location and clearance of deadly landmines in Cambodia. According to Apopo, Magawa - born and raised in Tanzania - weighs 1.2kg (2.6lb) and is 70cm (28in) long. While that is far larger than many other rat species, Magawa is still small enough and light enough that he does not trigger mines if he walks over them. The rats are trained to detect a chemical compound within the explosives, meaning they ignore scrap metal and can search for mines more quickly.Once they find an explosive, they scratch the top to alert their human co - workers. Magawa is capable of searching a field the size of a tennis court in just 20 minutes - something Apopo says would take a person with a metal detector between one and four days. © BBC News", "Who is Magawa?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /** Shows information on how to play*/
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Magawa has been sent on a mission to clear a newly found area of mines. To help Magawa, you must figure out where the mines are by clearing the empty fields. Any field you click on may contain one of the following: a number, a mine or it may be empty. The number indicates how many mines there are in the neighbouring fields. Activating a mine results in a game over - although the mine can support Magawa's weight, that's unilkely for you! Finish the game by marking all the mines correctly. You can mark the suspected minefields by right-clicking them. The timer is limited to 999 seconds, so make sure you disarm all the mines before the time runs out. The number in the top-left corner will help you track the amount of mines you've marked. Best of luck, don't disappoint Magawa!", "How To Play", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /** Controls the mute button*/
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
