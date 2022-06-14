using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;


namespace BLL.Services
{
    public class NutritionService : INutritionService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly INutritionRepository nutritionRepository;


        public async Task<IEnumerable<NutritionResponse>> GetAsync()
        {
            var users = await nutritionRepository.GetAllAsync();
            return users.Select(mapper.Map<Nutrition, NutritionResponse>);
        }

        public async Task<NutritionResponse> GetByIdAsync(int id)
        {
            var user = await nutritionRepository.GetAsync(id);
            return mapper.Map<Nutrition, NutritionResponse>(user);
        }

        public async Task<int> InsertAsync(NutritionRequest request)
        {
            var comment = mapper.Map<NutritionRequest, Nutrition>(request);
            var comment_id = await nutritionRepository.AddAsync(comment);
            return comment_id;
        }

        public async Task UpdateAsync(NutritionRequest request)
        {
            var user = mapper.Map<NutritionRequest, Nutrition>(request);
            await nutritionRepository.ReplaceAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await nutritionRepository.DeleteAsync(id);
        }

        public NutritionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            nutritionRepository = this.unitOfWork._nutritionRepository;
        }
    }
}
