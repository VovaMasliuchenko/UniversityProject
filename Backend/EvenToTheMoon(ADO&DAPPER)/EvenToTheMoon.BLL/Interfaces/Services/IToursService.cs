using BLL.DTO.Requests;
using BLL.DTO.Responses;

namespace EvenToTheMoon.BLL.Interfaces.Services
{

    public interface IToursService
    {
        Task<IEnumerable<ToursResponse>> GetAsync();
        Task<ToursResponse> GetByIdAsync(int id);
        Task<ToursResponse> SPGetByIdTour(int id);
        Task<int> InsertAsync(ToursRequest request);
        Task UpdateAsync(ToursRequest request);
        Task DeleteAsync(int id);
    }

}