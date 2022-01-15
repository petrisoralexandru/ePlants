using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Controllers
{
    public class AddressesController : Controller
    {
        private readonly PlantsDbContext _context;

        public AddressesController(PlantsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<AddressModel> data = _context.Addresses.ToList();
            return View();
        }
    }
}
