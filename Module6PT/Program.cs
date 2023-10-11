using Bankomat.Bankomat;
using System;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM");

            // Create a new client with an account
            Client client = new Client("Alexander Graham Bell", "1945");
            client.CreateAccount(1000);

            // Simulate authentication
            if (!AuthenticateClient(client))
            {
                Console.WriteLine("Authentication failed. Exiting.");
                return;
            }

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your balance: ${client.Account.Balance}");
                            break;
                        case 2:
                            Console.Write("Enter the deposit amount: $");
                            if (double.TryParse(Console.ReadLine(), out double depositAmount))
                            {
                                client.Account.Deposit(depositAmount);
                                Console.WriteLine($"Deposited ${depositAmount} into your account.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;
                        case 3:
                            Console.Write("Enter the withdrawal amount: $");
                            if (double.TryParse(Console.ReadLine(), out double withdrawalAmount))
                            {
                                if (client.Account.Withdraw(withdrawalAmount))
                                {
                                    Console.WriteLine($"Withdrawn ${withdrawalAmount} from your account.");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;
                        case 4:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("Thank you for using the ATM.");
        }

        static bool AuthenticateClient(Client client)
        {
            int attempts = 3;
            while (attempts > 0)
            {
                Console.Write("Enter your PIN: ");
                string inputPin = Console.ReadLine();
                if (client.ValidatePin(inputPin))
                {
                    Console.WriteLine("Authentication successful.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid PIN. Attempts remaining: " + (attempts - 1));
                    attempts--;
                }
            }
            return false;
        }
    }

    namespace Bankomat
    {
        class Client
        {
            public string Name { get; }
            public Account Account { get; }
            private string Pin { get; }

            public Client(string name, string pin)
            {
                Name = name;
                Pin = pin;
                Account = new Account();
            }

            public bool ValidatePin(string inputPin)
            {
                return inputPin == Pin;
            }

            public void CreateAccount(double initialBalance)
            {
                Account.Balance = initialBalance;
            }
        }

        class Account
        {
            public double Balance { get; set; }

            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public bool Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    return true;
                }
                return false;
            }
        }
    }
}
