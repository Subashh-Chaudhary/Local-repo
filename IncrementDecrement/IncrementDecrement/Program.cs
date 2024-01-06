using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = a++;
            int c = b++;

            Console.WriteLine("The value of a = {0}, b = {1} and c = {2}", a, b, c);

            int d = 4;
            int e = ++d;
            int f = ++e;

            Console.WriteLine("The value of d = {0}, e = {1} and f = {2}", d, e, f);

            Console.ReadLine();

        }
    }
}
