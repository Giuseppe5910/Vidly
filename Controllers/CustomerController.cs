using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        private DBContext _context;
        public CustomerController()
        {
            _context = new DBContext();
            Database.SetInitializer<DBContext>(null);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customers == null)
                return HttpNotFound();
            return View(customers);
        }
    }
}