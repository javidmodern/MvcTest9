using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest9.Domain.Abstract;
using MvcTest9.Domain.Entities;
namespace MvcTest9.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository repository;
        public CustomerController(ICustomerRepository _CustomerRepository)
        {
            this.repository = _CustomerRepository;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult GetCustomer()
        {
            //List<tvCustomer> a = repository.tvCustomers.Take(10).ToList();
            return View(repository.tvCustomers.Take(10));
        }
    }
}