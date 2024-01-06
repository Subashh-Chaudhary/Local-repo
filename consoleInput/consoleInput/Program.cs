using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name....");
            string name = Console.ReadLine();
            Console.WriteLine("Are you a Male or Female...");
            string gender = Console.ReadLine();
            Console.WriteLine("Id please: ");
            int id = int.Parse(Console.ReadLine());

            if(gender == "male" || gender == "Male")
            {
                Console.WriteLine("Hello Mr. " +name+ ", Welcome to our Site.");
                Console.WriteLine("Your code is {0}", id);
            }
            else
            {
                Console.WriteLine("Hello Miss. " + name + ", Welcome to our Site.");
                Console.WriteLine("Your code is {0}", id);
            }
            Console.ReadLine();
        }
    }
}
