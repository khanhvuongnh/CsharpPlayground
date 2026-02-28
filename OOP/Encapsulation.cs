namespace CsharpPlayground.OOP.Encapsulation
{
    /*
        Encapsulation is a principle that allows hiding the internal details of an object's implementation and providing limited access to them. 
        This makes the code more secure and maintainable. 
        In this example, balance is a private field, and access to it is managed through the methods Deposit and GetBalance. 
        This allows for controlling changes to the account balance and ensuring safe access to its value.
    */

    class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
