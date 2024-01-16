using Microsoft.EntityFrameworkCore;

namespace CoureTestProject.Models
{
    // Models.cs
    public class Country
    {
        public Guid CountryId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetail> CountryDetails { get; set; }
    }

    public class CountryDetail
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
        public Country Country { get; set; }
    }

    // DataContext.cs
   
}
