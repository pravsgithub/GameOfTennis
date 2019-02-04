using System.Collections.Generic;

namespace GameOfTennisSimulation
{
    public class Match
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private int _numberOfSetsWonByPlayer1;
        private int _numberOfSetsWonByPlayer2;
        private List<string> finalScores = new List<string>();

        public Match(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public MatchResult Simulate()
        {
            var set = new Set(_player1, _player2);
            var results = set.Generate();

            foreach (var result in results)
            {
                finalScores.Add(result.Score);
                if (result.SetWinner == _player1)
                {
                    _numberOfSetsWonByPlayer1++;
                }
                else
                {
                    _numberOfSetsWonByPlayer2++;
                }
            }

            var matchResult = new MatchResult
            {
                Winner = _numberOfSetsWonByPlayer1 >= 2 ? _player1 : _player2,
                FinalScore = string.Join(",", finalScores)
            };
            return matchResult;
        }
    }
}
