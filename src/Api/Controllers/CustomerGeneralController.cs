using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Api.Controllers
{
    [System.Web.Http.RoutePrefix("api/CustomerGeneral")]
    public class CustomerGeneralController : ApiController
    {
        private UnitOfWork.UnitOfWork _uow = new UnitOfWork.UnitOfWork();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("test")]
        public HttpResponseMessage Customers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _uow.CustomerGenericRepository.GetAll());
        }


        #region =========== Default method =========== 
        // GET: api/CustomerGeneral
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CustomerGeneral/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerGeneral
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CustomerGeneral/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CustomerGeneral/5
        public void Delete(int id)
        {
        }

        #endregion

    }
}
