using AutoMapper;
using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.BLL.Helpers;
using EvenToTheMoonEF.DAL.Data.Repositories;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;
using EvenToTheMoonEF.DAL.Interfaces;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.StackExchangeRedis;

namespace BLL.Services
{
    public class ReviewService : IReviewService
    {
        
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IDistributedCache _redisCache;

        public ReviewService(IMapper _mapper, IUnitOfWork _unitOfWork, IDistributedCache redisCache)
        {
            mapper = _mapper;
            unitOfWork = _unitOfWork;
            _redisCache = redisCache;
        }

        public async Task DeleteAsync(int id)
        {
            await _redisCache.RemoveAsync(id.ToString());
            unitOfWork.ReviewRepository.Delete(id);
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

        public async Task<ReviewResponse> GetByIdAsync(int id)
        {
            var response = await _redisCache.GetRecordAsync<ReviewResponse>(id.ToString());
            if(response == null)
            {
                var review = await unitOfWork.ReviewRepository.GetById(id);
                response = mapper.Map<ReviewResponse>(review);
                await _redisCache.SetRecordAsync(id.ToString(), response);
            }
            return response;
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
