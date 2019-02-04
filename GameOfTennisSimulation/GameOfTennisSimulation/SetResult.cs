namespace GameOfTennisSimulation
{
    public class SetResult
    {
        public int GamesWonByPlayer1 { get; set; }
        public int GamesWonByPlayer2 { get; set; }
    
        public string Result => GamesWonByPlayer1 == 6 ? "Player 1 wins" : "Player 2 wins";
    }
}