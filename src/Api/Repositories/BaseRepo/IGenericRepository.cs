using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Api.Repositories.BaseRepo
{
    // example for general repository
    public interface IGenericRepository<T> where T :class
    {
        //void Get();
        //void Find();

        IQueryable<T> GetAll();
        Task<IQueryable<T>> GetAllAsync();
    }
}