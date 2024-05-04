using System;

namespace Task7
{
    //Task 7
    //Question 1
    public class TrackingNumberNotFoundException : Exception
    {
        public TrackingNumberNotFoundException(string message) : base(message)
        {
        }
    }
    public class Account
    {
        private int balance = 1000;
        public void Withdraw(int amount, string trackingNumber)
        {
            if (string.IsNullOrEmpty(trackingNumber))
            {
                throw new TrackingNumberNotFoundException("Tracking number not found. Cannot withdraw amount.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount} successfully. New balance: {balance}");
        }

        public void Transfer(int amount, string trackingNumber)
        {
            if (string.IsNullOrEmpty(trackingNumber))
            {
                throw new TrackingNumberNotFoundException("Tracking number not found. Cannot transfer amount.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
            balance -= amount;
            Console.WriteLine($"Transferred {amount} successfully. New balance: {balance}");
        }
    }
    public class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();
                string trackingNumber = "XYZ123";
                account.Withdraw(500, trackingNumber);
                account.Transfer(200, trackingNumber);
                account.Withdraw(100, "");
            }
            catch (TrackingNumberNotFoundException ex)
            {
                Console.WriteLine($"TrackingNumberNotFoundException: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
