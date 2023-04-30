using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    public class HandleCourses : Course
    {
        List<Course> CourseList = new List<Course>();
        Course firstCourse = new Course()
        {
            CourseId = "C101",
            CourseName = "OOP",
            CourseAmount = 500,
        };
        Course secondCourse = new Course()
        {
            CourseId = "C102",
            CourseName = "C#",
            CourseAmount = 300,
        };
        Course thirdCourse = new Course()
        {
            CourseId = "C103",
            CourseName = "ASP.Net",
            CourseAmount = 400,
        };
        Course fourCourse = new Course()
        {
            CourseId = "C104",
            CourseName = "SQL Server",
            CourseAmount = 367,
        };
        Course fiveCourse = new Course()
        {
            CourseId = "C105",
            CourseName = "JavaScript",
            CourseAmount = 499,
        };
        public HandleCourses()
        {
            CourseList.Add(firstCourse);
            CourseList.Add(secondCourse);
            CourseList.Add(thirdCourse);
            CourseList.Add(fourCourse);
            CourseList.Add(fiveCourse);
        }
        public void DisplayCoursesDetails()
        {
            foreach (Course course in CourseList)
            {
                Console.WriteLine("\nCourse Id: {0} | Course name: {1} | Course amount: {2}", course.CourseId, course.CourseName, course.CourseAmount);
            }
        }
        public List<Course> GetCourse()
        {
            return CourseList;
        }
    }
}
