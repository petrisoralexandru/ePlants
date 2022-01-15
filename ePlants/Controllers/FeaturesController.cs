using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly PlantsDbContext _context;

        public FeaturesController(PlantsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<FeatureModel> data = _context.Features.ToList();
            return View();
        }
    }
}
