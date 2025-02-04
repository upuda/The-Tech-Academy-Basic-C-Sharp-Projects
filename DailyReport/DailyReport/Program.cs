using System;


    class Program
    {
        static void Main(string[] args)
        {
        //To print the Academy name and report name
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report.");

        //To print the name of the Student
        Console.WriteLine("What is your name?");
        String name = Console.ReadLine();

        //To print the course in which the Student is on
        Console.WriteLine("What course are you on?");
        String course = Console.ReadLine();

        //To print the page number
        Console.WriteLine("What page number?");
        String pageNum = Console.ReadLine();

        //To print whether the student need help with anything
        Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        String helpNeeded = Console.ReadLine();

        //To print any positive experiences which Student would like to share
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        String posExperiences = Console.ReadLine();

        //To print the student feedback
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        String feedback = Console.ReadLine();

        //To print the hours student study today
        Console.WriteLine("How many hours did you study today?");
        String hours = Console.ReadLine();
        int studyHours = Convert.ToInt32(hours);

        //To print the thanks message
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.ReadLine();
    }
    }
