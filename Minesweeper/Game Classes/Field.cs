using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Minesweeper
{
    internal class Field
    {
        public List<List<Cell>> Cells { get; set; }
        public List<CellPoint> MinesPoints { get; set; }

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
            MinesPoints = new List<CellPoint>();
        }

        public void AddCell(Cell cell, int width)
        {
            if (Cells.Count != 0 && Cells.Last().Count < width) Cells.Last().Add(cell);
            else Cells.Add(new List<Cell> { cell });            
        }

        public void Fill(int mines, int height, int width)
        {            
            Random rnd = new Random();
            for (int i = 0; i < mines; i++)
            {
                CellPoint point = new CellPoint();
                do
                {
                    point.X = rnd.Next(0, width);
                    point.Y = rnd.Next(0, height);
                } while (Cells[point.Y][point.X].Type == TypeOfCell.Mine);
                Cells[point.Y][point.X].Type = TypeOfCell.Mine;
                MinesPoints.Add(point);
            }
            foreach (List<Cell> cells in Cells)
            {
                foreach (Cell cell in cells)
                {
                    cell.Enabled = true;
                    if (cell.Type == TypeOfCell.Empty)
                    {
                        int number = CountNeighboringMines(cell.Point);
                        cell.Number = number;
                        cell.Type = number > 0 ? TypeOfCell.Number : TypeOfCell.Empty;
                    }                    
                }
            }
        }

        public void Clear()
        {
            foreach (List<Cell> cells in Cells)
            {
                foreach (Cell cell in cells)
                {
                    cell.Type = TypeOfCell.Empty;
                    cell.Number = 0;
                    cell.VisibleState = CellVisible.Hide;
                    cell.Text = "";
                }
            }
        }

        public int CountNeighboringMines(CellPoint point)
        {
            int count = 0;
            List<Cell> neighbouringCells = NeighbouringCells(point);
            foreach (Cell neighboringCell in neighbouringCells)
                if (neighboringCell.Type == TypeOfCell.Mine) count++;
            return count;
        }

        public void OpenCell(Cell cell)
        {
            if (cell.VisibleState != CellVisible.Hide) return;
            cell.VisibleState = CellVisible.Open;
            if (cell.Type == TypeOfCell.Mine) return;
            List<Cell> neighboringCells = NeighbouringCells(cell.Point);
            if (!neighboringCells.Any(x => x.Type == TypeOfCell.Mine))
            {
                foreach (Cell neighboringCell in neighboringCells)
                    OpenCell(neighboringCell);
            }
        }

        private bool ValidatePoint(CellPoint point)
            => point.Y >= 0 && point.X >= 0 && point.Y < Cells.Count && point.X < Cells.First().Count;

        public List<Cell> NeighbouringCells(CellPoint point)
        {
            List<Cell> neighbouringCells = new List<Cell>();
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    CellPoint newPoint = new CellPoint(point.X + j, point.Y + i);
                    if (i == 0 && j == 0 || !ValidatePoint(newPoint)) continue;
                    neighbouringCells.Add(Cells[newPoint.Y][newPoint.X]);
                }
            }
            return neighbouringCells;
        }

        public Cell this[CellPoint point]
        {
            set
            {
                if (ValidatePoint(point))
                    Cells[point.Y][point.X] = value;
                else
                    throw new IndexOutOfRangeException();
            }
            get
            {
                if (ValidatePoint(point))
                    return Cells[point.Y][point.X];
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
