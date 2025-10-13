using System.ComponentModel.DataAnnotations;

namespace Day1ITIASP.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Range(20, 65)]
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public string? Image { get; set; }

        public DateTime HireDate { get; set; }

        public string? Address { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }

        // Navigation
        public Department Department { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new List<InstructorCourse>();
    }
}
