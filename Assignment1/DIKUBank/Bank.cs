using System;
using System.Collections.Generic;

namespace DIKUBank {
    public class Bank : Company {

        public float BankBalance { get; set; } = 20000000;
        public List<Employee> Employees;
        public List<Customer> Customers;

        public Dictionary<string, int> HourlyRate;
        public Dictionary<string, int> HourlyValue;
        
        public Bank() {
            BankBalance = BankBalance;
            Employees = new List<Employee>();
            Customers = new List<Customer>();
            HourlyRate = new Dictionary<string, int>() {
                {"Analyst",100},
                {"Intern",50},
                {"CEO",500}
            };
            HourlyValue = new Dictionary<string, int>() {
                {"Analyst",150},
                {"Intern",100},
                {"CEO",500}
            };
        }
        // 4. In the bank, create an accounting method as follows:
        //     • For every employee, get their individual job position and hours worked.
        //     • Using their job position, find out how much total value they have add to the bank.
        //       Add this amount to the bank balance.
        //     • Using their job position, find out which hourly rate they qualify for and pay out a salary proportionate to the hours worked.
        // 5. Print out the bank balance before and after paying all the employees.
        //     • Hint: use a get-method to get the bank balance before paying.
        public void Accounting() {
            // Print out bank balance before adding value
            Console.WriteLine("BankBalance before adding value and paying employees " + BankBalance);
            // Get job position and hours worked for each employee
            foreach (var e in Employees) {
                // For every employee, get their individual job position and hours worked.
                if (HourlyValue.TryGetValue(e.JobPosition, out int value)) {
                    // Using their job position, find out how much total value they have add to the bank.
                    // Add value to BankBalance
                    BankBalance += value * e.HoursWorked;
                }
                if (HourlyRate.TryGetValue(e.JobPosition, out int rate)) {
                    // Pay wage to employee
                    e.AccountBalance += rate * e.HoursWorked;
                    // Substract wage from BankBalance
                    BankBalance += rate * e.HoursWorked;
                }
            }
            Console.WriteLine("BankBalance after adding value and paying employees " + BankBalance);
        }
    }
}