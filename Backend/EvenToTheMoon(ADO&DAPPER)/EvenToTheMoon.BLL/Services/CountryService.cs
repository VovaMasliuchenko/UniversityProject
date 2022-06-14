using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;


namespace BLL.Services
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly ICountryRepository countryRepository;


        public async Task<IEnumerable<CountryResponse>> GetAsync()
        {
            var users = await countryRepository.GetAllAsync();
            return users.Select(mapper.Map<Country, CountryResponse>);
        }

        public async Task<CountryResponse> GetByIdAsync(int id)
        {
            var user = await countryRepository.GetAsync(id);
            return mapper.Map<Country, CountryResponse>(user);
        }

        public async Task<int> InsertAsync(CountryRequest request)
        {
            var comment = mapper.Map<CountryRequest, Country>(request);
            var comment_id = await countryRepository.AddAsync(comment);
            return comment_id;
        }

        public async Task UpdateAsync(CountryRequest request)
        {
            var user = mapper.Map<CountryRequest, Country>(request);
            await countryRepository.ReplaceAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await countryRepository.DeleteAsync(id);
        }

        public CountryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            countryRepository = this.unitOfWork._countryRepository;
        }
    }
}
