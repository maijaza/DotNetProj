using Api.Repositories.BaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repositories
{
    public class Repository<T> : IRepositoryGeneral<T> where T :class
    {
        public void Get() { }
        public void Find() { }
    }
}