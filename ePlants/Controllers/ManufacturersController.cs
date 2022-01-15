using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly PlantsDbContext _context;

        public ManufacturersController(PlantsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ManufacturerModel> data = _context.Manufacturers.ToList();
            return View(data);
        }
    }
}
