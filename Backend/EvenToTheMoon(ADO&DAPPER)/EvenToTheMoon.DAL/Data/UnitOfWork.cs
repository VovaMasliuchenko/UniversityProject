using System;
using System.Data;
using System.Data.SqlClient;
using EvenToTheMoon.DAL.Interfaces;
using EvenToTheMoon.DAL.Interfaces.Repositories;

namespace EvenToTheMoon.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbTransaction _dbTransaction;

        public ICountryRepository _countryRepository { get; }
        public IDiscountRepository _discountRepository { get; }
        public IHotelRepository _hotelRepository { get; }
        public INutritionRepository _nutritionRepository { get; }
        public ITourCategoriesRepository _tourCategoriesRepository { get; }
        public IToursRepository _toursRepository { get; }


        public UnitOfWork(ICountryRepository countryRepository,
                          IDiscountRepository discountRepository,
                          IHotelRepository hotelRepository,
                          INutritionRepository nutritionRepository,
                          ITourCategoriesRepository tourCategoriesRepository,
                          IToursRepository toursRepository,
                          IDbTransaction dbTransaction)
        {
            _countryRepository = countryRepository;
            _discountRepository = discountRepository;
            _hotelRepository = hotelRepository;
            _nutritionRepository = nutritionRepository;
            _tourCategoriesRepository = tourCategoriesRepository;
            _toursRepository = toursRepository;
            _dbTransaction = dbTransaction;
        }


        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
                // By adding this we can have muliple transactions as part of a single request
                //_dbTransaction.Connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                _dbTransaction.Rollback();
            }
        }
        public void Dispose()
        {
            //Close the SQL Connection and dispose the objects
            _dbTransaction.Connection?.Close();
            _dbTransaction.Connection?.Dispose();
            _dbTransaction.Dispose();
        }
    }
}

