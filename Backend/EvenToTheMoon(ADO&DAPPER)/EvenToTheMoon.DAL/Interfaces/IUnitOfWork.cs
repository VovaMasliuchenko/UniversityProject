using System;
using System.Collections.Generic;
using System.Text;
using EvenToTheMoon.DAL.Interfaces.Repositories;

namespace EvenToTheMoon.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryRepository _countryRepository { get; }
        IDiscountRepository _discountRepository { get; }
        IHotelRepository _hotelRepository { get; }
        INutritionRepository _nutritionRepository { get; }
        ITourCategoriesRepository _tourCategoriesRepository { get; }
        IToursRepository _toursRepository { get; }


        void Commit();
        void Dispose();
    }
}
