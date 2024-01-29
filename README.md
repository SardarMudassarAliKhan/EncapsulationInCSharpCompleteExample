In the provided example, we have a simple banking system implemented in C# using object-oriented programming principles, with a focus on encapsulation.

**BankAccount Class:**  
This class represents a bank account and encapsulates its data and functionality. It has private fields `accountNumber` and `balance` to store the account details. The `Deposit` and `Withdraw` methods allow users to deposit or withdraw funds from the account. The `Balance` property provides read-only access to the account balance, ensuring that it can only be modified through the deposit and withdraw methods, maintaining encapsulation.

**Customer Class:**  
This class represents a bank customer and encapsulates a customer's name and associated bank account. It has methods `DisplayAccountInfo`, `Deposit`, and `Withdraw`. The `DisplayAccountInfo` method displays the customer's name, account number, and balance. The `Deposit` and `Withdraw` methods delegate the operations to the associated `BankAccount` instance, thus encapsulating the bank account details within the `Customer` class.

**Bank Class:**  
This class represents a bank and encapsulates an array of customers. It has a method `DisplayCustomerInfo` that displays the bank's name and iterates through each customer to display their account information. This class demonstrates encapsulation by hiding the details of individual customers within the bank.

**Main Method:**  
In the `Main` method, we create instances of `BankAccount`, `Customer`, and `Bank` classes to simulate a banking scenario. We deposit and withdraw funds from customer accounts and display their information using the methods provided by the `Customer` and `Bank` classes.

Encapsulation is achieved by hiding the internal implementation details of each class and providing controlled access to their functionality through well-defined interfaces. This ensures that the data and methods related to a particular entity (such as a bank account or customer) are contained within a single unit (class) and can be accessed and manipulated in a controlled manner, promoting better code organization and maintenance.
