using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleDemo.OCP
{
    public class Invoice
    {
        public double GetInvoiceDiscount(double amount, string invoiceType)
        {
            double finalAmount = 0;
            if(invoiceType == "FinalInvoice")
            {
                finalAmount = amount - 100;
            }
            else if(invoiceType == "ProposedInvoice")
            {
                finalAmount = amount - 50;
            }
            else
            {
                finalAmount = amount;
            }
            return finalAmount;
        }
    }

    public class BeforeOCP
    {
        public static void GetInvoice()
        {
            Invoice invoice = new Invoice();

            double FInvoiceAmount = invoice.GetInvoiceDiscount(1500, "FinalInvoice");
            Console.WriteLine("Final invoice amount: {0}", FInvoiceAmount);

            double PInvoiceAmount = invoice.GetInvoiceDiscount(1500, "ProposedInvoice");
            Console.WriteLine("Proposed invoice amount: {0}", PInvoiceAmount);
        }
    }
}
