using System;
using Bankomat; 

namespace MyConsoleAppNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAttempts = 3;
            string correctPassword = "imdabest"; // Password

            Console.WriteLine("Welcome to the ATM!");

            for (int attempts = 1; attempts <= maxAttempts; attempts++)
            {
                Console.Write("Please enter your credit card password: ");
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == correctPassword)
                {
                    Console.WriteLine("Password is correct. Access granted.");
                    ShowMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Password is incorrect. Please try again.");
                    if (attempts == maxAttempts)
                    {
                        Console.WriteLine("All attempts exhausted. Exiting the application.");
                        break;
                    }
                }
            }
        }

        static void ShowMenu()
        {
            Account account = new Account(1000.0); // Initial balance

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("a. Display balance");
                Console.WriteLine("b. Deposit funds");
                Console.WriteLine("c. Withdraw funds");
                Console.WriteLine("d. Exit");

                Console.Write("Choose an action (a/b/c/d): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Current balance: " + account.Balance);
                        break;
                    case "b":
                        Console.Write("Enter the amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                            Console.WriteLine("Account successfully funded. New balance: " + account.Balance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount input.");
                        }
                        break;
                    case "c":
                        Console.Write("Enter the amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            if (account.Withdraw(withdrawAmount))
                            {
                                Console.WriteLine("Amount successfully withdrawn. New balance: " + account.Balance);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds to withdraw.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount input.");
                        }
                        break;
                    case "d":
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
