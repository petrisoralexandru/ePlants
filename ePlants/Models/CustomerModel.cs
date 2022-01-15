using System.ComponentModel.DataAnnotations;
using ePlants.Data.Enums;

namespace ePlants.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        public HumanGender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Phone { get; set; }
        
    }
}
