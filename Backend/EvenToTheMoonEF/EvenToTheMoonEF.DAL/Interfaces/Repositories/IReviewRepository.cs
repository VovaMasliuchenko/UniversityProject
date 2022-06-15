using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;
using EvenToTheMoonEF.DAL.Entities.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Interfaces.Repositories
{
    public interface IReviewRepository : IGenericRepository<Reviews>
    {
        Task<PagedList<Reviews>> GetReviews(ReviewParameters reviewParameters);
    }
}
