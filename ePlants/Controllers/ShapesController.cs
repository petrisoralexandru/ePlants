using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class ShapesController : Controller
    {
        private readonly PlantsDbContext _context;

        public ShapesController(PlantsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ShapeModel> data = _context.Shapes.ToList();
            return View();
        }
    }
}
