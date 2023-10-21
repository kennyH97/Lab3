using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Bai3_4
    {
        public void Employee_()
        {
            Employee employee = new Employee();
            Console.Write("Id: ");
            employee.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            employee.name = Console.ReadLine();
            Console.Write("Year of Birth: ");
            employee.yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary Level: ");
            employee.salaryLevel = Convert.ToDouble(Console.ReadLine());
            Console.Write("Basic Salary: ");
            employee.basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            employee.GetIncome();
            Console.WriteLine();
            employee.Display();

        }
    }
}
