using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickmanFight
{
    public class GameEngine
    {
        public Fighter FirstFighter { get; set; }
        public Fighter SecondFighter { get; set; }

        public GameEngine()
        {
            FirstFighter = new Fighter(name: "Niggatchu");
            SecondFighter = new Fighter(name: "Pikachu");
        }
    }
}
