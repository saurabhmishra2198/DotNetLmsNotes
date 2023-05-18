using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    public class CrudWithProject
    {
        public static void ProjectDetailsInsert()
        {
            using (StudentProjectEntities context = new StudentProjectEntities())
            {
                var project = new Project()
                {
                    ProjectName = "Python",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                };
                context.Projects.Add(project);
                context.SaveChanges();
                ProjectDisplay();
            }
        }
        public static void ProjectDetailsUpdate()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var project = context.Projects.FirstOrDefault(pro => pro.ProjectId == 5);
                project.ProjectName = "Computer";
                context.SaveChanges();
            }
            ProjectDisplay();
        }
        public static void ProjectDetailsDelete()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var project = context.Projects.FirstOrDefault(pro => pro.ProjectId == 5);
                context.Projects.Remove(project);
                context.SaveChanges();
            }
            ProjectDisplay();
        }
        public static void ProjectDisplay()
        {
            using(StudentProjectEntities context = new StudentProjectEntities())
            {
                var projects = context.Projects.ToList();
                var consoleTable = new ConsoleTable("ProjectId","ProjectName","StartDate", "EndDate");
                foreach(var project in projects)
                {
                    consoleTable.AddRow(project.ProjectId, project.ProjectName, project.StartDate, project.EndDate);
                }
                consoleTable.Write();
            }
        }
    }
}
