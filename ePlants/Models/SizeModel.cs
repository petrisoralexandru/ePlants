using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class SizeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        // Relationships
        public int PlantId { get; set; }
        public PlantModel Plant { get; set; }

        public int ShapeId { get; set; }
        public ShapeModel Shape  { get; set; }

    }
}
