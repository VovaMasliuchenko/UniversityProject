using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;


namespace BLL.Services
{
    public class HotelService : IHotelService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IHotelRepository hotelRepository;


        public async Task<IEnumerable<HotelResponse>> GetAsync()
        {
            var users = await hotelRepository.GetAllAsync();
            return users.Select(mapper.Map<Hotel, HotelResponse>);
        }

        public async Task<HotelResponse> GetByIdAsync(int id)
        {
            var user = await hotelRepository.GetAsync(id);
            return mapper.Map<Hotel, HotelResponse>(user);
        }

        public async Task<int> InsertAsync(HotelRequest request)
        {
            var comment = mapper.Map<HotelRequest, Hotel>(request);
            var comment_id = await hotelRepository.AddAsync(comment);
            return comment_id;
        }

        public async Task UpdateAsync(HotelRequest request)
        {
            var user = mapper.Map<HotelRequest, Hotel>(request);
            await hotelRepository.ReplaceAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await hotelRepository.DeleteAsync(id);
        }

        public HotelService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            hotelRepository = this.unitOfWork._hotelRepository;
        }
    }
}
