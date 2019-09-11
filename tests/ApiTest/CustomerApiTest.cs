using System;
using Api.Controllers;
using Api.Repositories;
using Api.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using System.Linq;

namespace ApiTest
{
    [TestClass]
    public class CustomerApiTest
    {
        CustomerController customerController;
        Mock<UnitOfWork> mockUOW;
        Mock<CustomerRepository> mockCustomerRepo;

        [TestInitialize]
        public void Initialize()
        {
            mockUOW = new Mock<UnitOfWork>() { CallBase = true };
            customerController = new CustomerController();
          
        }


        [TestMethod]
        public void TestGetCustomer_haveValue_Success()
        {

            var res = new Customer[]
            {
                new Customer { ID = 1 , Name = "Emp 1"},
                new Customer { ID = 2 , Name = "Emp 2"}
            };

            mockCustomerRepo = new Mock<CustomerRepository>(null) { CallBase = true };
            mockCustomerRepo.Setup(m => m.GetAll()).Returns(res.AsQueryable());
            mockUOW.Setup(m => m.CustomerRepo).Returns(mockCustomerRepo.Object);
            customerController = new CustomerController(mockUOW.Object);
            customerController.Configuration = new System.Web.Http.HttpConfiguration();
            customerController.Request = new HttpRequestMessage();
            customerController.Request.SetConfiguration(customerController.Configuration);

            var res2 = customerController.Test();


            IQueryable<Customer> o;
            var b = res2.TryGetContentValue<IQueryable<Customer>>(out o);

            Assert.IsTrue(res2.StatusCode == System.Net.HttpStatusCode.OK);

        }
    }
}
