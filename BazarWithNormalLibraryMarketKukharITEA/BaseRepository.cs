using BazarWithNormalLibraryMarketKukharITEA.Interfaces;
using database.BazarWithNormalLibraryMarketKukharITEA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA
{
    public class BaseRepository<T> : IRepository<T> where T: class, ICommonEntity
    {
        private readonly IteaDbContext dbContext;
        protected readonly DbSet<T> dbSet;
        public BaseRepository(IteaDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = this.dbContext.Set<T>();
        }

  

        public void Create(T item)
        {
            dbSet.Add(item);
            dbContext.SaveChanges();

            //throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            return dbSet.Find(id);
            //throw new NotImplementedException();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
            //throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
            //throw new NotImplementedException();
        }

        public void Remove(int item)
        {
            dbSet.Remove(FindById(item));
            dbContext.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Update(T item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
            dbContext.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
