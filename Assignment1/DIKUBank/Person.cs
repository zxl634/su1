using System;

namespace DIKUBank {
    public abstract class Person {
        public float AccountBalance { get; set; }
        public string Name;
        public float Age;
        public string Gender;

        public void PrintAccountBalance() {
            Console.WriteLine("The account balance of " + Name + " is " + AccountBalance + ".");
        }
    }
}