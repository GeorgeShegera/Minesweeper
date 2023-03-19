using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Minesweeper
{
    internal class Cell : Button
    {
        public bool IsDown { get; set; } = false;
        private CellState state;
        public CellState State
        {
            get => state;
            set
            {
                if (value == CellState.Open) Text = Value.ToString();
                state = value;
            }
        }
        public СellСontent Content { get; set; } = СellСontent.Number;
        public int Value { get; set; } = 1;
        public Cell() : base()
        {
            state = CellState.Hide;
            if (Content == СellСontent.Number)
            {
                switch (Value)
                {
                    case 1:
                        ForeColor = Field.oneColor;
                        break;
                    case 2:
                        ForeColor = Field.oneColor;
                        break;
                }
            }
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
