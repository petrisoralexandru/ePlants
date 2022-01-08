using System.ComponentModel.DataAnnotations;

namespace ePlants.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enum Gender { Male, Female }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        
    }
}
