using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreDemo.Services;

namespace coreDemo.ViewComponents
{
    public class MovieCountViewComponent : ViewComponent
    {
        private readonly IMovieServices _movieServices;
        public MovieCountViewComponent(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        public async Task<IViewComponentResult> InvokeAsync(int cinemaId) 
        {
            var movie = await _movieServices.GetByCinemaAsync(cinemaId);
            var count = movie.Count();
            return View(count);
        }
    }
}
