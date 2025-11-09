using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;
            int number3 = 20;

            //Mathematical Operators
            Console.WriteLine(number1+number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / (double)number2);
            Console.WriteLine(number1 % number2);
            Console.WriteLine();

            //Comparison Operators
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 != number2);
            Console.WriteLine(number3 != number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 >= number2);
            Console.WriteLine(number1 <= number2);
            Console.WriteLine();

            //Logical Operators
            Console.WriteLine(number1 < number2 && number2 == number3);
            Console.WriteLine(number1 < number2 || number2 == number3);
            Console.WriteLine(!(number1 < number2));
        }
    }
}
