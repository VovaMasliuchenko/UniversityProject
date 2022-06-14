using AutoMapper;
using BLL.DTO.Requests;
using BLL.DTO.Responses;
using EvenToTheMoon.DAL.Entities;

namespace BLL.Configuration.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Country, CountryResponse>();
            CreateMap<CountryRequest, Country>();

            CreateMap<Discount, DiscountResponse>();
            CreateMap<DiscountRequest, Discount>();

            CreateMap<Hotel, HotelResponse>();
            CreateMap<HotelRequest, Hotel>();

            CreateMap<Nutrition, NutritionResponse>();
            CreateMap<NutritionRequest, Nutrition>();

            CreateMap<TourCategories, TourCategoriesResponse>();
            CreateMap<TourCategoriesRequest, TourCategories>();

            CreateMap<Tours, ToursResponse>();
            CreateMap<ToursRequest, Tours>();

        }

    }
}
