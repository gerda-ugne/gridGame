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
        Button[,] btn = new Button[10, 10];

        Label[,] lowerGrid = new Label[10, 10];
        Image img = Image.FromFile("b.jpg");
        Random r = new Random();
        public Minesweeper()
        {
            InitializeComponent();

            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(90 + (50 * i), 100 + (50 * j), 45, 45);
                    btn[i, j].BackColor = Color.LightGray;
                    btn[i, j].MouseUp += new MouseEventHandler(this.btnEvent_MouseUp);
                    Controls.Add(btn[i, j]);

                    //bombs[i, j] = new Label();
                    //bombs[i, j].SetBounds(90 + (50 * i), 100 + (50 * j), 45, 45);
                    //bombs[i, j].BackColor = Color.AntiqueWhite;

                    //bombs[i, j].Image = img;
                    //Controls.Add(bombs[i, j]);
                }
            }
            placeBombs();
        }

        //need a separate for bombs and numbers
        private void placeBombs()
        {
            
            int x = 0;
            int y = 0;
            int k, l;

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
            //beginner's level: generating 15 bombs that are randomly placed
            //on a grid
            while (x < 15)
            {
                k = r.Next(9);
                l = r.Next(9);

                //putting an image under the button
                lowerGrid[k, l].Image = img;
                //adding a text that is not visible on a button indicating
                //an existence of a bomb under that particular button
                btn[k, l].Text = "*";
                btn[k, l].ForeColor = Color.LightGray;
                x++;
               fillSurroundingArea(btn, k, l);
            }

            while (y < 25)
            {
                k = r.Next(9);
                l = r.Next(9);

                if (btn[k, l].Text.Equals("*"))
                    continue;
                int n = r.Next(1, 4);
                btn[k, l].Text = Convert.ToString(n);
                btn[k, l].ForeColor = Color.LightGray;
                lowerGrid[k, l].Text = Convert.ToString(n);
                lowerGrid[k, l].TextAlign = ContentAlignment.MiddleCenter;

                y++;
            }
        }

        void fillSurroundingArea(Button[,] btn, int k, int l)
        { 
            for(int i=k-1; i<k+2;i++)
            {
                for (int j = l-1; j< l+2; j++)
                {
                    if (i == -1 || j == -1)
                        continue;
                    else if (i == k && j == l)
                        continue;

                    int n = r.Next(1, 4);
                    btn[i, j].Text = Convert.ToString(n);
                    btn[i, j].ForeColor = Color.LightGray; ;
                    lowerGrid[i, j].Text = Convert.ToString(n);
                    lowerGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        
        }
          

        //Controls the click events for the grid
        private void btnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            string text = "*";
            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:
                    if (text.Equals(((Button)sender).Text))
                    {
                        ((Button)sender).Hide();
                        uncoverAllGrid();
                    }
                    else if (((Button)sender).Text.Equals(""))
                    { 
                        uncoverPartOfGrid((Button)sender);
                    }
                    else
                    {
                        ((Button)sender).BackColor = Color.White;
                        ((Button)sender).ForeColor = Color.DarkViolet;
                    }
                    
                    break;


                //If a tile on grid is clicked on with right click, the colour is changed to red
                //When clicked again, it's reverted back to gray.
                case MouseButtons.Right:
                    if (((Button)sender).BackColor == Color.Red) ((Button)sender).BackColor = Color.LightGray;
                    else ((Button)sender).BackColor = Color.Red;
                    break;

            }
            
        }


        void uncoverAllGrid()
        {
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    
                    btn[i, j].Hide();
                    
                }
            }
        }

        void uncoverPartOfGrid(object e)
        {
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
