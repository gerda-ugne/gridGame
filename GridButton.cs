using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_Game
{
    /**A class of a button to have the properties (i.e. number of a row and a column) of each button definied*/
    class GridButton : Button
    {
        //Fields
        public int row { get; set; }
        public int column { get; set; }

        /** A constructor*/
        public GridButton(int r, int c)
        {
            row = r;
            column = c;
        }


    }
}
