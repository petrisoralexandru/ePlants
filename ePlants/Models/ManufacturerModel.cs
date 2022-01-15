using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class ManufacturerModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Website")]
        public string WebsiteUrl { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        // Relationships
        public ICollection<Plant_Manufacturer> Plants_Manufacturers { get; set; }
        public ICollection<AddressModel> Addresses { get; set; }

    }
}
