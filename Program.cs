using EncapsulationInCSharpCompleteExample;

BankAccount acc1 = new BankAccount("123456", 1000);
BankAccount acc2 = new BankAccount("654321", 2000);

Customer cust1 = new Customer("Alice", acc1);
Customer cust2 = new Customer("Bob", acc2);

Bank bank = new Bank("MyBank", new Customer[] { cust1, cust2 });

bank.DisplayCustomerInfo();

cust1.DisplayAccountInfo();
cust1.Deposit(500);
cust1.Withdraw(200);

cust2.DisplayAccountInfo();
cust2.Withdraw(300);