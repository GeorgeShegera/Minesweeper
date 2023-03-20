using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class CellPoint
    {
        public int X;
        public int Y;
        public CellPoint(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
