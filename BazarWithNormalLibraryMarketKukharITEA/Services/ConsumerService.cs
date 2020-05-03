using BazarWithNormalLibraryMarketKukharITEA.Entities;
using BazarWithNormalLibraryMarketKukharITEA.Services.Interfaces;
using database.BazarWithNormalLibraryMarketKukharITEA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA.Services
{
    public class ConsumerService : IService<Consumers>
    {
        public BaseRepository<Consumers> Repository { get; set; }


        public ConsumerService(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Consumers>(dbContext);
        }
        public void Create(Consumers item)
        {
            Repository.Create(item);

            // throw new NotImplementedException();
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
            // throw new NotImplementedException();
        }

        public Consumers FindById(int id)
        {
            return Repository.FindById(id);
            //throw new NotImplementedException();
        }

        public List<Consumers> GetAll()
        {
            return Repository.GetAll().ToList();
            // throw new NotImplementedException();
        }

        public IQueryable<Consumers> GetQuery()
        {
            return Repository.GetAll();
            // throw new NotImplementedException();
        }

        public Consumers Update(int id, Consumers updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
            //throw new NotImplementedException();
        }
    }
}
