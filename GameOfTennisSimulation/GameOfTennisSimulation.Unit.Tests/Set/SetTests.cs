using NUnit.Framework;

namespace GameOfTennisSimulation.Unit.Tests.Set
{
    [TestFixture]
    public class SetTests
    {

        //a player wins the set if he/she wins 6 games
        //do i need this anymore?
        [Test]
        public void GivenAPlayerWins6Games_Then_ThePlayerWinsTheSet()
        {
            var player1 = new Player {Name = "Player 1"};
            var player2 = new Player { Name = "Player 2" };
            var set = new GameOfTennisSimulation.Set(player1, player2);
            set.GameWonBy(player1);
            set.GameWonBy(player1);
            set.GameWonBy(player1);
            set.GameWonBy(player1);
            set.GameWonBy(player1);
            set.GameWonBy(player1);

            var setResult = set.Generate();
            Assert.That(setResult.Result == "Player 1 wins");
        }

        //do i need this anymore?
        [Test]
        public void GivenAPlayerWinsAGame_Then_TheScoreShouldBe_1_0()
        {
            var player1 = new Player { Name = "Player 1" };
            var player2 = new Player { Name = "Player 2" };
            var set = new GameOfTennisSimulation.Set(player1, player2);
            set.GameWonBy(player1);

            var setResult = set.Generate();
            Assert.That(setResult.Score == "1 - 0");
        }

        [Test]
        public void GivenASetSimulationIsRunForPlayer1ToWin_Then_SetResultMustProvideTheWinnerAsPlayer1()
        {
            var player1 = new Player { Name = "Player 1" };
            var player2 = new Player { Name = "Player 2" };
            var set = new GameOfTennisSimulation.Set(player1, player2);
            var setResult = set.SimulateWinForPlayer1();

            Assert.That(setResult.Result == "Player 1 wins");
        }

        [Test]
        public void GivenASetSimulationIsRunForPlayer2ToWin_Then_SetResultMustProvideTheWinnerAsPlayer2()
        {
            var player1 = new Player { Name = "Player 1" };
            var player2 = new Player { Name = "Player 2" };
            var set = new GameOfTennisSimulation.Set(player1, player2);
            var setResult = set.SimulateWinForPlayer2();

            Assert.That(setResult.Result == "Player 2 wins");
        }
    }
}
