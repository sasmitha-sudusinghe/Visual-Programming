using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double marks;

            Console.Write("Enter your marks: ");
            marks=double.Parse(Console.ReadLine());

            if (marks >= 75)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 65)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 55)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 45)
            {
                Console.WriteLine("Grade S");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
