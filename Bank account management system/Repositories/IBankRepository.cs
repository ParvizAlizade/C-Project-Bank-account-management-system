using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
        interface IBankRepository
        {
        void BankUserList();
        bool BlockUser(User user);
        string ChangePassword(User user, string newPassword);
        void CheckBalance(User user);
        void ToUpBalance(User user, double amount);
        bool LogOut(User user);
    }

}
