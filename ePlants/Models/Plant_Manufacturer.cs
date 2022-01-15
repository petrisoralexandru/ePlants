using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class Plant_Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int PlantId { get; set; }
        public PlantModel Plant { get; set; }

        public int ManufacturerId { get; set; }
        public ManufacturerModel Manufacturer { get; set; }

    }
}
