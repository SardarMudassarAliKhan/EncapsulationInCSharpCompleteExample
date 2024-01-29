namespace EncapsulationInCSharpCompleteExample
{
    public class Bank
    {
        private string name;
        private Customer[] customers;

        public Bank(string name, Customer[] customers)
        {
            this.name = name;
            this.customers = customers;
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Bank Name: {name}");
            foreach(var customer in customers)
            {
                customer.DisplayAccountInfo();
            }
        }
    }
}
