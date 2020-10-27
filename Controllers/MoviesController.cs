using Microsoft.Ajax.Utilities;
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
    public class MoviesController : Controller
    {
        private DBContext _context;
        public MoviesController()
        {
            _context = new DBContext();
            Database.SetInitializer<DBContext>(null);
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }
        public ActionResult Details(int id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movies == null)
                return HttpNotFound();
            return View(movies);
        }

        public ViewResult Index(int? pageIndex,string sortBy)
        {
            var movies = _context.Movies.ToList();
            return View(movies);

        }
    }
}