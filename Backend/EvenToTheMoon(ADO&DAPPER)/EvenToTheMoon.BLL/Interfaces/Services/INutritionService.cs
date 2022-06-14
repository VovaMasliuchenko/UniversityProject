using BLL.DTO.Requests;
using BLL.DTO.Responses;

namespace EvenToTheMoon.BLL.Interfaces.Services
{

    public interface INutritionService
    {
        Task<IEnumerable<NutritionResponse>> GetAsync();
        Task<NutritionResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(NutritionRequest request);
        Task UpdateAsync(NutritionRequest request);
        Task DeleteAsync(int id);
    }

}