using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.DTO.Responses;

namespace EvenToTheMoon_EF_.BLL.Interfaces.Services
{

    public interface IReviewService
    {
        Task<IEnumerable<ReviewResponse>> GetAsync();
        Task<ReviewResponse> GetByIdAsync(int id);

        Task<int> InsertAsync(ReviewRequest request);
        Task UpdateAsync(ReviewRequest request);
        Task DeleteAsync(int id);
    }

}