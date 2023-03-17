using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MineSweeperWnd : Form
    {
        private readonly Game game = new Game(GameLevel.Beginner);
        private int CellsPanelBorWidth { get; } = 5;
        private int OutterPanelBorWidth { get; } = 5;
        private int CellBorderWidth { get; } = 4;
        private int CellSize { get; } = 30;
        private int OutterPanelIndent { get; } = 15;
        private int UpperPanelHeight { get; } = 60;
        private int CounterPanelHeight { get; } = 40;
        private int UpperPanelBorder { get; } = 3;
        private int CounterPanelWidth { get => CounterPanelHeight * 23 / 13; }
        private int GetCellsPanelWidth { get => game.Width * CellSize + CellsPanelBorWidth * 2; }
        private int GetCellsPanelHeight { get => game.Height * CellSize + CellsPanelBorWidth * 2; }
        private int UpperPanelIndent { get => (UpperPanelHeight - CounterPanelHeight) / 2; }
        private PrivateFontCollection MyFonts { get; }

        public MineSweeperWnd()
        {

            InitializeComponent();
            menuStrip.BackColor = Color.FromArgb(235, 233, 217);
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
            PanelTimer.Size = new Size(CounterPanelWidth, CounterPanelHeight);
            PanelTimer.Location = new Point(GetCellsPanelWidth - PanelTimer.Width - UpperPanelIndent, UpperPanelIndent);
            // Mines Panel
            MinesCounterPanel.Size = new Size(CounterPanelWidth, CounterPanelHeight);
            MinesCounterPanel.Location = new Point(UpperPanelIndent, UpperPanelIndent);
            //
            const int numCount = 3;
            int width = (CounterPanelWidth - UpperPanelBorder * 2) / numCount;

            PanelTimer.Controls.AddRange(GetCounters().ToArray());
            MinesCounterPanel.Controls.AddRange(GetCounters().ToArray());
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

            List<CounterPictureBox> GetCounters()
            {
                List<CounterPictureBox> result = new List<CounterPictureBox>();
                for (int i = 0; i < numCount; i++)
                {
                    CounterPictureBox pictureBox = new CounterPictureBox
                    {
                        Size = new Size(width, CounterPanelHeight - UpperPanelBorder * 2),
                        Location = new Point(width * i + UpperPanelBorder, UpperPanelBorder),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = Properties.Resources.Nine
                    };
                    result.Add(pictureBox);
                }
                return result;
            }
        }

        private void CellButton_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Button).ClientRectangle,
            Color.FromArgb(255, 255, 255), CellBorderWidth, ButtonBorderStyle.Solid,
            Color.FromArgb(255, 255, 255), CellBorderWidth, ButtonBorderStyle.Solid,
            Color.FromArgb(123, 123, 123), CellBorderWidth, ButtonBorderStyle.Solid,
            Color.FromArgb(123, 123, 123), CellBorderWidth, ButtonBorderStyle.Solid);
        }

        private void MineSweeperWnd_Load(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(189, 189, 189);
            FormBorderStyle = FormBorderStyle.FixedSingle;

            for (int i = 0; i < game.Height; i++)
            {
                for (int j = 0; j < game.Width; j++)
                {
                    CellButton helloButton = new CellButton
                    {
                        Size = new Size(CellSize, CellSize),
                        BackColor = Color.FromArgb(189, 189, 189),
                        Location = new Point(CellSize * j + CellsPanelBorWidth, CellSize * i + CellsPanelBorWidth),
                        Font = new Font(MyFonts.Families.FirstOrDefault(), Font.Size),
                        UseCompatibleTextRendering = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat
                    };
                    helloButton.FlatAppearance.BorderSize = 0;
                    helloButton.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
                    helloButton.Paint += new PaintEventHandler(CellButton_Paint);
                    CellsPanel.Controls.Add(helloButton);
                }
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
    }
}
