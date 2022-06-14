using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;


namespace BLL.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IDiscountRepository discountRepository;


        public async Task<IEnumerable<DiscountResponse>> GetAsync()
        {
            var users = await discountRepository.GetAllAsync();
            return users.Select(mapper.Map<Discount, DiscountResponse>);
        }

        public async Task<DiscountResponse> GetByIdAsync(int id)
        {
            var user = await discountRepository.GetAsync(id);
            return mapper.Map<Discount, DiscountResponse>(user);
        }

        public async Task<int> InsertAsync(DiscountRequest request)
        {
            var comment = mapper.Map<DiscountRequest, Discount>(request);
            var comment_id = await discountRepository.AddAsync(comment);
            return comment_id;
        }

        public async Task UpdateAsync(DiscountRequest request)
        {
            var user = mapper.Map<DiscountRequest, Discount>(request);
            await discountRepository.ReplaceAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await discountRepository.DeleteAsync(id);
        }

        public DiscountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            discountRepository = this.unitOfWork._discountRepository;
        }
    }
}
