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
    public partial class Minesweeper : Form
    {

        //Edit the size depending on difficulty
        //The 2D grid 
        //The buttons are of a GridButton data type
        GridButton[,] btn = new GridButton[10, 10];

        //A grid under the buttons
        Label[,] lowerGrid = new Label[10, 10];
        //Bomb image
        Image img = Image.FromFile("b.png");
        Random r = new Random();


        public Minesweeper()
        {
            InitializeComponent();

            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new GridButton(i, j);
                    btn[i, j].row = i;
                    btn[i, j].column = j;
                    btn[i, j].SetBounds(90 + (50 * i), 100 + (50 * j), 45, 45);
                    btn[i, j].BackColor = Color.LightGray;
                    btn[i, j].MouseUp += new MouseEventHandler(this.btnEvent_MouseUp);

                    Controls.Add(btn[i, j]);

                }
            }
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
                    lowerGrid[i, j].SetBounds(90 + (50 * i), 100 + (50 * j), 45, 45);
                    lowerGrid[i, j].BackColor = Color.White;
                    Controls.Add(lowerGrid[i, j]);
                }
            }
        }

        //Randomly placing bombs on a grid
        private void placeBombs()
        {

            int x = 0;
            int k, l;

            //beginner's level: generating 10 bombs that are randomly placed
            //on a grid
            while (x < 10)
            {
                k = r.Next(9);
                l = r.Next(9);

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

                //calling a methods to surround a button with numbers
                surroundBombWithNumbers( k, l);
                x++;

            }
            
        }

        //Surrounding a bomb with numbers
        // k - a column number
        // l - a row number
        void surroundBombWithNumbers( int k, int l)
        {
            for (int i = k - 1; i <= k + 1; i++)
            {
                for (int j = l - 1; j <= l + 1; j++)
                {
                    //If coordinates are out of bound, skip
                    if (i == -1 || j == -1)
                        continue;
                    //If coordinates matches those of a bomb, skip
                    else if (i == k && j == l)
                        continue;
                    //If the cell already contains another bomb, skip
                    else if (btn[i, j].Text.Equals("*"))
                        continue;
                    else
                    {
                        //generates a random number from 1-3
                        int n = r.Next(1, 4);

                        //the random number is written on a button in the same color as the button itself so that it would not be 
                        //visible for a user
                        btn[i, j].Text = Convert.ToString(n);
                        btn[i, j].ForeColor = Color.LightGray; ;

                        //the same random number is written on a label that is under a button
                        lowerGrid[i, j].Text = Convert.ToString(n);
                        lowerGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }

        }

        //Placing random numbers from 1-3 on a grid
        private void placeNumbers()
        {
            int y = 0;
            int k, l;

            //There are 10 random number generated and placed on a grid
            while (y < 10)
            {
                //generates random coordinates from 0-9
                k = r.Next(9);
                l = r.Next(9);

                //if a button has a bomb indication, skip
                if (btn[k, l].Text.Equals("*"))
                    continue;
                //generates a random number from 1-3
                int n = r.Next(1, 4);

                //the random number is written on a button in the same color as the button itself so that it would not be 
                //visible for a user
                btn[k, l].Text = Convert.ToString(n);
                btn[k, l].ForeColor = Color.LightGray;

                //the same random number is written on a label that is under a button
                lowerGrid[k, l].Text = Convert.ToString(n);
                lowerGrid[k, l].TextAlign = ContentAlignment.MiddleCenter;

                y++;
            }
            
        }


        //Controls the click events for the grid
        private void btnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            //A text indication of a button that there is a bomb under itself
            string text = "*";

            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:
                    //If a button has an idication of a bomb
                    if (text.Equals(((GridButton)sender).Text))
                    {
                        //((Button)sender).Hide();

                        //Calling a method to show all labels under all buttons (= Game has ended)
                        uncoverAllGrid();
                    }
                    /* THIS STEP DOES NOT WORK BECAUSE ALL CELLS ARE UNCOVERED EXCEPT THE BOMBS
                     * 
                    //If there is no text on a button 
                    else if (((GridButton)sender).Text.Equals("1") == false && ((GridButton)sender).Text.Equals("2") == false
                        && ((GridButton)sender).Text.Equals("3") == false)
                    {
                        //Creating a temp variable to get the number of a row and column of that specific button
                        GridButton tempBtn = (GridButton)sender;
                       // Console.WriteLine(tempBtn.row + " " + tempBtn.col);

                        //Calling a method to uncover the neighbours of an empty cell - NOT WORKING YET
                        uncoverPartOfGrid(tempBtn.row, tempBtn.column);

                    }*/
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
                    if (((GridButton)sender).BackColor == Color.Red) ((GridButton)sender).BackColor = Color.LightGray;
                    else
                    {
                        //Creating a temp variable to get the number of a row and a column of that specific button
                        GridButton tempBtn = (GridButton)sender;
                        
                        //Setting the color of a label which is under the button to be red so that when all cells are dispayed
                        // a player could see his/her "red flags"
                        lowerGrid[tempBtn.row, tempBtn.column].BackColor = Color.Red;
                        ((GridButton)sender).BackColor = Color.Red;
                        ((GridButton)sender).ForeColor = Color.Red;

                    }
                    break;

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
            if (btn[i, j].Text.Equals("*") == true || btn[i, j].BackColor.Equals(Color.White) == true)
                return;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
