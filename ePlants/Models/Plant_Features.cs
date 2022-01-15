using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class Plant_Features
    {
        [Key]
        public int Id { get; set; }

        public int PlantId { get; set; }
        public PlantModel Plant { get; set; }

        public int FeatureId { get; set; }
        public FeatureModel Feature { get; set; }
    }
}
