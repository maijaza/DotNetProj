using Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 using uow =  Api.UnitOfWork;

namespace Api.Controllers
{
    [System.Web.Http.RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        private uow.UnitOfWork _uow = new UnitOfWork.UnitOfWork();
         
        public CustomerController(uow.UnitOfWork uow)
        {
            _uow = uow;
        }

        public CustomerController() { }
        

        [System.Web.Http.HttpGet]
        //[System.Web.Http.Route("test")]
        public HttpResponseMessage Test()
        {
            var customers = _uow.CustomerRepo;
            return Request.CreateResponse(HttpStatusCode.OK, customers.GetAll());
        }

        #region =========== Default Method ===========


        // GET: api/Customer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }

        #endregion

   
    }
}
