using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary with definitions
            Dictionary<string, string> Definitions = new Dictionary<string, string>
        {
            { "class", "A blueprint or template for creating objects. It defines the structure and behavior of objects." },
            { "object", "An instance of a class. It is a concrete realization of the blueprint defined by a class." },
            { "constructor", "A special method in a class that is called when an instance of the class is created. " +
            "It is used to initialize the object's state." },
            { "OOP", "Object-Oriented Programming. A programming paradigm that uses objects and classes to organize " +
            "code and implement concepts such as encapsulation, inheritance, polymorphism, and abstraction." },
            { "encapsulation", "The bundling of data and methods that operate on the data into a single unit (class). " +
            "It restricts access to some of an object's components and prevents the direct modification of " +
            "its internal state." },
            { "inheritance", "A mechanism in OOP that allows a class (subclass or derived class) to inherit " +
            "properties and behaviors from another class (base class or parent class). It promotes code reuse " +
            "and the creation of a hierarchy of classes." },
            { "polymorphism", "The ability of objects to take on multiple forms. In OOP, it refers to the " +
            "ability of different classes to be treated as instances of the same class through a common " +
            "interface, allowing for code flexibility and extensibility." },
            { "abstraction", "The process of simplifying complex systems by modeling classes based on " +
            "essential properties and behaviors. It involves hiding the unnecessary details and showing " +
            "only the essential features of an object." }
        };

            // Accessing and displaying the definitions
            Console.WriteLine("Definitions:");
            foreach (var term in Definitions)
            {
                Console.WriteLine($"{term.Key}\n");
            }

            Console.WriteLine("What do you want to know:");

            string targetKey = ( Console.ReadLine() );

            foreach(var term in Definitions)
            {
                if (targetKey == $"{term.Key}")
                {
                    Console.WriteLine($"Definition: {term.Value}");
                }
            }
            Console.ReadLine();
        }
    }
}
