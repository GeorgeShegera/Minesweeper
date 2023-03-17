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
                number = value;
                switch (number)
                {
                    case 0:
                        Image = Properties.Resources.Zero;
                        break;
                    case 1:
                        {
                        }
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
