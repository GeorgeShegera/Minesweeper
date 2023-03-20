using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
        public CellPoint Point { get; set; }
        private CellVisible visibleState;
        public CellVisible VisibleState
        {
            get => visibleState;
            set
            {
                if (value == CellVisible.Open)
                {
                    switch (Type)
                    {
                        case TypeOfCell.Number:
                            Text = Number.ToString();
                            break;
                        case TypeOfCell.Mine:
                            BackgroundImage = Properties.Resources.SimpleSmile;
                            break;
                    }
                }
                else if(value == CellVisible.Flag)
                {
                    
                    BackgroundImage = Properties.Resources.Flag;
                }
                else if(value == CellVisible.Hide)
                {
                    BackgroundImage = null;
                }
                Invalidate();
                visibleState = value;
            }
        }
        public TypeOfCell Type { get; set; }

        private int number;
        public int Number
        {
            get => number;
            set
            {
                switch (value)
                {
                    case 1:
                        ForeColor = Field.colorOne;
                        break;
                    case 2:
                        ForeColor = Field.colorTwo;
                        break;
                    case 3:
                        ForeColor = Field.colorThree;
                        break;
                    case 4:
                        ForeColor = Field.colorFour;
                        break;
                    case 5:
                        ForeColor = Field.colorFive;
                        break;
                    case 6:
                        ForeColor = Field.colorSix;
                        break;
                    case 7:
                        ForeColor = Field.colorSeven;
                        break;
                    case 8:
                        ForeColor = Field.colorEight;
                        break;
                }
                number = value;
            }
        }

        public object CellState { get; internal set; }

        public Cell(int value = 0, TypeOfCell type = TypeOfCell.Empty, CellPoint cellPoint = default)
            : base()
        {
            Point = cellPoint;
            Number = value;
            Type = type;
            visibleState = CellVisible.Hide;
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
