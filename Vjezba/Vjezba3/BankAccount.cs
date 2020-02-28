using System;

namespace Vjezba3
{
    public class BankAccount
    {
        public BankAccount()
        {
            
        }
        public BankAccount(string iban, double accountBalance, AccountType type)
        {
            Iban = iban;
            AccountBalance = accountBalance;
            this.type = type;
        }
        private string Iban { get; set; }
        private double AccountBalance { get; set; }
        private AccountType type { get; set; }

        public void InitAccount()
        {
            Console.Write("Enter Iban: ");
            this.Iban = Console.ReadLine();
            this.AccountBalance = 0;
            Console.WriteLine($"{(int) AccountType.Stednja}.Stednja    {(int) AccountType.Tekuci}.Tekuci    {(int) AccountType.Ziro}.Ziro");
            Console.Write("Enter Type: ");
            this.type = (AccountType) Convert.ToInt32(Console.ReadLine());
        }

        public void PrintAccountData()
        {
            Console.WriteLine("Iban: " + Iban);
            Console.WriteLine("Balance: " + AccountBalance);
            Console.WriteLine("Type: " + type);
        }
    }
}