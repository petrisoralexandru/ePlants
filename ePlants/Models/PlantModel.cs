using ePlants.Data;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class PlantModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public SizeCategory SizeCategory { get; set; }
        public PlantCategory PlantCategory { get; set; }
        public bool PetFriendly { get; set; }
        public bool AirPurifying { get; set; }

    }
}
