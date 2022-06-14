using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;


namespace BLL.Services
{
    public class ToursService : IToursService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IToursRepository toursRepository;

        public async Task<ToursResponse> SPGetByIdTour(int id)
        {
            var user = await toursRepository.GetAsync(id);
            return mapper.Map<Tours, ToursResponse>(user);
        }
        public async Task<IEnumerable<ToursResponse>> GetAsync()
        {
            var users = await toursRepository.GetAllAsync();
            return users.Select(mapper.Map<Tours, ToursResponse>);
        }

        public async Task<ToursResponse> GetByIdAsync(int id)
        {
            var user = await toursRepository.GetAsync(id);
            return mapper.Map<Tours, ToursResponse>(user);
        }

        public async Task<int> InsertAsync(ToursRequest request)
        {
            var comment = mapper.Map<ToursRequest, Tours>(request);
            var comment_id = await toursRepository.AddAsync(comment);
            return comment_id;
        }

        public async Task UpdateAsync(ToursRequest request)
        {
            var user = mapper.Map<ToursRequest, Tours>(request);
            await toursRepository.ReplaceAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await toursRepository.DeleteAsync(id);
        }

        public ToursService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            toursRepository = this.unitOfWork._toursRepository;
        }
    }
}
