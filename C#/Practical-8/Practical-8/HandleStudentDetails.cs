using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    public class HandleStudentDetails : Student
    {
        List<Student> StudentList = new List<Student>();
        public void GetStudentDetails()
        {
            Console.Write("How many student you can add: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int index = 0; index < size; index++)
            {
                Console.WriteLine($"\n---------- Student Detail of {index + 1}---------");
                Console.Write("Enter student id: ");
                int studId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student branch: ");
                string branch = Console.ReadLine();
                Console.Write("Enter Student city: ");
                string city = Console.ReadLine();
                Console.Write("Enter fee amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                try
                {
                    if(amount != 0)
                    {
                        Student student = new Student()
                        {
                            StudentId = studId,
                            StudentName = name,
                            StudentBranch = branch,
                            StudentCity = city,
                            StudentFee = amount,
                        };
                        StudentList.Add(student);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Fee amount not valid!");
                    GetStudentDetails();
                }
            }
        }
        public void DisplayStudentRecord()
        {
            Console.WriteLine("\n--------------Student List--------------");
            if(StudentList.Count != 0)
            {
                foreach (Student student in StudentList)
                {
                    Console.WriteLine("\nStudent Id: {0} | Student name: {1} | Student Branch: {2} | Student City: {3} | Student fee amount: {4}", student.StudentId, student.StudentName, student.StudentBranch, student.StudentCity, student.StudentFee);
                }
            }
            else
            {
                Console.WriteLine("\n Student Record not found");
            }

        }
        public List<Student> GetStudent()
        {
            return StudentList;
        }
    }
}
