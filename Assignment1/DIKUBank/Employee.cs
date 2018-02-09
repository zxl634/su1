using System;

namespace DIKUBank {
    public class Employee : Person {
        // AccountBalance has been moved to Person as this is shared between Customer and Employee
        //public float AccountBalance { get; set; }
        public float HoursWorked { get; set; }
        public string JobPosition;

        public Employee(string name, string jobPosition) {
            Name = name;
            JobPosition = jobPosition;
        }

        public void PrintHoursWorked() {
            Console.WriteLine(Name + " has worked " + HoursWorked + " hours.");
        }
    }
}