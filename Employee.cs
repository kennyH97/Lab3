using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary { get; set; }

        public void GetIncome()
        {
            double income;
            income = salaryLevel * basicSalary;
            Console.WriteLine("Salary : {0}", income);
        }
        public void Display()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year of Birth: " + yearOfBirth);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Salary: " + basicSalary * salaryLevel);
        }
    }
}
