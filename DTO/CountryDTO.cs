namespace CoureTestProject.DTO
{
    public class CountryDTO
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailDto> CountryDetails { get; set; }
    }

    public class CountryDetailDto
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
