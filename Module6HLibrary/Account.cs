namespace Bankomat
{
    public class Account
    {
        public double Balance { get; private set; }

        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true; // Успешное снятие
            }
            return false; // Недостаточно средств
        }
    }
}
