using System.ComponentModel.DataAnnotations;

namespace Day1ITIASP.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Manager { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        public Branches Branch { get; set; }

        // Navigation Properties
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }



}
