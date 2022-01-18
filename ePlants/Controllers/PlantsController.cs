using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class PlantsController : Controller
    {
        private readonly PlantsDbContext _context;

        public PlantsController(PlantsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PlantModel> data = _context.Plants.ToList();
            return View(data);
        }
    }
}
