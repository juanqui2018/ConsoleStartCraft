using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft.Engine
{
    public class Player
    {
        public string Nick { get; set; }

        public Races SelectedRace { get; set; }

        public int ProbabilityWinning { get; set; }

        public int Wins { get; set; }

        public Player()
        {
            Wins = 0;
        }
    }
}
