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

        public static GameRecord GetRecord(GameLevel level)
        {
            switch (level)
            {
                case GameLevel.Beginner: return Records[0];
                case GameLevel.Intermediate: return Records[1];
                case GameLevel.Expert: return Records[2];
                default: return null;
            }
        }
        public static void SetRecord(GameRecord record)
        {
            switch (record.Level)
            {
                case GameLevel.Beginner:
                    Records[0] = record;
                    break;
                case GameLevel.Intermediate:
                    Records[1] = record;
                    break;
                case GameLevel.Expert:
                    Records[2] = record;
                    break;
            }
        }

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
