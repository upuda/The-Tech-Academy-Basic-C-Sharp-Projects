using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathOperation class
            MathOperation obj = new MathOperation();

            //Call the method by passing in two numbers
            obj.PerformMathOperation(3, 4);

            //Call the method by specifying the parameters by name
            obj.PerformMathOperation(num1: 10, num2: 5);

            Console.ReadLine();
        }
    }

    class MathOperation
    {
        public void PerformMathOperation(int num1, int num2)
        {
            //Perform a mathematical operation on the number 1
            int result = num1 * 2;
            //display the result of the operation on the first number
            Console.WriteLine("Result of operation on the first number is: "+result);
            //display the second integer on the screen
            Console.WriteLine("Second number is: "+num2);
        }
    }
}
