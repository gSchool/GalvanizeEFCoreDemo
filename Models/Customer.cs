using System.ComponentModel.DataAnnotations;

namespace GalvanizeCoreDemo.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}