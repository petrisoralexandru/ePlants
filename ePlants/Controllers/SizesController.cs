using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class SizesController : Controller
    {

        private readonly PlantsDbContext _context;

        public SizesController(PlantsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<SizeModel> data = _context.Sizes.ToList();
            return View();
        }
    }
}
