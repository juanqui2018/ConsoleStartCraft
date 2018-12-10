using Starcraft.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Starcraft.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(CreatePlayer());
            players.Add(CreatePlayer());

            var probabilities = CoreEngine.SetProbability(players);

            LogPlayers(players);

            for (int gameNumber = 0; gameNumber < 100; gameNumber++)
            {
                var winningPlayer = CoreEngine.GetWinner(probabilities);
                winningPlayer.Wins++;
                Console.WriteLine($"\tGAME {gameNumber} STARTED!");
                Console.WriteLine($"{winningPlayer.SelectedRace.Name} recollect {winningPlayer.SelectedRace.Recollect} ");
                Thread.Sleep(300);
                Console.WriteLine($"Game {gameNumber} finished. The winner is {winningPlayer.Nick}!!\n");
                LogGame(winningPlayer, gameNumber);
            }

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Nick} won {player.Wins} times. ({player.ProbabilityWinning})");
            }

            Console.ReadKey();
        }

        private static void LogGame(Player winningPlayer, int gameNumber)
        {
            using (StreamWriter sw = File.AppendText("c:\\StarcraftLog.txt"))
            {
                sw.WriteLine($"{DateTime.Now.ToString("s")}: Game {gameNumber} winner: {winningPlayer.Nick}");
                sw.Close();
            }
        }

        private static void LogPlayers(List<Player> players)
        {
            if (!File.Exists("c:\\StarcraftLog.txt"))
            {
                using (var fileCreated = File.Create("c:\\StarcraftLog.txt"))
                { fileCreated.Close(); }
            }

            using (StreamWriter sw = File.AppendText("c:\\StarcraftLog.txt"))
            {
                foreach (var player in players)
                {
                    sw.WriteLine($"Nick: {player.Nick} - Race: {player.SelectedRace} - Probability: {player.ProbabilityWinning}");
                }

                sw.Close();
            }
        }
        //crear raza con factory
        private static Player CreatePlayer()
        {
            Player player = new Player();

            Console.WriteLine("Player nick: ");
            player.Nick = Console.ReadLine();
            Console.WriteLine("Player race: [Z]erg  [T]erran  [P]rottos");
            var tempRace = Console.ReadLine();

            SimpleRazaFactory factory = new SimpleRazaFactory();
            RazaStore store = new RazaStore(factory);
            player.SelectedRace = store.OrderRaza(tempRace.ToUpper());

            return player;
        }
    }
}
