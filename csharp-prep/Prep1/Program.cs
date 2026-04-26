using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string one = Console.ReadLine();
        Console.Write("What is your last name? ");
        string two = Console.ReadLine();

        Console.WriteLine($"Your name is {two}, {one} {two}.");
    }
}