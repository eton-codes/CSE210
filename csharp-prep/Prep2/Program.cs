using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int integer = int.Parse(grade);

        string alphabet = "";

        if (integer >= 90)
        {
            alphabet = "A";
        }
        else if (integer >= 80)
        {
            alphabet = "B";
        }
        else if (integer >= 70)
        {
            alphabet = "C";
        }
        else if (integer >= 60)
        {
            alphabet = "D";
        }
        else
        {
            alphabet = "F";
        }


        Console.WriteLine($"Your grade is: {alphabet}");

        if (integer >= 70)
        {
            Console.WriteLine("You passed!");

        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}