using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
    internal class Class1
    {
        Account[] acounts =
{
    new ("Luman","12345","saving",120000,5555),
    new ("Sujit","23456","current",210000,4444)
};

        Console.WriteLine("Enter the account credential:");
String accno = Console.ReadLine();
        Console.WriteLine("Enter your accunt pin:");
int pin = int.Parse(Console.ReadLine());

        Account loggedUser = null;
foreach(Account account in acounts)
{
    if(account.Login(accno, pin))
    {
        loggedUser = account; 
        break;
    }
}
if (loggedUser == null)
{
    Console.WriteLine("Wrong credential!");
}

Console.WriteLine("Enter your choice:");
Console.WriteLine("1. View Balance");
Console.WriteLine("2. Deposit");
Console.WriteLine("3. Withdraw");
String choice = Console.ReadLine();

if (choice.Equals("1"))
{
    loggedUser.viewBalance();
}
else
{

    {
        if (choice.Equals("2"))
        {
            Console.WriteLine("Enter the amount:");
            double amt = Convert.ToDouble(Console.ReadLine());
            loggedUser.deposite(amt);
        }
        else if (choice.Equals("3"))
        {
            Console.WriteLine("Enter the amount:");
            double amt = Convert.ToDouble(Console.ReadLine());
            loggedUser.withdraw(amt);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
    }
}
