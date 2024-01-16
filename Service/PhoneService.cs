using CoureTestProject.Contracts;
using CoureTestProject.Data;
using CoureTestProject.DTO;
using Microsoft.EntityFrameworkCore;

namespace CoureTestProject.Service
{
    public class PhoneService : IPhoneService
    {
        private readonly AppDbContext _dbContext;

        public PhoneService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CountryDTO GetCountryByPhoneNumber(string phoneNumber)
        {
            var countryCode = phoneNumber.Substring(0, 3);
            var country = _dbContext.Countries
                .Include(c => c.CountryDetails) 
                .FirstOrDefault(c => c.CountryCode == countryCode);

            if (country == null)
            {
                return null;
            }

            var countryDto = new CountryDTO
            {
                CountryCode = country.CountryCode,
                Name = country.Name,
                CountryIso = country.CountryIso,
                CountryDetails = country.CountryDetails
                    .Select(detail => new CountryDetailDto
                    {
                        Operator = detail.Operator,
                        OperatorCode = detail.OperatorCode
                    })
                    .ToList()
            };

            return countryDto;
        }
    }
}

