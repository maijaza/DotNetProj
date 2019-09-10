using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repositories.BaseRepo
{
    // example for general repository  
    public interface IRepositoryGeneral<T> where T :class
    {
        void Get();
        void Find();
    }
}