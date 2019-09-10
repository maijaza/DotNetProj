using Api.Constant;
using Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        CustomerContext db;
        public void Commit() { }
        public void Rollback()  {}

        public UnitOfWork(CustomerContext db) { db = this.db; }
        public UnitOfWork()
        {
            db = new CustomerContext();
        }

        public IRepository GetRepository(RepositoryType repo)
        {
            if (repo == RepositoryType.Customer)
                return new CustomerRepository();
            return null;
        }

          

         
        
    }
}