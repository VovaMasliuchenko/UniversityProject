using BLL.DTO.Requests;
using BLL.DTO.Responses;

namespace EvenToTheMoon.BLL.Interfaces.Services
{

    public interface IDiscountService
    {
        Task<IEnumerable<DiscountResponse>> GetAsync();
        Task<DiscountResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(DiscountRequest request);
        Task UpdateAsync(DiscountRequest request);
        Task DeleteAsync(int id);
    }

}