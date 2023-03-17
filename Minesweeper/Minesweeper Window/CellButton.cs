using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class CellButton : Button
    {
        public CellButton() : base()
        {
            SetStyle(ControlStyles.Selectable, false);
        }        
    }
}
