using Api.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repositories.BaseRepo
{
    public class BaseRepository
    {
        public CustomerContext dbcontext;

        public BaseRepository() : this(new CustomerContext()) { }
        public BaseRepository(CustomerContext context)
        {
            dbcontext = context;
        }
    }
}