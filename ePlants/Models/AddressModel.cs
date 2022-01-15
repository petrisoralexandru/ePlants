using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class AddressModel
    {
        [Key]
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }

        // Relationships
        public int ManufacturerId { get; set; }
        public ManufacturerModel Manufacturer { get; set; }

        public int CityId { get; set; }
        public CityModel City { get; set; }
    }
}
