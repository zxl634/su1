namespace DIKUBank {
    public class Customer : Person {
        // AccountBalance has been moved to Person as this is shared between Customer and Employee
        //public float AccountBalance { get; set; }

        public Customer(string name) {
            this.Name = name;
        }
    }
}