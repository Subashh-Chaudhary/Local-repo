using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Subash";
            string name2 = "Binod";

            // Comparing two strings;
            bool compareTwoString = name1 == name2;
            Console.WriteLine(compareTwoString);

            bool compareStrings = string.Equals(name1, name2);
            Console.WriteLine(compareStrings);

            int comparest = name1.CompareTo(name2);
            Console.WriteLine(comparest);


            // String length
            Console.WriteLine("{0} has {1} Characters ", name1, name1.Length);

            // Substring
            Console.WriteLine("The first character of {0} is {1}.", name1, name1.Substring(0, 1));
            Console.WriteLine("The middle characters of {0} is {1}.", name1, name1.Substring(1, 3));

            // StartsWith
            bool startsWth = name1.StartsWith("Su");
            Console.WriteLine("The name {0} is starts with \"Su\" : {1}",name1, startsWth);


            Console.ReadLine();
        }
    }
}
