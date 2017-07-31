using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModel;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies   movies/random

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();


            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id==id);
            if (movie==null)
            {
                return HttpNotFound();
            }
            

            return View("MovieDetails", movie);
        }


        public ActionResult NewMovie()
        {
            return View();
        }

        public ActionResult Create(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel
                {
                    Movie = movie
                };
                return View("NewMovie", viewModel);
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Random()
        {

            var movie = new Movie() {Name = "The Prestige"};

            var customers = new List<Customer>()
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"},
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);



            //different way of sendind data to view page
            //var movie = new Movie()
            //{
            //    Name = "Sherk"
            //};
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = movie;
            //return View(movie);



            //types of Helper method of different action result
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        //movies/edit/{id}

        //public ActionResult Edit(int id)
        //{
        //    return Content("ID : " + id);
        //}

        ////movies

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
        //}


        //Custom routing using MapMvcAttributeRoutes...
        //[Route("movies/released/{year}")]
        //public ActionResult ByReleaseYear(int year, int? month)
        //{
        //    return Content(year + "/" + month);

        //}


    }
}