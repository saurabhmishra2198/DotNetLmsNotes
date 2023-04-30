using SolidPrincipleDemo.LSP;
using SolidPrincipleDemo.OCP;
using SolidPrincipleDemo.SRP;

namespace SolidPrincipleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("--------------- Before SRP --------------");
            //BeforeSRP.StudentData();
            //Console.WriteLine("--------------- After SRP --------------");
            //AfterSRP.StudentData();

            //Console.WriteLine("--------------- Before OCP --------------");
            //BeforeOCP.GetInvoice();
            //Console.WriteLine("--------------- After OCP --------------");
            //AfterOCP.GetInvoice();

            Console.WriteLine("--------------- Before LSP --------------");
            BeforeLSP.GetLaptopDetail();
            Console.WriteLine("--------------- After LSP --------------");
            AfterLSP.GetLaptopDetail();
        }
    }
}