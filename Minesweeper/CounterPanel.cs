using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class CounterPanel : Panel
    {
        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                if (PictureBoxes == null || value > 999) return;
                number = value;
                for (int i = PictureBoxes.Count - 1; i >= 0; i--)
                {
                    int digit = value % 10;
                    value /= 10;
                    PictureBoxes[i].Number = digit;
                }
            }
        }
        List<CounterPictureBox> PictureBoxes { get; set; }
        public CounterPanel(List<CounterPictureBox> pictureBoxes, int value)
        {
            PictureBoxes = pictureBoxes;
            Number = value;
        }
        public CounterPanel() : this(null, 0) { }
    }
}
