using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project1
{
    public  class Employee
    {
        public string? EmployeeName { get; set; }
        public string? EmployeeAddress { get; set; }
        public double Salary { get; set; }
        public void EmployeeInfo()
        {
            Console.WriteLine("\n\t***EMPLOYEE dETAILS***");
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Age: " + EmployeeAddress);
            Console.WriteLine("Employee Salary: " + Salary);
            EmployeeSalary objEmployeeSalary=new EmployeeSalary();
            objEmployeeSalary.CalculateSalary(Salary);
        }
    }
}
