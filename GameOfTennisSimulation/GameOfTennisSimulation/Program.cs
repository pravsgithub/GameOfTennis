using System;

namespace GameOfTennisSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //on start run a sample simulation
            //then ask the user to continue
            //run the simulation for a match and show the result

            var player1 = new Player { Name = "Player 1" };
            var player2 = new Player { Name = "Player 2" };
            var set = new Set(player1,player2);
            var result = set.SimulateWinFor(player1);

            //var matchResult = new MatchResult();
            //Console.WriteLine($"{matchResult.PlayerName} wins the match - {matchResult.Sets.DisplayResult()}");
            Console.ReadLine();
        }
    }
}
