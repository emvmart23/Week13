namespace Week13.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; } 
        public DateTime DateTime { get; set; }

        
        public Course? Course { get; set; }
        public int? CourseID { get; set; }
        public Student? Student { get; set; }
        public int? StudentID { get; set; }
    }
}
