using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Grid_Game
{
    public partial class Minesweeper : Form
    {
        //Edit the size depending on difficulty
        //The 2D grid
        static int width = 10;
        static int length = 10;

        //Initialize a timer for the game
        System.Windows.Forms.Timer TotalTimer;
        System.Windows.Forms.Timer DisplayedTimer;

        private int elapsedSeconds = 0;

        //Label to display the time
        Label LblTimer = new Label();
        //Label to display bombs left
        Label LblBombs = new Label();

        //Button grid to be displayed to the user
        Button[,] btn = new Button[width, length];
        

        public Minesweeper()
        {
            InitializeComponent();

            //TODO: scale timer with difficulty

            //Total timer counts the time until the end of the game
            TotalTimer = new System.Windows.Forms.Timer();
            //Displayed timer shows the current elapsed seconds to the player
            DisplayedTimer = new System.Windows.Forms.Timer();

            TotalTimer.Interval = 9990000;
            DisplayedTimer.Interval = 1000;

            //Event handlers for handling timer ticks
            TotalTimer.Tick += new EventHandler(TotalTimer_Tick);
            DisplayedTimer.Tick += new EventHandler(DisplayedTimer_Tick);

            /** Customizing grid */
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(90 + (50 * i), 100 + (50 * j), 45, 45);
                    btn[i, j].BackColor = Color.LightGray;
                    btn[i, j].MouseUp += new MouseEventHandler(this.BtnEvent_MouseUp);
                    Controls.Add(btn[i, j]);
                }
            }

            /** Customizing timer label*/

            LblTimer.Text = "000";
            LblTimer.Location = new Point(565, 0);
            LblTimer.Size = new Size(120, 80);
            LblTimer.TextAlign = ContentAlignment.MiddleRight;
            LblTimer.BackColor = Color.Black;
            LblTimer.ForeColor = Color.Red;
            LblTimer.Font = new Font("Calibri", 40);
            this.Controls.Add(LblTimer);

            /** Customizing bombs label*/
            LblBombs.Text = "50";
            LblBombs.Location = new Point(0, 0);
            LblBombs.Size = new Size(120, 80);
            LblBombs.TextAlign = ContentAlignment.MiddleLeft;
            LblBombs.BackColor = Color.Black;
            LblBombs.ForeColor = Color.Red;
            LblBombs.Font = new Font("Calibri", 40);
            this.Controls.Add(LblBombs);

            TotalTimer.Start();
            DisplayedTimer.Start();
            
            //Add a stopwatch.Stop() and timer.Stop() when game ends:
            //lblTime.Text = "You have cleared the minefield in " + stopwatch.Elapsed.Seconds.ToString() + "seconds."; 
        }

        /**Displays the current elapsed time to the player.*/
        private void DisplayedTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            LblTimer.Text = Convert.ToString(elapsedSeconds);
        }

        /** Event that happens once the timer reaches the limit of time given*/
        private void TotalTimer_Tick(object sender, EventArgs e)
        {
            TotalTimer.Stop();
            DisplayedTimer.Stop();

            DialogResult result = MessageBox.Show("Time is due. Would you like to try again ?", "Time's up", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
        }


        /**Controls the click events for the grid*/
        private void BtnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:

                    //If clicked on a mistaken bomb, bomb counter increments
                    if (((Button)sender).BackColor == Color.Red)
                    {
                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) + 1));
                    }
                    ((Button)sender).BackColor = Color.White;
                    break;


                //If a tile on grid is clicked on with right click, the colour is changed to red
                //When clicked again, it's reverted back to gray.
                case MouseButtons.Right:

                    if (((Button)sender).BackColor == Color.Red)
                    {
                        ((Button)sender).BackColor = Color.LightGray;
                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) + 1));
                    }
                    else if (((Button)sender).BackColor == Color.White) ;
                    else
                    {
                        ((Button)sender).BackColor = Color.Red;
                        LblBombs.Text = Convert.ToString((Convert.ToInt32(LblBombs.Text) - 1));
                    }
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
