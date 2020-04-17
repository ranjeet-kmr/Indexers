using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class TestEmploye
    {
        public static void xs()
        {
            var emp = new Employee(1001, 23132321, "SoftwareDeveloper", "LeadEngineer", "Noida", "Ranjeet");

            Console.WriteLine("Employee ID : " + emp[0]);
            Console.WriteLine("Employee Name : " + emp[1]);
            Console.WriteLine("Employee Salary : " + emp[2]);
            Console.WriteLine("Employee Job : " + emp[3]);
            Console.WriteLine("Employee Location : " + emp[4]);
            Console.WriteLine("Employee Designation Name : " + emp[5]);
            Console.WriteLine("----------------------------------------------------");

            emp[1] = "John";
            
            Console.WriteLine("Employee ID : " + emp[0]);
            Console.WriteLine("Employee Name : " + emp[1]);
            Console.WriteLine("Employee Salary : " + emp[2]);
            Console.WriteLine("Employee Job : " + emp[3]);
            Console.WriteLine("Employee Location : " + emp[4]);
            Console.WriteLine("Employee Designation Name : " + emp[5]);

            Console.ReadLine();

        }
    }
}
