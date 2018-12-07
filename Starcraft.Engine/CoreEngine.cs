using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft.Engine
{
    public static class CoreEngine
    {
        public static Player GetWinner(List<Player> probabilities)
        {
            var winningIndex = new Random().Next(0, 99);

            return probabilities[winningIndex];
        }
        //crear los jugadores con factory
        public static List<Player> SetProbability(List<Player> players)
        {
            Random ran = new Random();

            players[0].ProbabilityWinning = ran.Next(1, 100);
            players[1].ProbabilityWinning = 100 - players[0].ProbabilityWinning;

            List<Player> probablities = new List<Player>();
            foreach (var player in players)
            {
                for (int i = 0; i < player.ProbabilityWinning; i++)
                {
                    probablities.Add(player);
                }
            }

            return probablities;
        }
    }
}
