﻿namespace Day1ITIASP.Models
{
    public class StudentCourse
    {
        

        public int StudentSSN { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int Grade { get; set; }
    }
}
