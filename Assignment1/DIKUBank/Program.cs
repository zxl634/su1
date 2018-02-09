using System;

namespace DIKUBank {
    class Program {
        static void Main(string[] args) {
            
            // Create bank
            Bank bank = new Bank();
            Console.WriteLine(bank);
            
            // Create three persons, two customers and one employee
            Customer customer1 = new Customer("Anders");
            Console.WriteLine(customer1);
            Customer customer2 = new Customer("Sarah");
            Console.WriteLine(customer2);
            Employee employee1 = new Employee("Boris","Analyst");
            Console.WriteLine(employee1);
            
            // Add 40 DIKU Dollars to Sarah's account
            customer2.AccountBalance = 40;
            customer2.PrintAccountBalance();
            // Withdraw 13 Dollars
            customer2.AccountBalance = (customer2.AccountBalance - 13);
            customer2.PrintAccountBalance();
            
            // Let Boris work 40 hours
            employee1.HoursWorked = 40;
            employee1.PrintHoursWorked();
            
            // Add employees to bank
            bank.Employees.Add(employee1);
            bank.Employees.Add(new Employee("Fritz","Intern"));
            bank.Employees.Add(new Employee("Lone","CEO"));
            foreach (var e in bank.Employees) {
                // Print name of each employee
                Console.WriteLine(e.Name);
            }
            
            // Add customers to bank
            bank.Customers.Add(customer1);
            bank.Customers.Add(customer2);
            foreach (var c in bank.Customers) {
                // Print name of each customer
                Console.WriteLine(c.Name);
            }
            
            // Set Fritz' and Lone's working hours
            bank.Employees[1].HoursWorked = 60;
            bank.Employees[2].HoursWorked = 80;
            
            // Make accounting method
            bank.Accounting();
        }
    }
}