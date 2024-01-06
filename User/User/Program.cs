using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Type { get; set; }

    public User(string username, string password, string type)
    {
        Username = username;
        Password = password;
        Type = type;
    }

    public void Register()
    {
        Console.WriteLine($"User registered: {Username} (Type: {Type})");
    }

    public bool Login(string enteredPassword)
    {
        return Password == enteredPassword;
    }
}