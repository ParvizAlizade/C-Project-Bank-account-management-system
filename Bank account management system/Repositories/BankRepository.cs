using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
    class BankRepository : IBankRepository
    {
        private Bank _bank;
        
        public Bank Bank { get => _bank; }

        public void BankUserList()
        {
        foreach (User userr in _bank.users)
        {
            Console.WriteLine(userr);
        }
        }

        public bool BlockUser(User user)
        {
            throw new NotImplementedException();
        }

        public string ChangePassword(User user, string newpassword)
        {
            user.Password = newpassword;
            return user.Password;
        }

        public void CheckBalance(User user)
        {
            Console.WriteLine(user.Balance);
        }

        public bool LogOut()
        {
            throw new NotImplementedException();
        }

        public void TopUpBalance(User user, double includedbalance)
        {
            user.Balance += includedbalance;
        }
    }
}
