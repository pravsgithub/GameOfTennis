using System.Security.AccessControl;

namespace GameOfTennisSimulation
{
    public class MatchResult
    {
        public Player Winner { get; set; }
        public string  FinalScore { get; set; }
    }
}