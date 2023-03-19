using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class Field
    {
        public List<Cell> Cells { get; set; }
        public static readonly Color oneColor = Color.FromArgb(0, 38, 246);
        
    }
}
