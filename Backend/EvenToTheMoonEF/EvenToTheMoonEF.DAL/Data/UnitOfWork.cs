using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Data.Repositories;
using EvenToTheMoonEF.DAL.Interfaces;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EvenToTheMoonDBContext context;

        public IReviewRepository ReviewRepository { get; }

        public async Task SaveChangesAsync() => await context.SaveChangesAsync();


        public UnitOfWork
        (
        EvenToTheMoonDBContext context,
        IReviewRepository reviewRepository
        )
        {
          this.context = context;
          ReviewRepository = reviewRepository;
        }
    }
}
