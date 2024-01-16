using CoureTestProject.Contracts;
using CoureTestProject.DTO;
using CoureTestProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoureTestProject.Controllers
{
  
    [ApiController]
    [Route("api/phones")]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneService _phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpGet]
        public ActionResult<CountryDTO> GetCountryByPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return BadRequest("Phone number cannot be empty.");
            }

            var countryDto = _phoneService.GetCountryByPhoneNumber(phoneNumber);

            if (countryDto == null)
            {
                return NotFound($"Country not found for the phone number: {phoneNumber}");
            }

            return Ok(new
            {
                number = phoneNumber,
                country = countryDto
            });
        }
    }

}
