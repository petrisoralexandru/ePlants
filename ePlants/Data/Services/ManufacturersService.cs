using ePlants.Models;
using System.Collections.Generic;
using System.Linq;

namespace ePlants.Data.Services
{
    public class ManufacturersService : IManufacturersService
    {
        private readonly PlantsDbContext _context;

        public ManufacturersService(PlantsDbContext _context)
        {
            this._context = _context;
        }

        public void Add(ManufacturerModel manufacturer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ManufacturerModel> GetAll()
        {
            IEnumerable<ManufacturerModel> result = _context.Manufacturers.ToList();
            return result;
        }

        public ManufacturerModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public ManufacturerModel Update(int id, ManufacturerModel manufacturer)
        {
            throw new System.NotImplementedException();
        }
    }
}
