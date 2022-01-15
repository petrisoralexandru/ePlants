using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class CityModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public ICollection<AddressModel> Addresses { get; set; }

        public int CountyId { get; set; }
        public CountyModel County { get; set; }
    }
}
