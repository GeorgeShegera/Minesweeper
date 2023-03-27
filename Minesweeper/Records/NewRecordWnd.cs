using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class NewRecordWnd : Form
    {
        public string PlayerName { get; set; }
        public NewRecordWnd(GameLevel level)
        {
            ControlBox = false;
            InitializeComponent();
            TbName.Text = "Anonymous";
            string gameLevel = "";
            switch (level)
            {
                case GameLevel.Beginner:
                    gameLevel = "Beginner";
                    break;
                case GameLevel.Intermediate:
                    gameLevel = "Intermediate";
                    break;
                case GameLevel.Expert:
                    gameLevel = "Expert";
                    break;
            }
            LbText.Text = $"You have the fastest time\n" +
                          $"for {gameLevel} level\n" +
                          $"Please enter your name";
        }

        private void NewRecordWnd_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
            Color.FromArgb(255, 255, 255), 4, ButtonBorderStyle.Solid,
            Color.FromArgb(255, 255, 255), 4, ButtonBorderStyle.Solid,
            Color.FromArgb(123, 123, 123), 4, ButtonBorderStyle.Solid,
            Color.FromArgb(123, 123, 123), 4, ButtonBorderStyle.Solid);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(TbName.Text.Count() < 3 || TbName.Text.Count() > 12)
            {
                MessageBox.Show("Name must be more than 3 and less than 12", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            PlayerName = TbName.Text;
            Close();
        }
    }
}
