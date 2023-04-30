using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    public abstract class StudentCourseRegister
    {
        public  abstract void TakeStudentDetails(List<Student> students);
        public abstract void TakeCourseDetails(List<Course> Courses);
        public abstract void TotalCourses();
    }
    public class ManageStudentCourse : StudentCourseRegister
    {
        List<RegisterCourses> TotalCourse = new List<RegisterCourses>();

        public int Id;
        public string Name;
        public string CourseId;
        public string CourseName;
        public decimal Amount;
        public override void TakeStudentDetails(List<Student> students)
        {
            Console.Write("Enter Your id: ");
            int StudId = Convert.ToInt32(Console.ReadLine());
            foreach (Student student in students)
            {
                if(student.StudentId == StudId)
                {
                    Id = student.StudentId;
                    Name = student.StudentName;
                }
            }
        }
        public override void TakeCourseDetails(List<Course> Courses)
        {
            Console.Write("Enter course id: ");
            string CourseId = Console.ReadLine();
            foreach (Course course in Courses)
            {
                if (course.CourseId == CourseId)
                {
                    CourseId = course.CourseId;
                    CourseName = course.CourseName;
                    Amount = course.CourseAmount;
                }
            }
        }
        public override void TotalCourses()
        {
            RegisterCourses registerCourses = new RegisterCourses()
            {
                StudentId = Id,
                StudentName = Name,
                CourseId = CourseId,
                CourseName = CourseName,
                CourseAmount = Amount,
            };
            TotalCourse.Add(registerCourses);
            Console.WriteLine("\nCourse Registraction successfully!");
        }
        public List<RegisterCourses> GetRegisterCourses()
        {
            return TotalCourse;
        }

    }
    
}
