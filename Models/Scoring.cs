namespace CoureTestProject.Models
{
    public class Scoring
    {
    }
    public class ScoringRequest
    {
        public int[] InputArray { get; set; }
        
    }

    public class ScoringResponse
    {
        public int TotalScore { get; set; }
        public string ValidationMessage { get; set; }

    }
}
