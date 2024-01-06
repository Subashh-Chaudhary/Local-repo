using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    internal class Program
    {
        // Lecture 2 Datatypes and Concatination
        static void Main(string[] args)
        {
            
            int id = 001;
            string code = "SU001";
            string name = "Subash";
            char character = 'S';
            long salary = 2000000000000000000;
            bool isLoggedIn = false;

            Console.WriteLine("Id : {0, -10} Code : {1}", id , code);
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Salary : {0}", salary);

            Console.WriteLine("Id : " + id + "          Code : " + code + "          IsLoggedIn : " + isLoggedIn +
                "          Character : " + character);


            Console.ReadLine();
        }
    }
}
