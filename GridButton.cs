using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Game
{
    class GridButton : Button
    {
        //Fields
        // NEEDS A REFERENCE
        public int row { get; set; }
        public int column { get; set; }

        // A constructor
        public GridButton(int r, int c)
        {
            row = r;
            column = c;
        }


    }
}

