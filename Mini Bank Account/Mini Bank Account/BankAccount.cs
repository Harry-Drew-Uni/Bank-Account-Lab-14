using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Bank_Account
{
    class BankAccount
    {
        public string AccountName { get; private set; }
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        //Declaring bank account
        public BankAccount(string _customerName, int _accountNumber, decimal _balance) 
        {
            AccountName = _customerName;
            AccountNumber = _accountNumber;
            Balance = _balance;
        }

        //Initializing bank account with no balance
        public BankAccount(string _customerName, int _accountNumber) : this(_customerName, _accountNumber, 0) { }

        public void AddFunds(decimal _amount) 
        {
            Balance += _amount;
        }

        public void WithdrawFunds(decimal _amount) 
        {
            Balance -= _amount;
        }
    
    }
}
