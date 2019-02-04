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

            Assert.That(setResult.Result == "Player 1 wins");
        }

        [Test]
        public void GivenASetSimulationIsRunForPlayer2ToWin_Then_SetResultMustProvideTheWinnerAsPlayer2()
        {
            var setResult = _set.SimulateWinForPlayer2();

            Assert.That(setResult.Result == "Player 2 wins");
        }

        [Test]
        public void GivenTheSetSimulationIsRunFor3Sets_Then_WeShouldHaveAWinner()
        {
            var result = _set.Generate();
            Assert.That(result.Winner.Name != string.Empty);
        }
    }
}
