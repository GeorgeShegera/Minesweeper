using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
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
        private int InnerPanelBorWidth { get; } = 5;
        private int OuterPanelBorWidth { get; } = 5;
        private int CellBorderWidth { get; } = 4;
        private int ButtonSize { get; } = 30;
        private int Indent { get; } = 15;
        private int UpperPanelHeight { get; } = 60;
        private PrivateFontCollection MyFonts { get; }
        private int GetPanelWidth { get => game.Width * ButtonSize + InnerPanelBorWidth * 2; }
        private int GetPanelHeight { get => game.Height * ButtonSize + InnerPanelBorWidth * 2; }

        public MineSweeperWnd()
        {

            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(235, 233, 217);
            // Outer Panel
            PanelOuter.Size = new Size(GetPanelWidth + Indent * 2, UpperPanelHeight + GetPanelHeight + Indent * 3);
            PanelOuter.Location = new Point(0, menuStrip1.Height);
            // Inner Panel
            InnerPanel.Width = GetPanelWidth;
            InnerPanel.Height = GetPanelHeight;
            InnerPanel.Location = new Point(Indent, UpperPanelHeight + Indent * 2);
            // Upper Panel
            UpperPanel.Width = GetPanelWidth;
            UpperPanel.Height = UpperPanelHeight;
            UpperPanel.Location = new Point(Indent, Indent);
            // Window Size
            ClientSize = new Size(PanelOuter.Width, PanelOuter.Height + menuStrip1.Height);
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
                        Size = new Size(ButtonSize, ButtonSize),
                        BackColor = Color.FromArgb(189, 189, 189),
                        Location = new Point(ButtonSize * j + InnerPanelBorWidth, ButtonSize * i + InnerPanelBorWidth),
                        Font = new Font(MyFonts.Families.FirstOrDefault(), Font.Size),
                        UseCompatibleTextRendering = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat
                    };
                    helloButton.FlatAppearance.BorderSize = 0;
                    helloButton.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
                    helloButton.Paint += new PaintEventHandler(CellButton_Paint);
                    InnerPanel.Controls.Add(helloButton);
                }
            }
        }

        private void PanelCells_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle,
              Color.FromArgb(123, 123, 123), InnerPanelBorWidth, ButtonBorderStyle.Solid,
              Color.FromArgb(123, 123, 123), InnerPanelBorWidth, ButtonBorderStyle.Solid,
              Color.FromArgb(255, 255, 255), InnerPanelBorWidth, ButtonBorderStyle.Solid,
              Color.FromArgb(255, 255, 255), InnerPanelBorWidth, ButtonBorderStyle.Solid);
        }

        private void PanelOuter_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle,
               Color.FromArgb(255, 255, 255), OuterPanelBorWidth, ButtonBorderStyle.Solid,
               Color.FromArgb(255, 255, 255), OuterPanelBorWidth, ButtonBorderStyle.Solid,
               Color.FromArgb(123, 123, 123), OuterPanelBorWidth, ButtonBorderStyle.Solid,
               Color.FromArgb(123, 123, 123), OuterPanelBorWidth, ButtonBorderStyle.Solid);
        }
    }
}
