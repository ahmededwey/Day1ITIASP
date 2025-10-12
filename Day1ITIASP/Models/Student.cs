using System.ComponentModel.DataAnnotations;

namespace Day1ITIASP.Models
{
    public class Student
    {
        [Key]
        public int SSN { get; set; }

        [Required, StringLength(50)]
        public string? Name { get; set; }
        [Range(18, 30)]
        public int Age { get; set; }
        public string ? Address { get; set; }
        public string ? IMG { get; set; }
        [EmailAddress]
        public string ? Email { get; set; }

    }
}
