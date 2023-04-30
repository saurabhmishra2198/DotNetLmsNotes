using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.SRP
{
    public class Student
    {
        public int StudentId;
        public string StudentName;
        public string StudentBranch;
        public int[] mark = new int[5] {22,56,41,53,56};
        public int TotalMark;
        public Student(int studentId, string studentName, string studentBranch)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentBranch = studentBranch;
        }
        public void CalculateTotalMarks()
        {
            TotalMark = mark.Sum();
        }
        public void DisplayStudentDetail()
        {
            Console.WriteLine("Student Id: "+ StudentId);
            Console.WriteLine("Student Name: "+ StudentName);
            Console.WriteLine("Student Branch: "+ StudentBranch);
            Console.WriteLine("Student TotalMark: "+ TotalMark);
        }
    }
    public class BeforeSRP 
    {
        public static void StudentData()
        {
            Student student = new(101, "Saurabh", "MCA");
            student.CalculateTotalMarks();
            student.DisplayStudentDetail();
        }
    }
}
