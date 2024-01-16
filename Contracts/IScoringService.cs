using CoureTestProject.Models;

namespace CoureTestProject.Service
{
    public interface IScoringService
    {
        // int CalculateScore(int[] inputArray);
        ScoringResponse CalculateScore(ScoringRequest request);
      
    }
}
