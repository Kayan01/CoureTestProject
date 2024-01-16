using CoureTestProject.Models;

namespace CoureTestProject.Data
{
    public static class CountryDbInitializer
    {
        public static async Task MigrateData(this IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            await context.Database.EnsureCreatedAsync();
            if (!context.Countries.Any())
            {
                foreach (var country in SeedCountryData())
                {
                    await context.Countries.AddAsync(country);
                }
                await context.SaveChangesAsync();
            }
        }

        private static List<Country> SeedCountryData()
        {
            var countryId = Guid.NewGuid();

            var countries = new List<Country>
               //var countryId = Guid.NewGuid();
            {
            new Country
            {
                CountryId = Guid.NewGuid(),
                //CountryId = countryId,
                CountryCode = "234",
                Name = "Nigeria",
                CountryIso = "NG",
                CountryDetails = new List<CountryDetail>
                {
                    new CountryDetail { Operator = "MTN Nigeria", OperatorCode = "MTN NG" },
                    new CountryDetail { Operator = "Airtel Nigeria", OperatorCode = "ANG" },
                    new CountryDetail { Operator = "9 Mobile Nigeria", OperatorCode = "ETN" },
                    new CountryDetail { Operator = "Globacom Nigeria", OperatorCode = "GLO NG" }
                }
            },
            new Country
            {
                CountryId = Guid.NewGuid(),
                //CountryId = countryId,
                CountryCode = "233",
                Name = "Ghana",
                CountryIso = "GH",
                CountryDetails = new List<CountryDetail>
                {
                    new CountryDetail { Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH" },
                    new CountryDetail { Operator = "MTN Ghana", OperatorCode = "MTN Ghana" },
                    new CountryDetail { Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana" }
                }
            },
            new Country
            {
                  CountryId = Guid.NewGuid(),
                  //CountryId = countryId,
                CountryCode = "229",
                Name = "Benin Republic",
                CountryIso = "BN",
                CountryDetails = new List<CountryDetail>
                {
                    new CountryDetail { Operator = "MTN Benin", OperatorCode = "MTN Benin" },
                    new CountryDetail { Operator = "Moov Benin", OperatorCode = "Moov Benin" }
                }
            },
            new Country
            {
                CountryId = Guid.NewGuid(),
                 //CountryId = countryId,
                CountryCode = "225",
                Name = "Côte d'Ivoire",
                CountryIso = "CIV",
                CountryDetails = new List<CountryDetail>
                {
                    
                    new CountryDetail { Operator = "MTN Côte d'Ivoire  ", OperatorCode = "MTN CIV" }
               
                }
            }
        };

            return countries;
        }
    }

}
