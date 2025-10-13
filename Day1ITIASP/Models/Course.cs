using System.ComponentModel.DataAnnotations;

namespace Day1ITIASP.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public string Topic { get; set; }

        public int Degree { get; set; }

        public int MinDegree { get; set; }

        // Navigation
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new List<InstructorCourse>();
    }


}
