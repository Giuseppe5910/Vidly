using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customers == null)
                return HttpNotFound();
            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> 
            {
                new Customer{Id=1,Name="peppe"},
                new Customer{Id=2,Name="ciccio" }
            };
        }
    }
}