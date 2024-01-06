using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priceFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pricePerSquareFoot = 6.5;

            Console.WriteLine("Please enter the length(ft.) of the carpet.");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width(ft.) of the carpet.");
            double width = double.Parse(Console.ReadLine());

            double squarefoot = length* width;
            double price = squarefoot * pricePerSquareFoot;

            Console.WriteLine("Length: " + length +"ft");
            Console.WriteLine("Width: " + width +"ft");
            Console.WriteLine("Area: " + squarefoot + " squarefoot");
            Console.WriteLine("Pricing per square foot: Rs." + pricePerSquareFoot);
            Console.WriteLine("Total Cost: Rs." +price);

            Console.ReadLine();
        }
    }
}
