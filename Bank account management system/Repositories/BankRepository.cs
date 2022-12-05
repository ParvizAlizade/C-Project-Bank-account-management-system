using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
    internal class BankRepository : IBankRepository
    {
        Bank _bank;
        public Bank bank
        {get
            {
                return _bank;
            }
        }
        public BankRepository(Bank bank)
        {
            _bank = bank;
        }
        public void BankUserList()
        {
            foreach (User user in _bank.users)
            {
                Console.WriteLine(user.Name, user.SurName);
            }
        }
        public bool BlockUser(User user)
        {
            return user.IsBlocked = true;
        }

        public string ChangePassword(User user, string newPassword)
        {
            user.Password = newPassword;
            return user.Password;
        }

        public void CheckBalance(User user)
        {
            Console.WriteLine(user.Balance);
        }

        public void ToUpBalance(User user, double amount)
        {
            user.Balance += amount;
            Console.WriteLine($"New Balance: {user.Balance}");
        }

        public bool LogOut(User user)
        {
            return user.IsLogged = false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
