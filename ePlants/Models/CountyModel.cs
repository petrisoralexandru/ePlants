using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class CountyModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public ICollection<CityModel> Cities { get; set; }
    }
}
