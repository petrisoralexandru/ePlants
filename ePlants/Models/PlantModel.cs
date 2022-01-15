using ePlants.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePlants.Models
{
    public class PlantModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public PlantCategory PlantCategory { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }

        // Relationships
        public ICollection<Plant_Manufacturer> Plants_Manufacturers { get; set; }
        public ICollection<Plant_Features> Plants_Features { get; set; }
        public SizeModel Size { get; set; }

    }
}
