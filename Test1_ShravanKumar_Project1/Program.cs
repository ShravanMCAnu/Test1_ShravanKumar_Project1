// See https://aka.ms/new-console-template for more information
using Test1_ShravanKumar_Project1;

Employee objEmployee = new Employee();
Console.WriteLine("Enter Employee Name");
objEmployee.EmployeeName = Console.ReadLine();
Console.WriteLine("Enter Employee Address");
objEmployee.EmployeeAddress = Console.ReadLine();
Console.WriteLine("Enter Employee Salary");
objEmployee.Salary = Convert.ToDouble(Console.ReadLine());
objEmployee.EmployeeInfo();

