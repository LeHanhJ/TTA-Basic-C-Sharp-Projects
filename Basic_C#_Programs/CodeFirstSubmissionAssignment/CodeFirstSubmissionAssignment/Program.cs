
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var student = new Student { StudentName = "Banana" , DateOfBirth = new DateTime(year:1999, month: 04, day: 9), };
               

                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public byte[] Photo { get; set; }
            public decimal Height { get; set; }
            public float Weight { get; set; }

            public Grade Grade { get; set; }
        }

        public class Grade
        {
            public int GradeID { get; set; }
            public string GradeName { get; set; }
            public string Section { get; set; }

            public ICollection<Student> Students { get; set; }
        }

        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Grade> Grades { get; set; }
        }

    }
}
