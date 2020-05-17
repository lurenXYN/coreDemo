using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreDemo.Services;
using coreDemo.Models;
using Microsoft.Extensions.Options;
using coreDemo.Settings;

namespace coreDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICinemaServices _cinemaServices;
        private readonly IOptions<ConnectionOptions> _options;

        public HomeController(ICinemaServices cinemaServices, IOptions<ConnectionOptions> options)
        {
            _cinemaServices = cinemaServices;
            _options = options;
        }

        public async Task<IActionResult> Index() 
        {
            ViewBag.Title = "电影院列表";
            return View(await _cinemaServices.GetAllAsync());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "添加电影院";
            return View(new Cinema());
        }

        public async Task<IActionResult> Edit(int cinemaId) 
        {
            var cinema = await _cinemaServices.GetByIdAsync(cinemaId);
            

            return View(cinema);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Cinema cinema) 
        {
            if (ModelState.IsValid)
            {
                await _cinemaServices.AddAsync(cinema);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cinema cinema)
        {
            var exists = await _cinemaServices.GetByIdAsync(cinema.id);
            if (exists == null)
            {
                return NotFound();
            }

            exists.Name = cinema.Name;
            exists.Location = cinema.Location;
            exists.Capacity = cinema.Capacity;

            return RedirectToAction("Index");
        }
    }
}
