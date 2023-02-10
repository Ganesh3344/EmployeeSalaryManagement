using System;
namespace oop1b
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Enter the employee's name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter the basic salary: ");
            double basicSalary = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the number of days worked in a month: ");
            int daysWorked = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the HRA percentage: ");
            double hraPercentage = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the conveyance allowance amount: ");
            double conveyanceAllowance = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the medical allowance amount: ");
            double medicalAllowance = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the tax rate (in percentage): ");
            double taxRate = double.Parse(Console.ReadLine());



            double HRA = (basicSalary * hraPercentage) / 100;


            double salary = (basicSalary * daysWorked / 26) + HRA + conveyanceAllowance + medicalAllowance;


            double taxableIncome = salary - (conveyanceAllowance + medicalAllowance);


            double taxAmount = taxableIncome * taxRate / 100;

            Console.WriteLine("Employee Name: " +name);
            Console.WriteLine("Salary: " +salary);
            Console.WriteLine("Taxable Income: " +taxableIncome);
            Console.WriteLine("Tax Amount: " +taxAmount);

            Console.ReadLine();



        }
    }
}




