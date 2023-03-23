using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class CounterPictureBox : PictureBox
    {
        private int number;
        public int Number
        {
            get => number;
            set
            {
                if (value < 0 || value > 9) return;
                number = value;
                switch (number)
                {
                    case 0:
                        Image = Properties.Resources.Zero;
                        break;
                    case 1:
                        Image = Properties.Resources.One;
                        break;
                    case 2:
                        Image = Properties.Resources.Two;
                        break;
                    case 3:
                        Image = Properties.Resources.Three;
                        break;
                    case 4:
                        Image = Properties.Resources.Four;
                        break;
                    case 5:
                        Image = Properties.Resources.Five;
                        break;
                    case 6:
                        Image = Properties.Resources.Six;
                        break;
                    case 7:
                        Image = Properties.Resources.Seven;
                        break;
                    case 8:
                        Image = Properties.Resources.Eight;
                        break;
                    case 9:
                        Image = Properties.Resources.Nine;
                        break;
                }
            }
        }
        public CounterPictureBox(int value = 0) : base()
        {
            number = value;
        }
    }
}
