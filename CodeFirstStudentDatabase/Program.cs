using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Metadata;

namespace CodeFirstStudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Student
                Console.Write("Enter the First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter the Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email
                };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Students
                var allStudents = db.Students.OrderBy(s => s.FirstName).ToList();

                Console.WriteLine("Students in the database:");
                foreach (var s in allStudents)
                {
                    Console.WriteLine(s.FirstName, s.LastName, s.Email);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}