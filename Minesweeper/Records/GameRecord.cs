using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Minesweeper
{
    public class GameRecord
    {
        public GameLevel Level { get; set; }
        public int Time { get; set; }
        public string PlayerName { get; set; }
        public GameRecord(GameLevel level = new GameLevel(), int time = 999, string name = "Anonymous")
        {
            Level = level;
            Time = time;
            PlayerName = name;            
        }
    }
}
