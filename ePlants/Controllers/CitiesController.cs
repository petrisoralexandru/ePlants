using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class CitiesController : Controller
    {
        private readonly PlantsDbContext _context;

        public CitiesController(PlantsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CityModel> data = _context.Cities.ToList();
            return View();
        }
    }
}
