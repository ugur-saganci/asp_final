using System;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    Email = "john.doe@example.com",
                    GPA = 3.75
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                Console.WriteLine($"Email: {student.Email}");
                Console.WriteLine($"GPA: {student.GPA}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}