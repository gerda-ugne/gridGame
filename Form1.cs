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
                }
            }
        }

        //Controls the click events for the grid
        private void btnEvent_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                //If a tile on grid is clicked on with left click, the colour is changed to white
                case MouseButtons.Left:
                    ((Button)sender).BackColor = Color.White;
                    break;


                //If a tile on grid is clicked on with right click, the colour is changed to red
                //When clicked again, it's reverted back to gray.
                case MouseButtons.Right:
                    if (((Button)sender).BackColor == Color.Red) ((Button)sender).BackColor = Color.LightGray;
                    else ((Button)sender).BackColor = Color.Red;
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
