using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    public partial class Minesweeper : Form
    {


        //Initialize a timer for the game
        System.Windows.Forms.Timer TotalTimer;
        System.Windows.Forms.Timer DisplayedTimer;

        private int elapsedSeconds = 999;

        int bombAmount = Program.BombAmountSet;
        //Label to display the time
        Label LblTimer = new Label();
        //Label to display bombs left
        Label LblBombs = new Label();

        //The 2D grid 
        static int width = 18;
        static int length = 18;
        int BombsToFind = Program.BombAmountSet;


        //The buttons are of a GridButton data type
        GridButton[,] btn = new GridButton[width, length];

        //A grid under the buttons
        Label[,] lowerGrid = new Label[width, length];
        //Bomb image
        Image img = Image.FromFile("b1.png");
        Random r = new Random();

        int clickCounter = 0;
        Button btnFace = new Button();



        public Minesweeper()
        {
            InitializeComponent();

            //Background image
            Image bgImage = Image.FromFile("bgImage.png");
            this.BackgroundImage = bgImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Button btnBack = new Button();

            //Total timer counts the time until the end of the game
            TotalTimer = new System.Windows.Forms.Timer();
            //Displayed timer shows the current elapsed seconds to the player
            DisplayedTimer = new System.Windows.Forms.Timer();

            TotalTimer.Interval = 999000;
            DisplayedTimer.Interval = 1000;

            //Event handlers for handling timer ticks
            TotalTimer.Tick += new EventHandler(TotalTimer_Tick);
            DisplayedTimer.Tick += new EventHandler(DisplayedTimer_Tick);

            /** Customizing grid */
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new GridButton(i, j);
                    btn[i, j].row = i;
                    btn[i, j].column = j;
                    btn[i, j].SetBounds(70 + (30 * i), 100 + (30 * j), 30, 30);
                    btn[i, j].BackColor = Color.LightGray;

                    btn[i, j].MouseUp += new MouseEventHandler(this.BtnEvent_MouseUp);

                    Controls.Add(btn[i, j]);

                }
            }

            /** Customizing timer label*/

            LblTimer.Text = "999";
            LblTimer.Location = new Point(565, 0);
            LblTimer.Size = new Size(120, 80);
            LblTimer.TextAlign = ContentAlignment.MiddleRight;
            LblTimer.BackColor = Color.Black;
            LblTimer.ForeColor = Color.Red;
            LblTimer.Font = new Font("Impact", 40);
            this.Controls.Add(LblTimer);

            /** Customizing bombs label*/
            LblBombs.Text = Convert.ToString(bombAmount);
            LblBombs.Location = new Point(0, 0);
            LblBombs.Size = new Size(120, 80);
            LblBombs.TextAlign = ContentAlignment.MiddleLeft;
            LblBombs.BackColor = Color.Black;
            LblBombs.ForeColor = Color.Red;
            LblBombs.Font = new Font("Impact", 40);
            this.Controls.Add(LblBombs);

            //Starting the game timers
            TotalTimer.Start();
            DisplayedTimer.Start();


            //Customizing "Smiley face" button
            btnFace.Size = new Size(45, 45);
            btnFace.Location = new Point(305, 20);

            btnFace.Image = Image.FromFile("smiley.png");
            btnFace.FlatStyle = FlatStyle.Flat;

            btnFace.BackColor = Color.Transparent;
            btnFace.FlatAppearance.BorderSize = 0;

            btnFace.Click += new EventHandler(this.btnFaceEvent_Click);
            btnFace.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFace.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Controls.Add(btnFace);

            //Back button
            btnBack.SetBounds(80, 647 ,180, 53);
            btnBack.BackColor = Color.Brown;
            btnBack.Text = "Exit to Main Menu";
            btnBack.Font = new Font("Molot", 12);
            btnBack.Click += new EventHandler(this.BackBtn_Click);
            Controls.Add(btnBack);

            generateGridOfLabels();


        }


        /** Restarting a game after clicking on a face button */
        public void btnFaceEvent_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
            using (var GameForm = new Minesweeper())
            {
                this.Hide();
                GameForm.ShowDialog();
            }

        }

        /** Generating a layer of labels that are located under the buttons  */
        private void generateGridOfLabels()
        {
            for (int i = 0; i < lowerGrid.GetLength(0); i++)
            {
                for (int j = 0; j < lowerGrid.GetLength(1); j++)
                {
                    lowerGrid[i, j] = new Label();
                    lowerGrid[i, j].SetBounds(70 + (30 * i), 100 + (30 * j), 30, 30);
                    lowerGrid[i, j].BackColor = Color.White;
                    Controls.Add(lowerGrid[i, j]);
                }
            }
        }

        /**Displays the current elapsed time to the player.*/
        private void DisplayedTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds--;
            LblTimer.Text = Convert.ToString(elapsedSeconds);
            if (elapsedSeconds == 0)
            {
                TotalTimer.Stop();
                DisplayedTimer.Stop();
                gameOver();
            }
        }


        /** Event that happens once the timer reaches the limit of time given*/
        private void TotalTimer_Tick(object sender, EventArgs e)
        {
          TotalTimer.Stop();
          DisplayedTimer.Stop();

          DialogResult result = MessageBox.Show("Time is due. Would you like to try again ?", "Time's up", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
          if (result == DialogResult.Retry)
            {
                using (var GameForm = new Minesweeper())
                {
                    this.Hide();
                    GameForm.ShowDialog();
                }

            }
            else if (result == DialogResult.Cancel)
            {
                using (var MainMenuScreen = new MainMenu())
                {
                    this.Hide();
                    MainMenuScreen.ShowDialog();
                }
            }
         }

        /** Randomly placing bombs on a grid*/
        private void placeBombs(int row, int col)
        {

            int x = 0;
            int k, l;

            //beginner's level: generating 10 bombs that are randomly placed
            //on a grid
            while (x < bombAmount)
            {
                k = r.Next(width - 1);
                l = r.Next(length - 1);

                //checking if there is an image already under the button
                //if yes, skip the following steps
                if (btn[k, l].Text.Equals("*") || (k == row && l == col))
                    continue;

                //putting an image under the button
                lowerGrid[k, l].Image = img;
                lowerGrid[k, l].BackColor = Color.Transparent;
                //adding a text (text color is the same as the color of a button) that is not visible on a button indicating
                //an existence of a bomb under that particular button
                btn[k, l].Text = "*";
                btn[k, l].ForeColor = Color.LightGray;

                x++;

            }

        }

        /** Counts the neighbours that have bombs around each cell*/
        private int countNeighbours(int x, int y)
        {
            int totalNeighbours = 0;

            //If the field is a bomb, pass
            if (btn[x, y].Text == "*") return -1;

            //Else count every bomb around the cell
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i < 0 || j < 0 || i >= width || j >= length) continue; //avoiding out of boundaries
                    if (btn[i, j].Text == "*") totalNeighbours++;
                }
            }

            Console.WriteLine(totalNeighbours);
            return totalNeighbours;
        }


        /** Placing numbers that indicate bombs on the grid*/
        private void placeNumbers()
        {
            int neighbourBombs = 0;
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    neighbourBombs = countNeighbours(i, j);
                    Console.WriteLine(neighbourBombs);
                    if (neighbourBombs > 0 && neighbourBombs != -1)
                    {
                        btn[i, j].Text = Convert.ToString(neighbourBombs);
                        btn[i, j].ForeColor = Color.LightGray;

                        //the same random number is written on a label that is under a button
                        lowerGrid[i, j].Text = Convert.ToString(neighbourBombs);
                        lowerGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    }

                }
            }
        }

        /** Check that all bombs are covered by red squares**/
        private void saveData()
        {
            String playerScore = LblTimer.Text;
            String playerName = Program.name;

            String ToSave = playerName + "." + playerScore + "\n";

            String SavePath = "";

            if (Program.difficulty == "Easy")
            {
                SavePath = "..\\SaveGames\\Easy.txt";
            }

            else if (Program.difficulty == "Medium")
            {
                SavePath = "..\\SaveGames\\Medium.txt";
            }

            else if (Program.difficulty == "Hard")
            {
                SavePath = "..\\SaveGames\\Hard.txt";
            }
            else
            {
                MessageBox.Show("ERROR: Unknown save file");
            }

            var sw = new StreamWriter(SavePath, true);
            sw.Write(ToSave);
            sw.Dispose();
        }

        /** Controls the click events for the grid */
        private void BtnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            //A text indication of a button that there is a bomb under itself
            string text = "*";
            clickCounter++;

            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:

                    //Clicking on a marked field
                    if (((GridButton)sender).BackColor == Color.Red)
                    {
                        //If the marked field had a bomb
                        if (((GridButton)sender).Text == "*") gameOver();

                        ((GridButton)sender).BackColor = Color.White;
                        ((GridButton)sender).ForeColor = Color.DarkViolet;

                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) + 1));
                    }
                    //If a button has an indication of a bomb
                    else if (text.Equals(((GridButton)sender).Text))
                    {
                        ((GridButton)sender).Hide();
                        gameOver();
                    }

                    //If there is no text on a button 
                    else if (((GridButton)sender).Text.Equals("1") == false && ((GridButton)sender).Text.Equals("2") == false
                        && ((GridButton)sender).Text.Equals("3") == false && ((GridButton)sender).Text.Equals("4") == false && ((GridButton)sender).Text.Equals("5") == false && ((GridButton)sender).Text.Equals("6") == false && clickCounter != 1)
                    {
                        //Creating a temp variable to get the number of a row and column of that specific button
                        GridButton tempBtn = (GridButton)sender;
                        //Calling a method to uncover the neighbours of an empty cell 
                        uncoverPartOfGrid(tempBtn.row, tempBtn.column);

                    }
                    else
                    {
                        //Display a button in white color and change the color of text on a button to be more visible
                        ((GridButton)sender).BackColor = Color.White;
                        ((GridButton)sender).ForeColor = Color.DarkViolet;
                    }
                    break;


                //If a tile on grid is clicked on with right click, the colour is changed to red
                //When clicked again, it's reverted back to gray.
                case MouseButtons.Right:


                    if (((GridButton)sender).BackColor == Color.Red)
                    {
                        ((GridButton)sender).BackColor = Color.LightGray;
                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) + 1));


                        GridButton tempBtn = (GridButton)sender;
                        lowerGrid[tempBtn.row, tempBtn.column].BackColor = Color.LightGray;
                        ((GridButton)sender).BackColor = Color.LightGray;
                        ((GridButton)sender).ForeColor = Color.LightGray;

                        if (text.Equals(((GridButton)sender).Text))
                        {
                            BombsToFind++;
                        }

                        if (BombsToFind == 0 && LblBombs.Text == "0")
                        {
                            TotalTimer.Stop();
                            DisplayedTimer.Stop();
                            winMessage();
                        }
                    }
                    else if (((GridButton)sender).BackColor == Color.White) ; // do nothing as you cannot mark an opened field as a bomb
                    else if (LblBombs.Text != "0")
                    {
                        ((Button)sender).BackColor = Color.Red;
                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) - 1));

                        //Creating a temp variable to get the number of a row and a column of that specific button
                        GridButton tempBtn = (GridButton)sender;

                        if (text.Equals(((GridButton)sender).Text))
                        {
                            BombsToFind--;
                        }

                        if (BombsToFind == 0 && LblBombs.Text == "0")
                        {
                            TotalTimer.Stop();
                            DisplayedTimer.Stop();
                            winMessage();
                        }

                        //Setting the color of a label which is under the button to be red so that when all cells are dispayed
                        // a player could see his/her "red flags"
                        lowerGrid[tempBtn.row, tempBtn.column].BackColor = Color.Red;
                        ((GridButton)sender).BackColor = Color.Red;
                        ((GridButton)sender).ForeColor = Color.Red;

                    }


                    break;

            }
            if (clickCounter == 1)
            {
                GridButton tempBtn = (GridButton)sender;

                placeBombs(tempBtn.row, tempBtn.column);
                placeNumbers();
            }


        }

        /** Method is called when the game ends.*/
        private void gameOver()
        {

            btnFace.Image = Image.FromFile("sad.png");

            uncoverAllGrid();
            DisplayedTimer.Stop();
            TotalTimer.Stop();
            DialogResult playAgain = MessageBox.Show("Would you like to play again ?", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            if (playAgain == DialogResult.Retry)
            {
                using (var GameForm = new Minesweeper())
                {
                    this.Hide();
                    GameForm.ShowDialog();
                }

            }
            else if (playAgain == DialogResult.Cancel)
            {
                using (var MainMenuScreen = new MainMenu())
                {
                    this.Hide();
                    MainMenuScreen.ShowDialog();
                }
            }
        }

        /**Displaying a message box after winning the game */
        private void winMessage()
        {
            uncoverAllGrid();
            DisplayedTimer.Stop();
            TotalTimer.Stop();

            DialogResult result = MessageBox.Show("You won, would you like to save your score?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                saveData();

            }
            DialogResult playAgain = MessageBox.Show("Would you like to play again ?", "Play again?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            if(playAgain == DialogResult.Retry)
            {
                using (var GameForm = new Minesweeper())
                {
                    this.Hide();
                    GameForm.ShowDialog();
                }

            }
            else if (playAgain == DialogResult.Cancel)
            {
                using (var MainMenuScreen = new MainMenu())
                {
                    this.Hide();
                    MainMenuScreen.ShowDialog();
                }
            }
        }

        /**Displaying all bombs and numbers that are on a grid*/
        private void uncoverAllGrid()
        {
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    if (btn[i, j].Text.Equals("*"))
                        btn[i, j].Hide();
                    else
                        btn[i, j].Enabled = false;

                }
            }
        }

        /** When a player clicks on an empty cell, this method is called to clear a larger area of a grid */
        private void uncoverPartOfGrid(int i, int j)
        {
            //if a number of a row and a number of a columns are out of bounds
            if (i < 0 || j < 0 || j >= btn.GetLength(1) || i >= btn.GetLength(0))
            {
                return;
            }
            //If a button contains a bomb indication or the button has been already revealed
            if (btn[i, j].BackColor == Color.Red)
            {
                LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) + 1));
            }

            if (btn[i, j].Text.Equals("*") == true || btn[i, j].BackColor == Color.White)
                return;
            //If there are more neighbours than 0, do not reveal more
            if (countNeighbours(i, j) != 0) return;
            //Colors a button in white and makes the text on a button visible
            btn[i, j].BackColor = Color.White;
            btn[i, j].ForeColor = Color.DarkViolet;


            /*The principle of a flood fill algorithm was based on an example from a resource cited below: 
            *
            * Title: C# Programming Recursion in Candy Crush Tutorial [Part 6] flood fill algorithm
            * Author:Shad Sluiter
            * Date: 2019-06-24
            * Availability: https://www.youtube.com/watch?v=3wNMYp4NvIE&list=PLhPyEFL5u-i03yjAvWPwYyG6s3K0jH8QX&index=51
            */
            uncoverPartOfGrid(i, j + 1);
            uncoverPartOfGrid(i, j - 1);
            uncoverPartOfGrid(i + 1, j);
            uncoverPartOfGrid(i - 1, j);
            /*
             * End of code extract. 
            */
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /** Muting/unmuting the sound of the game */
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

        /**Going back from game screen to main menu screen */
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
