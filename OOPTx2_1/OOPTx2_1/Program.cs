using OOPTx2_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            // Print out menu
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Find Employee with Highest Salary");
            Console.WriteLine("3. Find Employee by Name");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    FindEmployeeWithHighestSalary();
                    break;
                case "3":
                    FindEmployeeByName();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddEmployee()
    {
        Console.Write("Enter employee type (1 - Full-time, 2 - Part-time): ");
        string type = Console.ReadLine();

        //Use try catch for exceptional input -> return error message
        try
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter payment per hour: ");
            double paymentPerHour = double.Parse(Console.ReadLine());
            // Create new employee based on input
            Employee employee;
            if (type == "1")
            {
                employee = new FullTimeEmployee { Name = name, PaymentPerHour = paymentPerHour };
            }
            else if (type == "2")
            {
                Console.Write("Enter working hours: ");
                double workingHours = double.Parse(Console.ReadLine());
                employee = new PartTimeEmployee { Name = name, PaymentPerHour = paymentPerHour, WorkingHours = workingHours };
            }
            else
            {
                Console.WriteLine("Invalid employee type.");
                return;
            }

            employees.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void FindEmployeeWithHighestSalary()
    {
        // Sort collection based on salary(Descending) and print out the first element
        var fullTimeEmployee = employees.OfType<FullTimeEmployee>().OrderByDescending(e => e.CalculateSalary()).FirstOrDefault();
        var partTimeEmployee = employees.OfType<PartTimeEmployee>().OrderByDescending(e => e.CalculateSalary()).FirstOrDefault();

        Console.WriteLine("Employee with the highest salary:");
        if (fullTimeEmployee != null)
            Console.WriteLine(fullTimeEmployee);
        if (partTimeEmployee != null)
            Console.WriteLine(partTimeEmployee);
    }

    static void FindEmployeeByName()
    {
        //Find Employee by name
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        var foundEmployees = employees.Where(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Employees found:");
        foreach (var employee in foundEmployees)
        {
            Console.WriteLine(employee);
        }
    }
}