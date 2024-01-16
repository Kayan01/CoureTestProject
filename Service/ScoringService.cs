using CoureTestProject.Models;

namespace CoureTestProject.Service
{
    public class ScoringService : IScoringService
    {
        public ScoringResponse CalculateScore(ScoringRequest request)
        {
            if (request == null || request.InputArray == null || !request.InputArray.All(IsValidInput))
            {
                // Handle invalid input (null request or non-numeric elements in input array)
                return new ScoringResponse { TotalScore = 0, ValidationMessage = "Input array must contain only non-negative integers." };
            }

            int totalScore = 0;

            foreach (int number in request.InputArray)
            {
                if (number < 0)
                {
                    // Handle negative numbers if needed
                    return new ScoringResponse { TotalScore = 0, ValidationMessage = "Input array must contain only non-negative integers." };
                }

                if (number % 2 == 0)
                {
                    totalScore += 1;
                }
                else
                {
                    totalScore += 3;
                }

                if (number == 8)
                {
                    totalScore += 5;
                }
            }

            return new ScoringResponse { TotalScore = totalScore };
        }

        private bool IsValidInput(int value)
        {
            // Check if the value is a non-negative integer
            if (value < 0)
            {
                return false;
            }

            // Check if the value is numeric
            if (!IsNumeric(value.ToString()))
            {
                return false;
            }

            return true;
        }

        private bool IsNumeric(string input)
        {
            // Check if the input string is numeric
            return int.TryParse(input, out _);
        }
    }

}