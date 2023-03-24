using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minesweeper.Program;

namespace Minesweeper
{
    public partial class RecordsWnd : Form
    {
        public RecordsWnd()
        {
            InitializeComponent();
            for (int i = 0; i < TlbRecords.RowCount; i++)
            {
                for (int j = 0; j < TlbRecords.ColumnCount; j++)
                {
                    string text = "";
                    if (j == 0)
                    {
                        switch (Records[i].Level)
                        {
                            case GameLevel.Beginner:
                                text = "Beginner";
                                break;
                            case GameLevel.Intermediate:
                                text = "Intermediate";
                                break;
                            case GameLevel.Expert:
                                text = "Expert";
                                break;
                        }
                    }
                    else if (j == 1) text = $"{Records[i].Time} seconds";
                    else text = Records[i].PlayerName;
                    TlbRecords.Controls.Add(new Label
                    {
                        Text = text,
                        Font = new Font("Microsoft Sans Serif", 10),
                        TextAlign = ContentAlignment.MiddleLeft
                    }, j, i);
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
