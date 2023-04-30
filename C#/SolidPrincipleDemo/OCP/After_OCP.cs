using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.OCP
{
    public class AmountInvoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }
    public class FinalInvoice : AmountInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 100;
        }
    }
    public class ProposedInvoice : AmountInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class RecurringInvoice : AmountInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
    public class AfterOCP
    {
        public static void GetInvoice()
        {
            Console.WriteLine("Invoice amount is: " + 5000);

            AmountInvoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(5000);
            Console.WriteLine("Final invoice amount: {0}", FInvoiceAmount);

            AmountInvoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(5000);
            Console.WriteLine("Proposed invoice amount: {0}", PInvoiceAmount);

            AmountInvoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(5000);
            Console.WriteLine("Recurring Invoice: {0}", RInvoiceAmount);
        }
    }
}
