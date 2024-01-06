using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techiCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the time in minutes...");
            int time = int.Parse(Console.ReadLine());

            int hours = time / 60;
            int minutes = time % 60;

            Console.WriteLine("{0} is equal to {1} Hour and {2} Minutes.", time, hours, minutes);

            Console.ReadLine();
        }
    }
}
