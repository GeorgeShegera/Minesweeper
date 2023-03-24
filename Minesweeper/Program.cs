using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal static class Program
    {
        public static List<GameRecord> Records = new List<GameRecord>
        {
            new GameRecord(GameLevel.Beginner),
            new GameRecord(GameLevel.Intermediate),
            new GameRecord(GameLevel.Expert)
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MineSweeperWnd());
        }
    }
}
