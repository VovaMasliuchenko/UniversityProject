using AutoMapper;
using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Interfaces;

namespace BLL.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewResponse>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReviewResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(ReviewRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ReviewRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
