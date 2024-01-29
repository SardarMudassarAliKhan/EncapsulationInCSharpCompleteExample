namespace EncapsulationInCSharpCompleteExample
{
    public class Customer
    {
        private string name;
        private BankAccount account;

        public Customer(string name, BankAccount account)
        {
            this.name = name;
            this.account = account;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Customer: {name}");
            Console.WriteLine($"Account Number: {account.Balance}");
            Console.WriteLine($"Balance: {account.Balance}");
        }

        public void Deposit(double amount)
        {
            account.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            account.Withdraw(amount);
        }
    }
}
