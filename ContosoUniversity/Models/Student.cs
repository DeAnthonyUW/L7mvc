using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-djthomas-dykstra1] - Given student class to be used as one of three entities in our data model.
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}