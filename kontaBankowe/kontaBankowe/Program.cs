﻿using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Security.Principal;

namespace kontaBankowe
{
    internal class Program
    {
        public class BankAcount
        {
            private static int s_accountNumberSeed = 1234567890;

            private string _number;
            private string _owner;
            private double _balance;
            public List<Transaction> _allTransactions = new List<Transaction>();
            public BankAcount(string name, double initialBalance)
            {
                _owner = name;
                _number = s_accountNumberSeed.ToString();
                s_accountNumberSeed++;
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

            }
            public BankAcount(string Number, string Owner, double Balance)
            {
                _number = Number;
                _owner = Owner;
                _balance = Balance;
            }

            public string Number
            {
                get { return _number; }
                
            }
            public string Owner { get => _owner; set => _owner = value; }
            public double Balance
            {
                get
                {
                    _balance = 0;
                    foreach (var item in _allTransactions)
                    {
                        _balance += item.Amount;
                    }

                    return _balance;
                }
            }
            public void MakeDeposit(double amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException(nameof(amount), "Kwota depozytu musi być dodatnia\r\n");
                }
                var deposit = new Transaction(amount, date, note);
                _allTransactions.Add(deposit);
            }
            public void MakeWithdrawal(double amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException(nameof(amount), "Kwota depozytu musi być dodatnia\r\n");

                }
                if (Balance - amount < 0)
                {
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                }
                var withdrawal = new Transaction(-amount, date, note);
                _allTransactions.Add(withdrawal);
            }

            public void ShowBankacount()
            {
                Console.WriteLine("Numer konta :" + Number);
                Console.WriteLine("Dane Właściciela: " + Owner);
                Console.WriteLine("Bilans: " + Balance);
            }
        }
        public class Transaction
        {
            public double Amount { get; }
            public DateTime Date { get; }
            public string Notes { get; }


            public Transaction(double amount, DateTime date, string note)
            {
                Amount = amount;
                Date = date;
                Notes = note;

            }

        }
        static void Main(string[] args)
        {
            var acount = new BankAcount("12458936472", "Maria Oleksinska", 1254);
            acount.ShowBankacount();

            var account = new BankAcount("Grzegorz Karolewski", 2000000);
            account.ShowBankacount();
            var account2 = new BankAcount("Jan Kowalski", 100000);
            account2.ShowBankacount();
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            var transaction = new Transaction(2000, DateTime.Now, "wpłata");

        }
    }
}