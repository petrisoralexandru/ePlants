using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class DistributorModel
    {
        [Key]
        public int Id { get; set; }
        public string DistributorName { get; set; }
        public string StreetAdress { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }

    }
}
