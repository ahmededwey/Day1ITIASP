namespace Day1ITIASP.Models
{
    public class InstructorCourse
    {
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public decimal RateHour { get; set; }
    }

}
