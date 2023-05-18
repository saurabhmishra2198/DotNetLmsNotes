using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    public class CrudWithSchool
    {
        public static void InsertSchoolDetails()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var stud = new Student()
                {
                    StudentName = "Ramesh Kumar",
                    StudentEmail = "ramesh@gmail.com",
                    StudentBranch = "MCA",
                    DateOfBirth = DateTime.Now,
                    ProjectId = 3,
                };
                context.Students.Add(stud);
                context.SaveChanges();
                DisplayStudentDetails();
            }
        }
        public static void DisplayStudentDetails()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var students = context.Students.ToList();
                var consoleTable = new ConsoleTable("StudentID", "StudentName", "StudentEmail", "StudentBranch", "DOB", "ProjectID");
                foreach(var student in students)
                {
                    consoleTable.AddRow(student.StudentId, student.StudentName, student.StudentEmail, student.StudentBranch, student.DateOfBirth, student.ProjectId);
                }
                consoleTable.Write();
            }
        }
        
    }
}
