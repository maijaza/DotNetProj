using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.UnitOfWork
{
    public interface IUnitOfWork
    {
         void Commit();
         void Rollback();

           
    }
}