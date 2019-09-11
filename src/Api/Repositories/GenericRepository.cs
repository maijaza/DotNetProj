using Api.Repositories.BaseRepo;
using Api.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Api.Repositories
{
    //this for dynamic general repo method but not work in real world
    public class GenericRepository<T> : IGenericRepository<T> where T :class
    {
        CustomerContext _dbContext;

        public GenericRepository(CustomerContext context)
        {
            _dbContext = context;
        }
        public GenericRepository()
        {
            _dbContext = new CustomerContext();
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().Select(x => x);
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


    }
}