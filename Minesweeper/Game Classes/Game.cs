using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Game
    {
        public GameLevel Level { get; set; }
        public int Height { get; }
        public int Width { get; }
        public int Mines { get; }
        public Field Field { get; set; } = new Field();
        public Game(GameLevel level)
        {
            switch (level)
            {
                case GameLevel.Beginner:
                    {
                        Height = 9;
                        Width = 9;
                        Mines = 10;
                    }
                    break;
                case GameLevel.Intermediate:
                    {
                        Height = 16;
                        Width = 16;
                        Mines = 40;
                    }
                    break;
                case GameLevel.Expert:
                    {
                        Height = 16;
                        Width = 30;
                        Mines = 99;
                    }
                    break;
            }
        }
        public void AddCell(Cell cell) => Field.AddCell(cell, Width);
        public void RefreshField() => Field.Fill(Mines, Height, Width);
    }
}
