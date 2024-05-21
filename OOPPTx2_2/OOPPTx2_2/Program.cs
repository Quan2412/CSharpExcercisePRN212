using OOPTx2_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Create collection to store employee object and customers object
    static List<Employee> employees = new List<Employee>();
    static List<Customer> customers = new List<Customer>();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Find Employee with Highest Salary");
            Console.WriteLine("4. Find Customer with Lowest Balance");
            Console.WriteLine("5. Find Employee by Name");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    AddCustomer();
                    break;
                case "3":
                    FindEmployeeWithHighestSalary();
                    break;
                case "4":
                    FindCustomerWithLowestBalance();
                    break;
                case "5":
                    FindEmployeeByName();
                    break;
                case "6":
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
        // Catch error using try catch, if input is in wrong format, return exception error message
        try
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter employee address: ");
            string address = Console.ReadLine();

            Console.Write("Enter employee salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee { Name = name, Age = age, Address = address, Salary = salary };
            employees.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }
        // Catch exception
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void AddCustomer()
    {
        // Similar to AddEmployee
        try
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter customer age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();

            Console.Write("Enter customer balance: ");
            double balance = double.Parse(Console.ReadLine());

            Customer customer = new Customer { Name = name, Age = age, Address = address, Balance = balance };
            customers.Add(customer);
            Console.WriteLine("Customer added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void FindEmployeeWithHighestSalary()
    {
        // Sort collection based on salary and return the first element of the collection
        var employeeWithHighestSalary = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        // If collection is empty, print out message, else print out employee
        Console.WriteLine("Employee with the highest salary:");
        if (employeeWithHighestSalary != null)
            employeeWithHighestSalary.Display();
        else
            Console.WriteLine("No employees found.");
    }

    static void FindCustomerWithLowestBalance()
    {
        // Sort collection based on salary and return the first element of the collection
        var customerWithLowestBalance = customers.OrderBy(c => c.Balance).FirstOrDefault();
        // If collection is empty, print out message, else print out customer
        Console.WriteLine("Customer with the lowest balance:");
        if (customerWithLowestBalance != null)
            customerWithLowestBalance.Display();
        else
            Console.WriteLine("No customers found.");
    }

    static void FindEmployeeByName()
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();
        // Return employee with name matches input
        var foundEmployees = employees.Where(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        // Display employee
        Console.WriteLine("Employees found:");
        foreach (var employee in foundEmployees)
        {
            employee.Display();
        }
    }
}