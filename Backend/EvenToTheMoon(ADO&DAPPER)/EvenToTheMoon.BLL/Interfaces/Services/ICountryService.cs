using BLL.DTO.Requests;
using BLL.DTO.Responses;

namespace EvenToTheMoon.BLL.Interfaces.Services
{

    public interface ICountryService
    {
        Task<IEnumerable<CountryResponse>> GetAsync();
        Task<CountryResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(CountryRequest request);
        Task UpdateAsync(CountryRequest request);
        Task DeleteAsync(int id);
    }

}