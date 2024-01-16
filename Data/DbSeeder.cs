using CoureTestProject.Models;
using System.Diagnostics.Metrics;

namespace CoureTestProject.Data
{
    // DbSeeder.cs
    public static class DbSeeder
    {
        public static void SeedData(AppDbContext dbContext)
        {
            var countries = new List<Country>
        {
            new Country
            {
                CountryCode = "234",
                Name = "Nigeria",
                CountryIso = "NG",
                CountryDetails = new List<CountryDetail>
                {
                    new CountryDetail { Operator = "Airtel Nigeria", OperatorCode = "ANG" },
                    new CountryDetail { Operator = "MTN Nigeria", OperatorCode = "MTN NG" },
                    new CountryDetail { Operator = "9Mobile Nigeria", OperatorCode = "ETN" },
                    new CountryDetail { Operator = "Globacom Nigeria", OperatorCode = "GLO NG" }
                }
            }
          
        };

            dbContext.Countries.AddRange(countries);
            dbContext.SaveChanges();
        }
    }

}
