using System;

    class Program
    {
        static void Main(string[] args)
        {
        int counter = 1;
        //Using while loop
        while (counter <= 5)
        {
            Console.WriteLine("Counter is: " + counter);
            counter++;
        }

        int num = 10;
        //Using do-while loop
        do
        {
            Console.WriteLine("Number is: " + num);
            num++;
        } while (num < 15);
        }
    }

