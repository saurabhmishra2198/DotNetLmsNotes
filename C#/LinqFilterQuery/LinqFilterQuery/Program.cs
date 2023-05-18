using ConsoleTables;

namespace LinqFilterQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee() {EmployeeId = 1, EmployeeName = "Saurabh",Salary=50000,ProjectId = 1},
                new Employee() {EmployeeId = 2, EmployeeName = "Jimit",Salary=56000,ProjectId = 2},
                new Employee() {EmployeeId = 3, EmployeeName = "Ramesh",Salary=48500,ProjectId = 1},
                new Employee() {EmployeeId = 4, EmployeeName = "Ram",Salary=34500,ProjectId = 2},
                new Employee() {EmployeeId = 5, EmployeeName = "Shuresh",Salary=45000,ProjectId = 1},
            };
            List<Project> ProjectList = new List<Project>()
            {
                new Project() {ProjectId = 1,ProjectName = "Java"},
                new Project() {ProjectId = 2,ProjectName = "DotNet"},
            };


            //var EmployeeProject = EmployeeList.Join(ProjectList,
            //                                        emp => emp.ProjectId,
            //                                        pro => pro.ProjectId,
            //                                        (emp, pro) => new
            //                                        {
            //                                            EmpName = emp.EmployeeName,
            //                                            ProName = pro.ProjectName,
                                                       
            //                                        });
            var result = from emp in EmployeeList
                         join pro in ProjectList on emp.ProjectId equals pro.ProjectId
                         group emp by new { emp.EmployeeName, pro.ProjectName } into g
                         select new
                         {
                             g.Key.EmployeeName,
                             g.Key.ProjectName,
                             ProjectCount = g.Count()
                         };
            var consoleTable = new ConsoleTable("EmployeeName", "ProjectName", "ProjectCount");
            foreach (var emp in result)
            {
                consoleTable.AddRow(emp.EmployeeName, emp.ProjectName, emp.ProjectCount);
            }
            consoleTable.Write();

        }
    }
}