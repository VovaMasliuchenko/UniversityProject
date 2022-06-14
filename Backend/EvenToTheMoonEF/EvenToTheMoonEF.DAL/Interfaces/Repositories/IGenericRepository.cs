using EvenToTheMoon_EF_.DAL.Interfaces.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenToTheMoonEF.DAL.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
