using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            

            Console.Write("Enter your age: ");
            int age = Int16.Parse(Console.ReadLine());
            
            Console.WriteLine("Hello "+name +" !");
            Console.WriteLine("Your age is "+age);
        } 
    }
}
