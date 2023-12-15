using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string? Name { get; set; }

        [Required]
        [StringLength(5)]
        [RegularExpression("^[0-9]*$")]
        public string? Zipcode { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(60)]
        public string? Country { get; set; }
        public IEnumerable<Employee>? Employees { get; set; } = new List<Employee>();
    }
}