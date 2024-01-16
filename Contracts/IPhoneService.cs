using CoureTestProject.DTO;

namespace CoureTestProject.Contracts
{
    public interface IPhoneService
    {
        CountryDTO GetCountryByPhoneNumber(string phoneNumber);
    }
}
