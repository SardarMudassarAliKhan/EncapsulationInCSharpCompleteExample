namespace EncapsulationInCSharpCompleteExample
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {balance}");
        }

        public void Withdraw(double amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
