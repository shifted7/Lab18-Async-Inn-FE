using Async_Inn_Frontend.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_Frontend.Controllers
{
    public class HotelsController : Controller
    {
        private IHotelManager _hotel;
        public HotelsController(IHotelManager hotel)
        {
            _hotel = hotel;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _hotel.GetAllHotels();
            return View(result);
        }
    }
}
