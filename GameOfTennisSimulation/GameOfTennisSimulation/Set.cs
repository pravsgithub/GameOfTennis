namespace GameOfTennisSimulation
{
    public class Set
    {
        private readonly Player _player1;
        private readonly Player _player2;

        private  int _player1GamesCount;
        private  int _player2GamesCount;

        public Set(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void GameWonBy(Player player)
        {
            if (player == _player1) { _player1GamesCount++;}

            if (player == _player2) { _player2GamesCount++; }
        }

        public SetResult Generate()
        {
            var setGeneratedResult = new SetResult();
            setGeneratedResult.GamesWonByPlayer1 = _player1GamesCount;
            setGeneratedResult.GamesWonByPlayer2 = _player2GamesCount;

            return setGeneratedResult;
        }
    }
}