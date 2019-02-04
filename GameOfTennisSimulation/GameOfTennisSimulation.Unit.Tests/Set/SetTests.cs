using NUnit.Framework;

namespace GameOfTennisSimulation.Unit.Tests.Set
{
    [TestFixture]
    public class SetTests
    {
        private Player _player1;
        private Player _player2;
        private GameOfTennisSimulation.Set _set;

        [SetUp]
        public void Setup()
        {
            _player1 = new Player { Name = "Player 1" };
            _player2 = new Player { Name = "Player 2" };
            _set = new GameOfTennisSimulation.Set(_player1, _player2);
        }

        [Test]
        public void GivenASetSimulationIsRunForPlayer1ToWin_Then_SetResultMustProvideTheWinnerAsPlayer1()
        {
            var setResult = _set.SimulateWinForPlayer1();

            Assert.That(setResult.SetWinner == _player1);
        }

        [Test]
        public void GivenASetSimulationIsRunForPlayer2ToWin_Then_SetResultMustProvideTheWinnerAsPlayer2()
        {
            var setResult = _set.SimulateWinForPlayer2();

            Assert.That(setResult.SetWinner == _player2);
        }

        [Test]
        public void GivenASetSimulationIsRunForPlayer1ToWin_Then_SetResultMustProvideTheScore()
        {
            var setResult = _set.SimulateWinForPlayer1();

            Assert.That(setResult.Score != string.Empty);
        }

        [Test]
        public void GivenTheSetSimulationIsRunFor3Sets_Then_WeShouldHaveAWinnerAndScoresForEachOfTheSet()
        {
            var results = _set.Generate();

            Assert.That(results.Count == 3);
            Assert.That(results[0].SetWinner.Name != string.Empty);
            Assert.That(results[1].SetWinner.Name != string.Empty);
            Assert.That(results[2].SetWinner.Name != string.Empty);
            Assert.That(results[0].Score != string.Empty);
            Assert.That(results[1].Score != string.Empty);
            Assert.That(results[2].Score != string.Empty);
        }
    }
}
