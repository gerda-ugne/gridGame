using Microsoft.Win32;
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
    public partial class TimerTest : Form
    {
        private int timerCount;

        public TimerTest()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            label2.Text = timerCount.ToString();
        }

        private void TimerTest_Load(object sender, EventArgs e)
        {
           timerCount = 0;
           timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
