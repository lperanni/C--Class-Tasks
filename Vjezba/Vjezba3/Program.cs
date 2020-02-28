using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Vjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("HR1231231231521", 34.6, AccountType.Tekuci));
            accounts.Add(new BankAccount("HR1460249192034", 44.6, AccountType.Ziro));
            accounts.Add(new BankAccount("HR9083129381237", 54.6, AccountType.Stednja));
            accounts.Add(new BankAccount("HR1383323132135", 64.6, AccountType.Tekuci));
            accounts.Add(new BankAccount("HR1767878756578", 74.6, AccountType.Stednja));

            Console.WriteLine("########################################");
            Console.WriteLine("# 1. Dodaj novi racun    2. Ispisi sve #");
            Console.WriteLine("########################################");
            string choice = "";
            while (choice != "q")
            {
                Console.WriteLine();
                Console.Write("Enter choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        BankAccount temp = new BankAccount();
                        temp.InitAccount();
                        accounts.Add(temp);
                        break;
                    case "2":
                        foreach (var account in accounts)
                        {
                            account.PrintAccountData();
                            Console.WriteLine();
                        }
                        break;
                }
            }
            Console.WriteLine("Hvala na koristenju");
        }
        
        
    }
}