using System.Collections;
using System.Collections.Generic;
using ePlants.Models;

namespace ePlants.Data.Services
{
    public interface IManufacturersService
    {
        // CRUD Manufacturers

        // add manufacturers
        void Add(ManufacturerModel manufacturer);
        // get all manufacturers
        IEnumerable<ManufacturerModel> GetAll();
        // return a single manufacturer
        ManufacturerModel GetById(int id);
        // check if the id exists before updating a manufacturer
        ManufacturerModel Update(int id, ManufacturerModel manufacturer);
        // delete a manufacturer
        void Delete(int id);
        
    }
}
