﻿using System;
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
                if (value == CellState.Open)
                {
                    if (Type == TypeOfCell.Number) Text = Number.ToString();
                    else if (Type == TypeOfCell.Mine) Image = Properties.Resources.SimpleSmile;
                }
                Invalidate();
                state = value;
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

        public Cell(int value = 0, TypeOfCell type = TypeOfCell.Empty) : base()
        {
            Number = value;
            Type = type;
            state = CellState.Hide;
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
