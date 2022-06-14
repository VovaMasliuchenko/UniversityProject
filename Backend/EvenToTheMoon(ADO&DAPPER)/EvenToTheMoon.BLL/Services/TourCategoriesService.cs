using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;


namespace BLL.Services
{
    public class TourCategoriesService : ITourCategoriesService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly ITourCategoriesRepository tourCrategoriesRepository;


        public async Task<IEnumerable<TourCategoriesResponse>> GetAsync()
        {
            var users = await tourCrategoriesRepository.GetAllAsync();
            return users.Select(mapper.Map<TourCategories, TourCategoriesResponse>);
        }

        public async Task<TourCategoriesResponse> GetByIdAsync(int id)
        {
            var user = await tourCrategoriesRepository.GetAsync(id);
            return mapper.Map<TourCategories, TourCategoriesResponse>(user);
        }

        public async Task<int> InsertAsync(TourCategoriesRequest request)
        {
            var comment = mapper.Map<TourCategoriesRequest, TourCategories>(request);
            var comment_id = await tourCrategoriesRepository.AddAsync(comment);
            return comment_id;
        }

        public async Task UpdateAsync(TourCategoriesRequest request)
        {
            var user = mapper.Map<TourCategoriesRequest, TourCategories>(request);
            await tourCrategoriesRepository.ReplaceAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await tourCrategoriesRepository.DeleteAsync(id);
        }

        public TourCategoriesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            tourCrategoriesRepository = this.unitOfWork._tourCategoriesRepository;
        }
    }
}
