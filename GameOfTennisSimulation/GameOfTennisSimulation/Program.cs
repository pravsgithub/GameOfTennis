using System;

namespace GameOfTennisSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Game of Tennis - Simulation");
                var player1 = new Player {Name = "Player 1"};
                var player2 = new Player {Name = "Player 2"};
                var match = new Match(player1, player2);
                var result = match.Simulate();
                Console.WriteLine($"The winner of the match is {result.Winner.Name}");
                Console.WriteLine($"The final score is {result.FinalScore}");
                Console.WriteLine("If you would you like to run the simulation again then enter 'Y' or 'y' or to quit enter 'n' or 'N'");

                string userInput = Console.ReadLine();
                if ((userInput == "n") || (userInput == "N"))
                    break;

            } while (true);

            
        }
    }
}
