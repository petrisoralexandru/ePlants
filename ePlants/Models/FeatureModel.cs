using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class FeatureModel
    {
        [Key]
        public int Id { get; set; }
        public bool PetFriendly { get; set; }
        public bool AirPurifying { get; set; }

        // Relationships
        public ICollection<Plant_Features> Plants_Features { get; set; }
    }
}
