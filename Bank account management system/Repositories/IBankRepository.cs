using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
    interface IBankRepository
    {

        public Bank  Bank { get; }
        public void CheckBalance(User user);
        public void TopUpBalance(User user,double newbalance);
        public string ChangePassword(User user,string newpassword);
        public void BankUserList();
        public bool BlockUser(User user);
        public bool LogOut();
    }

}
