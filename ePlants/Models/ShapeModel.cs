using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class ShapeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public ICollection<SizeModel> Sizes { get; set; }
    }
}
