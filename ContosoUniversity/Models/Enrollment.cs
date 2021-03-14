namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-11-djthomas-dykstra1] - Given Enrollment class to be used as one of three entities in our data model.
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}