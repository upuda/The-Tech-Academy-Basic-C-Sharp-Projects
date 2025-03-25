using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Defining the IQuittable interface with a void Quit() method
    public interface IQuittable
    {
        void Quit();
    }

    //Employee class implemends IQuittable interface
    public class Employee : IQuittable
    {
        //Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("The employee has quit the job.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            IQuittable obj = new Employee();
            obj.Quit();
        }
    }
}
