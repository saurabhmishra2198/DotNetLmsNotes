using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        public int firstNumber, secondNumber;
        public string choice = "";
        public void InterData()
        {
            Console.WriteLine("\n---------Input Recode-----------");
            Console.Write("Enter first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void ChoiceOperation()
        {
            Console.Write("\nYou want To perform another operation (Yes/No):");
            choice = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int selectChoice;
            Program pObj = new Program();
            do
            {
                Console.WriteLine("\n------------Select Choice-----------");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Divide");
                Console.Write("Select operstion which you want to perform:");
                selectChoice = Convert.ToInt32(Console.ReadLine());
                switch (selectChoice)
                {
                    case 1:
                        pObj.InterData();
                        Console.WriteLine($"The sum of the {pObj.firstNumber} and {pObj.secondNumber} is {pObj.firstNumber + pObj.secondNumber}.");
                        pObj.ChoiceOperation();
                        break;
                    case 2:
                        pObj.InterData();
                        Console.WriteLine($"The subtraction of the {pObj.firstNumber} and {pObj.secondNumber} is {pObj.firstNumber - pObj.secondNumber}.");
                        pObj.ChoiceOperation();
                        break;
                    case 3:
                        pObj.InterData();
                        Console.WriteLine($"The multiplication of the {pObj.firstNumber} and {pObj.secondNumber} is {pObj.firstNumber * pObj.secondNumber}.");
                        pObj.ChoiceOperation();
                        break;
                    case 4:
                        pObj.InterData();
                        Console.WriteLine($"The division of the {pObj.firstNumber} and {pObj.secondNumber} is {pObj.firstNumber / pObj.secondNumber}.");
                        pObj.ChoiceOperation();
                        break;
                    default:
                        Console.WriteLine("Please select choice!");
                        pObj.ChoiceOperation();
                        break;
                }
            } while (pObj.choice != "No");
        }
    }
}
