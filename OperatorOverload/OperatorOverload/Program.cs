using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create the first Employee
            Employee emp1 = new Employee();
            //create the second employee
            Employee emp2 = new Employee();
            //assign an id to first employee
            emp1.Id = 1;
            //assign an id to second employee
            emp2.Id = 2;

            //Check the employee ids are same or not
            if(emp1.Id == emp2.Id)
            {
                Console.WriteLine("Both the employees have the same Id");
            }
            else
            {
                {
                    Console.WriteLine("The employee Id's are different");
                }
            }


        }
    }
}
