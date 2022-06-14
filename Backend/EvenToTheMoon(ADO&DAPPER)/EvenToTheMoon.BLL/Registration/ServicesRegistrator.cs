using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenToTheMoon.BLL.Interfaces.Services;
using BLL.Services;

namespace BLL.Registration
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<ICountryService, CountryService>()
            .AddTransient<IHotelService, HotelService>()
            .AddTransient<IDiscountService, DiscountService>()
            .AddTransient<INutritionService, NutritionService>()
            .AddTransient<ITourCategoriesService, TourCategoriesService>()
            .AddTransient<IToursService, ToursService>()
       ;
    }
}
