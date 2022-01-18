using ePlants.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;
using ePlants.Data.Services;

namespace ePlants.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly IManufacturersService _service;

        public ManufacturersController(IManufacturersService _service)
        {
            this._service = _service;
        }
        public IActionResult Index()
        {
            IEnumerable<ManufacturerModel> data = _service.GetAll();
            return View(data);
        }
    }
}
