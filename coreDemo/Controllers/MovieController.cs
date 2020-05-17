using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreDemo.Services;
using coreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.Controllers
{
    public class MovieController : Controller
    {
        private readonly ICinemaServices _cinemaServices;
        private readonly IMovieServices _movieServices;

        public MovieController(ICinemaServices cinemaServices, IMovieServices movieServices)
        {
            _cinemaServices = cinemaServices;
            _movieServices = movieServices;
        }

        public async Task<IActionResult> Index(int cinemaId)
        {
            var cinema = await _cinemaServices.GetByIdAsync(cinemaId);
            ViewBag.Title = $"{cinema.Name}这个电影院上映的电影：";
            ViewBag.CinemaId = cinema.id;
            return View(await _movieServices.GetByCinemaAsync(cinemaId));
        }

        public IActionResult Add(int cinemaId)
        {
            ViewBag.Title = "添加电影";
            return View(new Movie { CinemaId=cinemaId });
        }

        public IActionResult Edit(int MovieId)
        {
            ViewBag.Title = "修改电影";
            return View(new Movie { CinemaId = MovieId });
        }

        [HttpPost]
        public async Task<IActionResult> Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _movieServices.AddAsync(movie);
            }

            return RedirectToAction("Index", new { cinemaId = movie.CinemaId  });
        }
    }
}
