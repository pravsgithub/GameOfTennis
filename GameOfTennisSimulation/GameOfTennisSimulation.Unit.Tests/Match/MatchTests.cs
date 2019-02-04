using System.Linq;
using NUnit.Framework;

namespace GameOfTennisSimulation.Unit.Tests.Match
{
    [TestFixture]
    public class MatchTests
    {
        private Player _player1;
        private Player _player2;

        [Test]

        public void GivenASimulationIsGeneratedFor3Sets_Then_WeShoudBeAbleToGetAWinnerAndTheScoresOfTheSets()
        {
            _player1 = new Player { Name = "Player 1" };
            _player2 = new Player { Name = "Player 2" };
            var match = new GameOfTennisSimulation.Match(_player1, _player2);
            var matchResult = match.Simulate();
            Assert.That(matchResult.Winner.Name != string.Empty);
           Assert.That(matchResult.FinalScore != string.Empty);

        }
    }
}
