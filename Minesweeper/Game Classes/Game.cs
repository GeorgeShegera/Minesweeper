using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Game
    {
        public GameLevel Level { get; }
        public int Height { get; }
        public int Width { get; }
        public int Mines { get; }
        public Field Field { get; set; } = new Field();
        public GameState State { get; set; } = GameState.InProgress;
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

        public void RefreshField()
        {            
            State = GameState.InProgress;
            Field.Clear();
            Field.Fill(Mines, Height, Width);
        }

        public void OpenCell(Cell cell)
        {
            Field.OpenCell(cell);
            if (cell.Type == TypeOfCell.Mine)
            {
                cell.BackgroundImage = Properties.Resources.TriggeredMine;
                GameLose();
            }
            else if (CheckWin())
            {
                GameWin();
            }
        }

        public void SmartOpen(Cell cell)
        {
            if (cell.Type != TypeOfCell.Number || cell.VisibleState != CellVisible.Open) return;
            List<Cell> neighboringCells = Field.NeighbouringCells(cell.Point);
            int flags = neighboringCells.Where(x => x.VisibleState == CellVisible.Flag).Count();
            if (flags == cell.Number)
            {
                neighboringCells.ForEach((neigbCell) => 
                {
                    if(neigbCell.VisibleState != CellVisible.Flag)
                    OpenCell(neigbCell);
                });
            }
        }

        public void GameLose()
        {
            State = GameState.Lose;
            foreach (List<Cell> cells in Field.Cells)
            {
                foreach (Cell cell in cells)
                {
                    if (cell.VisibleState == CellVisible.Hide && cell.Type == TypeOfCell.Mine)
                    {
                        cell.VisibleState = CellVisible.Open;
                    }
                    else if (cell.VisibleState == CellVisible.Flag && cell.Type != TypeOfCell.Mine)
                    {
                        cell.VisibleState = CellVisible.Open;
                        cell.Text = "";
                        cell.BackgroundImage = Properties.Resources.WrongMine;
                    }
                }
            }
        }

        public void GameWin()
        {
            State = GameState.Win;
            foreach (List<Cell> cells in Field.Cells)
            {
                foreach (Cell cell in cells)
                {
                    if (cell.VisibleState == CellVisible.Hide && cell.Type == TypeOfCell.Mine)
                        cell.VisibleState = CellVisible.Flag;
                }
            }
        }

        public bool CheckWin() => !Field.Cells.Any(x => x.Any(y =>
                                        y.Type != TypeOfCell.Mine && y.VisibleState != CellVisible.Open));

        public bool EndOfGame() => State != GameState.InProgress;
    }
}
