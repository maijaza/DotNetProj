using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        DBContext db;
        public void Commit() { }
        public void Rollback()  {}

        public UnitOfWork(DBContext db) {
            db = db;
        }
        public UnitOfWork()
        {
            db = new DBContext();
        }
    }
}