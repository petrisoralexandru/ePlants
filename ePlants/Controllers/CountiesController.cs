using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class CountiesController : Controller
    {
        private readonly PlantsDbContext _context;

        public CountiesController(PlantsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CountyModel> data = _context.Counties.ToList();
            return View();
        }
    }
}
