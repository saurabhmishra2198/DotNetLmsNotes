using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            while (true)
            {
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CrudWithProject.ProjectDetailsInsert();
                        CrudWithSchool.InsertSchoolDetails();
                        break;
                    case 2:
                        CrudWithProject.ProjectDisplay();
                        CrudWithSchool.DisplayStudentDetails();
                        break;
                    case 3:
                        CrudWithProject.ProjectDetailsUpdate();
                        break;
                    case 4:
                        CrudWithProject.ProjectDetailsDelete();
                        break;

                }
            }
        }
    }
}
