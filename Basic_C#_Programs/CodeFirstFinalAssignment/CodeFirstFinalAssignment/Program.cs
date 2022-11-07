using CodeFirstFinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstFinalAssignment
{
    public class Program    
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                var student = new Student { StudentName = "Banana" };

                db.Students.Add(student);
                db.SaveChanges();


            }
        }
    }
}