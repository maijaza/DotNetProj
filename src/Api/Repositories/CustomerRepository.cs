using Api.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repositories
{
    public class CustomerRepository : BaseRepo.BaseRepository,IRepository<Customer>
    {

        public CustomerRepository(CustomerContext context) : base(context) { }

        public IEnumerable<Customer> List => throw new NotImplementedException();

        public void Add(Customer entity)
        {
          
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> FindAll()
        {
            throw new NotImplementedException();
        }

        public Customer FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<Customer> GetAll()
        {
            return dbcontext.Set<Customer>().Select(x => x);
        }

    }
}