using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;
using EvenToTheMoonEF.DAL.Entities.PagedList;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Data.Repositories
{
    public class ReviewRepository : GenericRepository<Reviews>, IReviewRepository
    {
        public ReviewRepository(EvenToTheMoonDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedList<Reviews>> GetReviews(ReviewParameters reviewParameters)
        {
            var result = PagedList<Reviews>.ToPagedList(this.context.Set<Reviews>().OrderBy(s => s.Id),
            reviewParameters.PageNumber,
            reviewParameters.PageSize);
            return result;
        }

    }
}
