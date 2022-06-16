using EvenToTheMoon_EF_.DAL.Entities.Base;
using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EvenToTheMoonEF.DAL.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : Entity, new()
    {
        protected readonly EvenToTheMoonDBContext context;
        private DbSet<T> table;
        public bool AutoSaveChanges { get; set; } = true;

        public GenericRepository(EvenToTheMoonDBContext dbContext)
        {
            this.context = dbContext;
            table = context.Set<T>();
        }

        public async void Delete(int id)
        {
            var entity = table.SingleOrDefault(s => s.Id == id);
            table.Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task InsertAsync(T entity) =>
            await table.AddAsync(entity);

        public async void Update(T obj)
        {
            var entity = table.SingleOrDefault(s => s.Id == obj.Id);
            table.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
