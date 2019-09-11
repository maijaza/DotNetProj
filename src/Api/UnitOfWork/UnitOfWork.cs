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
 


        public GenericRepository<Customer> CustomerGenericRepository
        {
            get
            {
                return new GenericRepository<Customer>(db);
            }
        }

   
        public virtual CustomerRepository CustomerRepo
        {
            get
            {
                return new CustomerRepository(db);
            }
        }

    




    }
}