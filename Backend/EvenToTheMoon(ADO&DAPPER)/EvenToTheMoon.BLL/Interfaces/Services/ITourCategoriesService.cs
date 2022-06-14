using BLL.DTO.Requests;
using BLL.DTO.Responses;

namespace EvenToTheMoon.BLL.Interfaces.Services
{

    public interface ITourCategoriesService
    {
        Task<IEnumerable<TourCategoriesResponse>> GetAsync();
        Task<TourCategoriesResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(TourCategoriesRequest request);
        Task UpdateAsync(TourCategoriesRequest request);
        Task DeleteAsync(int id);
    }

}