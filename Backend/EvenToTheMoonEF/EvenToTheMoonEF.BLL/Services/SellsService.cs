using AutoMapper;
using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using EvenToTheMoon_EF_.DTO.Responses;

namespace BLL.Services
{
    public class SellsService : ISellsService
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SellsResponse>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SellsResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(SellsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SellsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
