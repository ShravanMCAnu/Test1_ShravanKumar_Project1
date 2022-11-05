using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project1
{
    public class EmployeeSalary
    {
        public double HRA, TA, DA, Tax, bonus, NetSalary;
        public double salaryValue;


        public void CalculateSalary(double _salary)
        {

            salaryValue = _salary;
            if (salaryValue < 10000)
            {
                bonus= 2500;
                HRA = salaryValue * 0.2;
                TA = salaryValue * 0.1;
                DA = salaryValue * 0.15;
                Tax = salaryValue * 0.1;
            }
            else
            {
                bonus = 4500;
                HRA = salaryValue * 0.3;
                TA = salaryValue * 0.15;
                DA = salaryValue * 0.2;
                Tax = salaryValue * 0.2;
            }
            NetSalary = salaryValue + HRA + TA + DA +bonus - Tax;

            Display();
        }
        private void Display()
        {
            Console.WriteLine("\n\tSalary Details::");
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Tax: " + Tax);
            Console.WriteLine("Bonus : " + bonus);
            Console.WriteLine("\nAnd Net Salary:: " + NetSalary);
        }


    }
}
