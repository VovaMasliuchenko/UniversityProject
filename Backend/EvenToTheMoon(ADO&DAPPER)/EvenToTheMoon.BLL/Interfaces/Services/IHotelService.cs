using BLL.DTO.Requests;
using BLL.DTO.Responses;

namespace EvenToTheMoon.BLL.Interfaces.Services
{

    public interface IHotelService
    {
        Task<IEnumerable<HotelResponse>> GetAsync();
        Task<HotelResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(HotelRequest request);
        Task UpdateAsync(HotelRequest request);
        Task DeleteAsync(int id);
    }

}