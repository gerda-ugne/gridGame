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
        private static System.Timers.Timer timer;

        //Label to display the time
        Label lblTimer = new Label();
        //Label to display bombs left
        Label lblBombs = new Label();

        //Intialize a stopwatch to calculate the time taken
        private static Stopwatch stopwatch;

        //Button grid to be displayed to the user
        Button[,] btn = new Button[width, length];
        

        public Minesweeper()
        {
            InitializeComponent();

            //TODO: scale timer with difficulty
            timer = new System.Timers.Timer(3000);
            timer.AutoReset = true;
            timer.Elapsed += OnTimedEvent;


            stopwatch = new Stopwatch();

            /** Customizing grid */
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(90 + (50 * i), 100 + (50 * j), 45, 45);
                    btn[i, j].BackColor = Color.LightGray;
                    btn[i, j].MouseUp += new MouseEventHandler(this.btnEvent_MouseUp);
                    Controls.Add(btn[i, j]);
                }
            }

            /** Customizing timer label*/

            lblTimer.Text = "000";
            lblTimer.Location = new Point(565, 0);
            lblTimer.Size = new Size(120, 80);
            lblTimer.TextAlign = ContentAlignment.MiddleRight;
            lblTimer.BackColor = Color.Black;
            lblTimer.ForeColor = Color.Red;
            lblTimer.Font = new Font("Calibri", 40);
            this.Controls.Add(lblTimer);

            /** Customizing bombs label*/
            lblBombs.Text = "50";
            lblBombs.Location = new Point(0, 0);
            lblBombs.Size = new Size(120, 80);
            lblBombs.TextAlign = ContentAlignment.MiddleLeft;
            lblBombs.BackColor = Color.Black;
            lblBombs.ForeColor = Color.Red;
            lblBombs.Font = new Font("Calibri", 40);
            this.Controls.Add(lblBombs);

            stopwatch.Start();
            timer.Start();
            
            //Add a stopwatch.Stop() and timer.Stop() when game ends:
            //lblTime.Text = "You have cleared the minefield in " + stopwatch.Elapsed.Seconds.ToString() + "seconds."; 
        }


        /** Event that happens once the timer reaches the limit of time given*/
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            stopwatch.Stop();

            DialogResult result = MessageBox.Show("Time is due. Would you like to try again ?", "Time's up", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            //lblTimer.Text = Convert.ToString(stopwatch.Elapsed.TotalSeconds);
        }

        /**Controls the click events for the grid*/
        private void btnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:

                    //If clicked on a mistaken bomb, bomb counter increments
                    if (((Button)sender).BackColor == Color.Red)
                    {
                        lblBombs.Text = Convert.ToString((Convert.ToInt32(lblBombs.Text) + 1));
                    }
                    ((Button)sender).BackColor = Color.White;
                    break;


                //If a tile on grid is clicked on with right click, the colour is changed to red
                //When clicked again, it's reverted back to gray.
                case MouseButtons.Right:

                    if (((Button)sender).BackColor == Color.Red)
                    {
                        ((Button)sender).BackColor = Color.LightGray;
                        lblBombs.Text = Convert.ToString((Convert.ToInt32(lblBombs.Text) + 1));
                    }
                    else if (((Button)sender).BackColor == Color.White) ;
                    else
                    {
                        ((Button)sender).BackColor = Color.Red;
                        lblBombs.Text = Convert.ToString((Convert.ToInt32(lblBombs.Text) - 1));
                    }
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
