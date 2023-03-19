using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Field
    {
        public List<List<Cell>> Cells { get; set; }
        public static readonly Color colorOne = Color.FromArgb(0, 38, 246);
        public static readonly Color colorTwo = Color.FromArgb(13, 127, 25);
        public static readonly Color colorThree = Color.FromArgb(246, 0, 18);
        public static readonly Color colorFour = Color.FromArgb(0, 14, 124);
        public static readonly Color colorFive = Color.FromArgb(124, 0, 6);
        public static readonly Color colorSix = Color.FromArgb(11, 130, 125);
        public static readonly Color colorSeven = Color.FromArgb(0, 0, 0);
        public static readonly Color colorEight = Color.FromArgb(128, 128, 128);

        public Field()
        {
            Cells = new List<List<Cell>>();
        }

        public void AddCell(Cell cell, int width)
        {
            if (Cells.Count != 0 && Cells.Last().Count < width) Cells.Last().Add(cell);
            else Cells.Add(new List<Cell> { cell });
        }

        public void Fill(int mines, int height, int width)
        {
            int coordX;
            int coordY;
            Random rnd = new Random();
            for (int i = 0; i < mines; i++)
            {
                do
                {
                    coordX = rnd.Next(0, width);
                    coordY = rnd.Next(0, height);
                } while (Cells[coordY][coordX].Type == TypeOfCell.Mine);
                Cells[coordY][coordX].Type = TypeOfCell.Mine; 
            }
            for (int i = 0; i < Cells.Count; i++)
            {
                for (int j = 0; j < Cells[i].Count; j++)
                {
                    if (Cells[i][j].Type == TypeOfCell.Empty)
                    {
                        int number = DetermineNumber(i, j);
                        Cells[i][j].Number = number;
                        Cells[i][j].Type = number > 0 ? TypeOfCell.Number : TypeOfCell.Empty;
                    }
                }
            }
        }

        public int DetermineNumber(int coordX, int coordY)
        {
            int count = 0;
            for (int i = coordX - 1; i < coordX + 2; i++)
            {
                for (int j = coordY - 1; j < coordY + 2; j++)
                {                    
                    if (i >= 0 && j >= 0 && i < Cells.Count && j < Cells.First().Count && 
                        Cells[i][j].Type == TypeOfCell.Mine) count++;
                }
            }
            return count;
        }
    }
}
