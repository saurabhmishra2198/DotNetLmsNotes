using System.ComponentModel;

namespace Practical_8
{
    internal class Program
    {
        static HandleStudentDetails handleStudent = new HandleStudentDetails();
        static ManageStudentCourse manageStudentCourse = new ManageStudentCourse();
        static HandleCourses handleCourses = new HandleCourses();
        static Scholarship scholarship = new Scholarship();
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n\t\t-----------Select One Choice---------------");
                Console.WriteLine("\t\t1. Student Menu");
                Console.WriteLine("\t\t2. Course Menu");
                Console.WriteLine("\t\t0. Exit");
                Console.Write("Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            StudentMenu();
                            break;
                        case 2:
                            Console.Clear();
                            CourseMenu();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\nInvalid input");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid format: {0}", ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nSome exception found");
                }
            } while (choice != 0);
        }
        public static void StudentMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\n\t\t-----------Student Menu-----------");
                Console.WriteLine("\t\t1. GetStudentDetails");
                Console.WriteLine("\t\t2. DisplayStudentRecord");
                Console.WriteLine("\t\t3. Go to main menu");
                Console.Write("Option:");
                option = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            handleStudent.GetStudentDetails();
                            break;
                        case 2:
                            handleStudent.DisplayStudentRecord();
                            break;
                        case 3:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("\nInvalid input");
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid format: {0}",ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nSome exception found");
                }
            }while(option != 0);
        }
        public static void CourseMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\n\t\t-----------Student Menu-----------");
                Console.WriteLine("\t\t1. DisplayCourseRecord");
                Console.WriteLine("\t\t2. Course Registraction");
                Console.WriteLine("\t\t3. Check Scholarship");
                Console.WriteLine("\t\t4. Go to main menu");
                Console.Write("Option:");
                option = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            handleCourses.DisplayCoursesDetails();
                            break;
                        case 2:
                            manageStudentCourse.TakeStudentDetails(handleStudent.GetStudent());
                            manageStudentCourse.TakeCourseDetails(handleCourses.GetCourse());
                            manageStudentCourse.TotalCourses();
                            break;
                        case 3:
                            scholarship.FindScholarStudent(manageStudentCourse.GetRegisterCourses());
                            scholarship.PrintAmount();
                            break;
                        case 4:
                            MainMenu();
                            break;
                        default:
                            Console.WriteLine("\nInvalid input");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid format: {0}", ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nSome exception found");
                }
            } while (option != 0);
        }
    }
}