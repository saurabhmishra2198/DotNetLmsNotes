using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.SRP
{
    public class StudentClass
    {
        public int StudentId;
        public string StudentName;
        public string StudentBranch;
        public StudentClass(int studentId, string studentName, string studentBranch)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentBranch = studentBranch;
        }
        public void DisplayStudentDetail()
        {
            Console.WriteLine("Student Id: "+ StudentId);
            Console.WriteLine("Student Name: "+ StudentName);
            Console.WriteLine("Student Branch: "+ StudentBranch);
        }
    }
    public class CalculateStudentMark
    {
        public int[] mark = new int[5] {56,96,85,75,45};
        public void CalculateTotalMarks()
        {
            int TotalMark = mark.Sum();
            Console.WriteLine("Student total mark:" + TotalMark);
        }
    }
 
    public class AfterSRP
    {
        public static void StudentData()
        {
            StudentClass studentClass = new StudentClass(102, "Ram", "BCA");
            CalculateStudentMark studentMark = new CalculateStudentMark();
            studentClass.DisplayStudentDetail();
            studentMark.CalculateTotalMarks();
        }
    }


}
