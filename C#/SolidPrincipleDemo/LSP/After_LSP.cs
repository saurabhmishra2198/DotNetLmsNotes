using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.LSP
{
    public interface ILaptop
    {
        string GetRam();
    }
    public class HpLaptop : ILaptop
    {
        public string GetRam()
        {
            return "4GB";
        }
    }
    public class AcerLaptop : ILaptop
    {
        public string GetRam()
        {
            return "8GB";
        }
    }

    public class AfterLSP
    {
        public static void GetLaptopDetail()
        {
            ILaptop laptop = new AcerLaptop();
            Console.WriteLine($"Ram of acer laptop: {laptop.GetRam()}");

            laptop = new HpLaptop();
            Console.WriteLine($"Ram of HP laptop: {laptop.GetRam()}");
        }
    }
}
