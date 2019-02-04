using NUnit.Framework;

namespace GameOfTennisSimulation.Unit.Tests.Set
{
    [TestFixture]
    class SetTests
    {

        //a player wins the set if he/she wins 6 games
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
    }
}
