using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


string[] shapes = { "Triangle", "Rectangle", "Circle" };
Console.WriteLine("Choose a shape");
int i = 1;
foreach (var item in shapes)
{
    Console.WriteLine(i + " . " +item);
    i++;
}

int choice = int.Parse(Console.ReadLine());
return shapes[choice-1];
}

public static void selection(int shape)
{
    if (shapes[shape] == "Triangle")
    {

    }
    if (shapes[shape] == "Rectangle")
    {

    }
    if (shapes[shape] == "Circle")
    {

    }
}

*/

namespace class_based
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.setSides([3, 8, 9]);
            t.SetBase(3);
            t.SetHeight(7);
            Console.WriteLine("Perimeter  = " + t.getPerimeter());
        }
    }
}
