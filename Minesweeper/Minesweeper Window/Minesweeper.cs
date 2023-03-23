using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Minesweeper
{
    public partial class MineSweeperWnd : Form
    {        
        public MineSweeperWnd(GameLevel gameLevel = GameLevel.Beginner)
        {
            game = new Game(gameLevel);
            InitializeComponent();
            switch (gameLevel)
            {
                case GameLevel.Beginner:
                    TsiBeginner.Checked = true;
                    break;
                case GameLevel.Intermediate:
                    TsiIntermediate.Checked = true;
                    break;
                case GameLevel.Expert:
                    TsiExpert.Checked = true;
                    break;
            }            
            menuStrip.BackColor = Color.FromArgb(235, 233, 217);
            ReloadWindow();
            // Fonts
            MyFonts = new PrivateFontCollection();
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.mine_sweeper))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                MyFonts.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }
            FieldTimer.Start();
        }

        private void CellButton_Paint(object sender, PaintEventArgs e)
        {
            if (!(sender is Cell cellBtn)) return;
            if (cellBtn.IsDown && cellBtn.VisibleState != CellVisible.Flag)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as Cell).ClientRectangle,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid);
            }
            else if (cellBtn.VisibleState == CellVisible.Open)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as Cell).ClientRectangle,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), 1, ButtonBorderStyle.Solid);
            }
            else if (cellBtn.VisibleState == CellVisible.Hide ||
                     cellBtn.VisibleState == CellVisible.Flag)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as Cell).ClientRectangle,
                Color.FromArgb(255, 255, 255), CellBorderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(255, 255, 255), CellBorderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), CellBorderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(123, 123, 123), CellBorderWidth, ButtonBorderStyle.Solid);
            }
        }

        private void MineSweeperWnd_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(189, 189, 189);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ReloadField();
        }

        private void ReloadWindow()
        {
            // Outter Panel
            OutterPanel.Size = new Size(GetCellsPanelWidth + OutterPanelIndent * 2, UpperPanelHeight + GetCellsPanelHeight + OutterPanelIndent * 3);
            OutterPanel.Location = new Point(0, menuStrip.Height);
            // Window Size
            ClientSize = new Size(OutterPanel.Width, OutterPanel.Height + menuStrip.Height);
            // Cells Panel
            CellsPanel.Width = GetCellsPanelWidth;
            CellsPanel.Height = GetCellsPanelHeight;
            CellsPanel.Location = new Point(OutterPanelIndent, UpperPanelHeight + OutterPanelIndent * 2);
            // Upper Panel
            UpperPanel.Width = GetCellsPanelWidth;
            UpperPanel.Height = UpperPanelHeight;
            UpperPanel.Location = new Point(OutterPanelIndent, OutterPanelIndent);
            // Timer Panel
            List<CounterPictureBox> pictureBoxes = GetCounters();
            TimerPanel = new CounterPanel(pictureBoxes, 0);
            UpperPanel.Controls.Add(TimerPanel);
            TimerPanel.Size = new Size(CounterPanelWidth, CounterPanelHeight);
            TimerPanel.Location = new Point(GetCellsPanelWidth - TimerPanel.Width - UpperPanelIndent, UpperPanelIndent);
            TimerPanel.Controls.AddRange(pictureBoxes.ToArray());
            TimerPanel.Paint += new PaintEventHandler(UpperInnerPanel_Paint);
            // Mines Counter Panel
            pictureBoxes = GetCounters();
            MinesCounterPanel = new CounterPanel(pictureBoxes, game.Mines);
            UpperPanel.Controls.Add(MinesCounterPanel);
            MinesCounterPanel.Size = new Size(CounterPanelWidth, CounterPanelHeight);
            MinesCounterPanel.Location = new Point(UpperPanelIndent, UpperPanelIndent);            
            MinesCounterPanel.Controls.AddRange(pictureBoxes.ToArray());
            MinesCounterPanel.Paint += new PaintEventHandler(UpperInnerPanel_Paint);
            // Smile button 
            BtnSmile.Size = new Size(CounterPanelHeight, CounterPanelHeight);
            BtnSmile.BackColor = Color.FromArgb(123, 123, 123);
            BtnSmile.Location = new Point((GetCellsPanelWidth - CounterPanelHeight) / 2, UpperPanelIndent);
            BtnSmile.Image = Properties.Resources.SimpleSmile;
            Refresh();

            List<CounterPictureBox> GetCounters()
            {
                const int numCount = 3;
                int width = (CounterPanelWidth - UpperPanelBorder * 2) / numCount;
                List<CounterPictureBox> result = new List<CounterPictureBox>();
                for (int i = 0; i < numCount; i++)
                {
                    CounterPictureBox pictureBox = new CounterPictureBox
                    {
                        Size = new Size(width, CounterPanelHeight - UpperPanelBorder * 2),
                        Location = new Point(width * i + UpperPanelBorder, UpperPanelBorder),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = Properties.Resources.Zero
                    };
                    result.Add(pictureBox);
                }
                return result;
            }
        }

        private void ReloadField()
        {
            game.Field = new Field();
            CellsPanel.Controls.Clear();
            for (int i = 0; i < game.Height; i++)
            {
                for (int j = 0; j < game.Width; j++)
                {
                    Cell cell = new Cell
                    {
                        Size = new Size(CellSize, CellSize),
                        BackColor = Color.FromArgb(189, 189, 189),
                        Location = new Point(CellSize * j + CellsPanelBorWidth, CellSize * i + CellsPanelBorWidth),
                        Font = new Font(MyFonts.Families.FirstOrDefault(), 13),
                        UseCompatibleTextRendering = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat,
                        Point = new CellPoint(j, i),
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };
                    cell.TextAlign = ContentAlignment.MiddleCenter;
                    cell.FlatAppearance.BorderSize = 0;
                    cell.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    cell.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    cell.Paint += new PaintEventHandler(CellButton_Paint);
                    cell.MouseUp += new MouseEventHandler(BtnCell_MouseUp);
                    cell.MouseDown += new MouseEventHandler(BtnCell_MouseDown);
                    game.AddCell(cell);
                    CellsPanel.Controls.Add(cell);
                }
            }
            game.RefreshField();
        }

        private void BtnSmile_Paint(object sender, PaintEventArgs e)
        {
            if (SmileBtnDown)
            {
                BtnSmile.Padding = new Padding(4, 4, 0, 0);
                ControlPaint.DrawBorder(e.Graphics, (sender as PictureBox).ClientRectangle,
                   Color.FromArgb(123, 123, 123), 4, ButtonBorderStyle.Solid,
                   Color.FromArgb(123, 123, 123), 4, ButtonBorderStyle.Solid,
                   Color.FromArgb(123, 123, 123), 2, ButtonBorderStyle.Solid,
                   Color.FromArgb(123, 123, 123), 2, ButtonBorderStyle.Solid);
            }
            else
            {
                BtnSmile.Padding = new Padding(0, 0, 0, 0);
                ControlPaint.DrawBorder(e.Graphics, (sender as PictureBox).ClientRectangle,
                   Color.FromArgb(255, 255, 255), 4, ButtonBorderStyle.Solid,
                   Color.FromArgb(255, 255, 255), 4, ButtonBorderStyle.Solid,
                   Color.FromArgb(123, 123, 123), 4, ButtonBorderStyle.Solid,
                   Color.FromArgb(123, 123, 123), 4, ButtonBorderStyle.Solid);
            }
        }

        private void BtnCell_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(FindControlAtCursor(this) is Cell cellButton) || game.EndOfGame()) return;
            if (m_left && m_right)
            {
                game.SmartOpen(cellButton);
                OpenResult();
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (cellButton.IsDown && cellButton.VisibleState == CellVisible.Hide &&
                    (!m_right || !m_left))
                {
                    game.OpenCell(cellButton);
                    OpenResult();
                    cellButton.IsDown = false;
                }
            }
            if (e.Button == MouseButtons.Left)
                m_left = false;
            if (e.Button == MouseButtons.Right)
                m_right = false;

            void OpenResult()
            {
                if (game.State == GameState.Lose) BtnSmile.Image = Properties.Resources.LoseSmile;
                else if (game.State == GameState.Win) BtnSmile.Image = Properties.Resources.WinSmile;
                else BtnSmile.Image = Properties.Resources.SimpleSmile;
            }
        }
        private void BtnCell_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                m_left = true;
            if (e.Button == MouseButtons.Right)
                m_right = true;

            if (!(sender is Cell cellButton) || game.EndOfGame()) return;
            else if (e.Button == MouseButtons.Right && cellButton.VisibleState != CellVisible.Open &&
                    (!m_right || !m_left))
            {
                if (cellButton.VisibleState == CellVisible.Flag)
                {
                    cellButton.VisibleState = CellVisible.Hide;
                    MinesCounterPanel.Number++;
                }
                else if (MinesCounterPanel.Number == 0)
                {                    
                    MessageBox.Show("You don't have flags", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    m_left = false;
                    m_right = false;
                }      
                else if (cellButton.VisibleState == CellVisible.Hide)
                {
                    cellButton.VisibleState = CellVisible.Flag;
                    MinesCounterPanel.Number--;
                }
            }
        }

        private void BtnSmile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            (sender as PictureBox).Invalidate();
            SmileBtnDown = true;
        }

        private void BtnSmile_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            (sender as PictureBox).Invalidate();
            SmileBtnDown = false;
            MinesCounterPanel.Number = game.Mines;
            m_left = false;
            m_right = false;
            game.RefreshField();
        }

        public static Control FindControlAtCursor(Form form)
        {
            Point pos = Cursor.Position;
            if (form.Bounds.Contains(pos))
                return FindControlAtPoint(form, form.PointToClient(pos));
            return null;
        }
        public static Control FindControlAtPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null) return c;
                    else return child;
                }
            }
            return null;
        }

        private Cell prevCellButton = null;
        private List<Cell> neighboringCells = null;
        private bool m_right = false;
        private bool m_left = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (game.EndOfGame()) return;
            Rectangle r = CellsPanel.RectangleToScreen(CellsPanel.ClientRectangle);
            if (r.Contains(MousePosition))
            {
                if (prevCellButton != null) RemovePreviousStyle();
                Control control = FindControlAtCursor(this);
                if (!(control is Cell btnCell)) return;
                if (m_left && m_right)
                {
                    neighboringCells = game.Field.NeighbouringCells(btnCell.Point);
                    foreach (Cell neighborCell in neighboringCells)
                    {
                        neighborCell.IsDown = true;
                        neighborCell.Invalidate();
                    }
                }
                if ((MouseButtons & MouseButtons.Left) != 0)
                {
                    BtnSmile.Image = Properties.Resources.PressingSmile;
                    btnCell.IsDown = true;
                    prevCellButton = btnCell;
                    btnCell.Invalidate();
                }
            }
            else if (prevCellButton != null || neighboringCells != null) RemovePreviousStyle();

            void RemovePreviousStyle()
            {
                if (neighboringCells != null)
                {
                    foreach (Cell neighborCell in neighboringCells)
                    {
                        neighborCell.IsDown = false;
                        neighborCell.Invalidate();
                    }
                }
                neighboringCells = null;
                BtnSmile.Image = Properties.Resources.SimpleSmile;
                prevCellButton.IsDown = false;
                prevCellButton.Invalidate();
                prevCellButton = null;
            }
        }
        private void InnerPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle,
              Color.FromArgb(123, 123, 123), CellsPanelBorWidth, ButtonBorderStyle.Solid,
              Color.FromArgb(123, 123, 123), CellsPanelBorWidth, ButtonBorderStyle.Solid,
              Color.FromArgb(255, 255, 255), CellsPanelBorWidth, ButtonBorderStyle.Solid,
              Color.FromArgb(255, 255, 255), CellsPanelBorWidth, ButtonBorderStyle.Solid);
        }

        private void PanelOutter_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle,
               Color.FromArgb(255, 255, 255), OutterPanelBorWidth, ButtonBorderStyle.Solid,
               Color.FromArgb(255, 255, 255), OutterPanelBorWidth, ButtonBorderStyle.Solid,
               Color.FromArgb(123, 123, 123), OutterPanelBorWidth, ButtonBorderStyle.Solid,
               Color.FromArgb(123, 123, 123), OutterPanelBorWidth, ButtonBorderStyle.Solid);
        }

        private void UpperInnerPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle,
               Color.FromArgb(123, 123, 123), UpperPanelBorder, ButtonBorderStyle.Solid,
               Color.FromArgb(123, 123, 123), UpperPanelBorder, ButtonBorderStyle.Solid,
               Color.FromArgb(255, 255, 255), UpperPanelBorder, ButtonBorderStyle.Solid,
               Color.FromArgb(255, 255, 255), UpperPanelBorder, ButtonBorderStyle.Solid);
        }

        private void MineSweeperWnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) game.RefreshField();
        }

        private void TsiExit_Click(object sender, EventArgs e) => Close();

        private void TsiNew_Click(object sender, EventArgs e) => game.RefreshField();

        private void TsiBeginner_MouseDown(object sender, MouseEventArgs e)
        {
            var thisTsmi = (ToolStripMenuItem)sender;
            var parent = thisTsmi.GetCurrentParent();
            foreach (ToolStripItem tsi in parent.Items)
            {
                if (tsi is ToolStripMenuItem tsmi)
                {
                    tsmi.Checked = thisTsmi == tsmi;
                }
            }
            GameLevel newLevel = new GameLevel();
            if (TsiBeginner.Checked)
            {
                newLevel = GameLevel.Beginner;
            }
            else if (TsiIntermediate.Checked)
            {
                newLevel = GameLevel.Intermediate;
            }
            else if (TsiExpert.Checked)
            {
                newLevel = GameLevel.Expert;
            }
            Hide();
            MineSweeperWnd mineSweeper = new MineSweeperWnd(newLevel);
            mineSweeper.ShowDialog();
            Close();
        }
    }
}
