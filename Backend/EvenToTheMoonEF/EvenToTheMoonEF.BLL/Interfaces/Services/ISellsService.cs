using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.DTO.Responses;

namespace EvenToTheMoon_EF_.BLL.Interfaces.Services
{

    public interface ISellsService
    {
        Task<IEnumerable<SellsResponse>> GetAsync();
        Task<SellsResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(SellsRequest request);
        Task UpdateAsync(SellsRequest request);
        Task DeleteAsync(int id);
    }

}