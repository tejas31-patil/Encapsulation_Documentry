namespace Encapsulation
{
    public class BankAccount
    {
        // Private field to hold the account balance
        private decimal balance;

        // Public method to get the current balance (controlled access)
        public decimal GetBalance()
        {
            return balance;
        }

        // Public method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Public method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(1000);  // Output: Deposited: $1,000.00. New Balance: $1,000.00
            account.Withdraw(500);  // Output: Withdrew: $500.00. New Balance: $500.00
            account.Withdraw(600);  // Output: Insufficient balance or invalid amount.
        }
    }

}
/*
 * How to Explain It in the Interview:
Introduction:

"Encapsulation is a concept in object-oriented programming where we hide the internal data of an object 
and expose only necessary functionality through public methods."
Example:

"For example, in this BankAccount class, the balance field is private, which means it can't be accessed 
directly from outside the class. This protects the data from being changed arbitrarily."
Controlled Access:

"Instead, I provide public methods like Deposit and Withdraw to interact with the balance.
This ensures that any deposit or withdrawal is validated (for example, the deposit amount must be positive,
and withdrawals can only happen if there are enough funds)."
Data Security:

"This controlled access ensures that the balance is always modified in a safe and predictable manner,
which is the essence of encapsulation."

 * */
