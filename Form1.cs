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
        Image img = Image.FromFile("b.png");
        Random r = new Random();


        public Minesweeper()
        {
            InitializeComponent();

            Image bgImage = Image.FromFile("bgImage.png");
            this.BackgroundImage = bgImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //TODO: scale timer with difficulty

            //Total timer counts the time until the end of the game
            TotalTimer = new System.Windows.Forms.Timer();
            //Displayed timer shows the current elapsed seconds to the player
            DisplayedTimer = new System.Windows.Forms.Timer();

            //TotalTimer.Interval = 9990000;
            DisplayedTimer.Interval = 1000;

            //Event handlers for handling timer ticks
            //TotalTimer.Tick += new EventHandler(TotalTimer_Tick);
            DisplayedTimer.Tick += new EventHandler(DisplayedTimer_Tick);

            /** Customizing grid */
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new GridButton(i, j);
                    btn[i, j].row = i;
                    btn[i, j].column = j;
                    btn[i, j].SetBounds(70 + (30 * i), 100 + (30 * j), 35, 35);
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
            LblTimer.Font = new Font("Molot", 40);
            this.Controls.Add(LblTimer);

            /** Customizing bombs label*/
            LblBombs.Text = Convert.ToString(bombAmount);
            LblBombs.Location = new Point(0, 0);
            LblBombs.Size = new Size(120, 80);
            LblBombs.TextAlign = ContentAlignment.MiddleLeft;
            LblBombs.BackColor = Color.Black;
            LblBombs.ForeColor = Color.Red;
            LblBombs.Font = new Font("Molot", 40);
            this.Controls.Add(LblBombs);

            TotalTimer.Start();
            DisplayedTimer.Start();

            //lblTime.Text = "You have cleared the minefield in " + stopwatch.Elapsed.Seconds.ToString() + "seconds."; 


            generateGridOfLabels();
            placeBombs();
            placeNumbers();

          
        }

        //Generating a layer of labels that are located under the buttons
        private void generateGridOfLabels()
        {
            for (int i = 0; i < lowerGrid.GetLength(0); i++)
            {
                for (int j = 0; j < lowerGrid.GetLength(1); j++)
                {
                    lowerGrid[i, j] = new Label();
                    lowerGrid[i, j].SetBounds(70 + (30 * i), 100 + (30 * j), 35, 35);
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
        //private void TotalTimer_Tick(object sender, EventArgs e)
       // {
          //  TotalTimer.Stop();
          //  DisplayedTimer.Stop();

          //  DialogResult result = MessageBox.Show("Time is due. Would you like to try again ?", "Time's up", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
       // }

        /** Randomly placing bombs on a grid*/
        private void placeBombs()
        {

            int x = 0;
            int k, l;

            //beginner's level: generating 10 bombs that are randomly placed
            //on a grid
            while (x < bombAmount)
            {
                k = r.Next(width-1);
                l = r.Next(length-1);

                //checking if there is an image already under the button
                //if yes, skip the following steps
                if (btn[k, l].Text.Equals("*"))
                    continue;

                //putting an image under the button
                lowerGrid[k, l].Image = img;
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
            for (int i = x - 1; i <= x+1; i++)
            {
                for(int j = y-1; j <= y+1; j++)
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
           for(int i = 0; i < btn.GetLength(0); i++)
            {
                for(int j = 0; j < btn.GetLength(1); j++)
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

            String ToSave = playerName + "." + playerScore;

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

            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:

                    //Clicking on a marked field
                    if (((GridButton)sender).BackColor == Color.Red)
                    {
                        //If the marked field had a bomb
                        if(((GridButton)sender).Text == "*") gameOver();

                        ((GridButton)sender).BackColor = Color.White;
                        ((GridButton)sender).ForeColor = Color.DarkViolet;

                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) + 1));
                    }
                    //If a button has an indication of a bomb
                    else if (text.Equals(((GridButton)sender).Text))
                    {
                        gameOver();
                    }

                    //If there is no text on a button 
                    else if (((GridButton)sender).Text.Equals("1") == false && ((GridButton)sender).Text.Equals("2") == false
                        && ((GridButton)sender).Text.Equals("3") == false && ((GridButton)sender).Text.Equals("4") == false && ((GridButton)sender).Text.Equals("5") == false && ((GridButton)sender).Text.Equals("6") == false)
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
                    else if (((GridButton)sender).BackColor == Color.White); // do nothing as you cannot mark an opened field as a bomb
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

                        if (BombsToFind==0 && LblBombs.Text == "0")
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

        }

        /** Method is called when the game ends.*/
        private void gameOver()
        {
            uncoverAllGrid();
            DisplayedTimer.Stop();
            TotalTimer.Stop();
            DialogResult result = MessageBox.Show("Would you like to try again ?", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
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

        private void winMessage()
        {
            uncoverAllGrid();
            DisplayedTimer.Stop();
            TotalTimer.Stop();

            DialogResult result = MessageBox.Show("You won, would you like to save your score?", "WIN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                saveData();
                
            }
            DialogResult playAgain = MessageBox.Show("Would you like to play again ?", "Play again?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
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

        //Displaying all bombs and numbers that are on a grid
        private void uncoverAllGrid()
        {
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    if (btn[i, j].Text.Equals("*"))
                    btn[i, j].Hide();
                    else
                    btn[i, j].Enabled=false;

                }
            }
        }

        //When a player clicks on an empty cell, this method is called to clear a larger area of a grid 
        // NEEDS A REFERENCE 
        private void uncoverPartOfGrid(int i, int j)
        {
            //if a number of a row and a number of a columns are out of bounds
            if (i < 0 || j < 0 || j >= btn.GetLength(1) || i >= btn.GetLength(0))
            { 
                return;
            }
            //If a button contains a bomb indication or the button has been already revealed
            if (btn[i,j].BackColor == Color.Red)
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
            uncoverPartOfGrid(i, j+1);
            uncoverPartOfGrid(i, j-1);
            uncoverPartOfGrid(i+1,j );
            uncoverPartOfGrid(i-1, j);




        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    }
}
