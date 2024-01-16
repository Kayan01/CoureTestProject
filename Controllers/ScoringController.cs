using CoureTestProject.Models;
using CoureTestProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoureTestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoringController : ControllerBase
    {
        private readonly IScoringService _scoringService;
        
        public ScoringController(IScoringService scoringService)
        {
            _scoringService = scoringService;
        }

        [HttpPost]
        public ActionResult<ScoringResponse> CalculateScore([FromBody] ScoringRequest scoringRequest)
        {
            if (scoringRequest == null || scoringRequest.InputArray == null)
            {
                return BadRequest("The scoringRequest field is required.");
            }
            var response = _scoringService.CalculateScore(scoringRequest);

            return response;
        }
    }
}
