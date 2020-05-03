using BazarWithNormalLibraryMarketKukharITEA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA.Services.Interfaces
{
    public interface IService<T> where T : class, ICommonEntity
    {
        BaseRepository<T> Repository { get; set; }

        List<T> GetAll();
        T FindById(int id);
        void Create(T item);
        void Delete(int id);
        T Update(int id, T updatedItem);
        IQueryable<T> GetQuery();
    }
}
