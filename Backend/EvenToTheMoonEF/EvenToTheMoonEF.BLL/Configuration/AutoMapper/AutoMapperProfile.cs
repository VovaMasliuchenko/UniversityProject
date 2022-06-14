using AutoMapper;
using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.DAL.Entities;

namespace EvenToTheMoon_EF_.BLL.Configuration.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        private void CreateReviewMaps()
        {
            CreateMap<Reviews, ReviewResponse>();
            CreateMap<ReviewRequest, Reviews>();
        }
        private void CreateSellsMaps()
        {
            CreateMap<Sells, SellsResponse>();
            CreateMap<SellsRequest, Sells>();
        }


        public AutoMapperProfile()
        {
            CreateReviewMaps();
            CreateSellsMaps();
        }

    }
}
