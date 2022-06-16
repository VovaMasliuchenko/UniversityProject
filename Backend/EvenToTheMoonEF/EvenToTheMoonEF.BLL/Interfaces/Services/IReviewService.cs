using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;

namespace EvenToTheMoon_EF_.BLL.Interfaces.Services
{

    public interface IReviewService
    {
        Task<IEnumerable<ReviewResponse>> GetAsync();
        Task<ReviewResponse> GetByIdAsync(int id);
        Task<IEnumerable<ReviewResponse>> GetAll();
        Task<IEnumerable<ReviewResponse>> GetAllPaged(ReviewParameters reviewParameters);
        Task InsertAsync(ReviewRequest request);
        Task UpdateAsync(ReviewRequest request);
        Task DeleteAsync(int id);
    }

}