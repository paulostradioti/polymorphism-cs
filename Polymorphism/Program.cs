using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }

        virtual public void GetName()
        {
            Console.WriteLine("PERSON");
            Console.WriteLine("Person Name: {0}", Name);
        }

        public void GetID()
        {
            Console.WriteLine("PERSON");
            Console.WriteLine("Person ID: {0}", Name);
        }

    }

    class Employee : Person
    {
       override public void GetName()
        {
            Console.WriteLine("EMPLOYEE");
            Console.WriteLine("Employee Name: {0}", Name);
        }

        new public void GetID()
        {
            Console.WriteLine("EMPLOYEE");
            Console.WriteLine("Employee ID: {0}", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person per = new Employee();            
            Employee emp = new Employee();

            per.GetName();

            Console.WriteLine("");

            emp.GetName();

            Console.WriteLine("");

            per.GetID();

            Console.WriteLine("");

            emp.GetID();

            Console.ReadLine();
        }
    }
}
