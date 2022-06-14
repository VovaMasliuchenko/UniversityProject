using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IReviewRepository ReviewRepository { get; }
        ISellsRepository SellsRepository { get; }
        Task SaveChangesAsync();
    }
}
