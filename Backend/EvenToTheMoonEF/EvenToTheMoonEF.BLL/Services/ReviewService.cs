using AutoMapper;
using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.DAL.Data.Repositories;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;
using EvenToTheMoonEF.DAL.Interfaces;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;

namespace BLL.Services
{
    public class ReviewService : IReviewService
    {
        
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public ReviewService(IMapper _mapper, IUnitOfWork _unitOfWork)
        {
            mapper = _mapper;
            unitOfWork = _unitOfWork;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewResponse>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ReviewResponse>> GetAllPaged(ReviewParameters reviewParameters)
        {
            var review = await unitOfWork.ReviewRepository.GetReviews(reviewParameters);
            return mapper.Map<List<ReviewResponse>>(review);
        }

        public async Task<IEnumerable<ReviewResponse>> GetAll()
        {
            var review = await unitOfWork.ReviewRepository.GetAll();
            return mapper.Map<List<ReviewResponse>>(review);
        }

        public Task<ReviewResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(ReviewRequest request)
        {
            var review = mapper.Map<ReviewRequest, Reviews>(request);
            await unitOfWork.ReviewRepository.InsertAsync(review);
            await unitOfWork.SaveChangesAsync();
        }

        public Task UpdateAsync(ReviewRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
