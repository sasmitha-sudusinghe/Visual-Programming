using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit casting || Auto
            int number; //declaration
            number = 10; //initialization

            double converetedNumber = number;

            Console.WriteLine(number);
            Console.WriteLine(converetedNumber);
            

            //Explicit casting || Manual
            double number1 = 10.5; //Declaration and Initialization
            int convertednumber1 = (int)number1;

            Console.WriteLine(number1);
            Console.WriteLine(convertednumber1);
            Console.ReadLine();
        }
    }
}
