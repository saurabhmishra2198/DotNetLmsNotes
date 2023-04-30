using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.LSP
{
    public class HPLaptop
    {
        public virtual string GetRam()
        {
            return "4GB";
        }
    }
    public class DellLaptop : HPLaptop
    {
        public override string GetRam()
        {
            return "8GB";
        }
    }
    public class BeforeLSP
    {
        public static void GetLaptopDetail()
        {
            HPLaptop hpLaptop = new DellLaptop();
            Console.WriteLine(hpLaptop.GetRam());
        }
    }
}
