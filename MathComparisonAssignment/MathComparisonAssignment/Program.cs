using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program");

        //To print the Person 1  details on the screen
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        
        //To get the user input related to person 1
        string hourlyRate1 = Console.ReadLine();
        Console.WriteLine("Hours worked per week?");
        string hours1 = Console.ReadLine();
        
        //Using the math operators to calculate the salary of person 1
        int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
        Console.WriteLine("Annual salary of Person 1: " + salary1);
        //To print the Person 1  details on the screen
        Console.WriteLine("Person 2");
        Console.WriteLine("hourly rate?");

        //To get the user input related to person 2
        string hourlyRate2 = Console.ReadLine();
        Console.WriteLine("Hours worked per week?");
        string hours2 = Console.ReadLine();


        //Using the math operators to calculate the salary of person 2
        int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
        Console.WriteLine("Annual salary of Person 2: " + salary2);
        Console.WriteLine("Person 1 makes more money than Person 2");
        bool isMore = salary1 > salary2;
        Console.WriteLine(isMore);
        Console.ReadLine();
        }
    }

