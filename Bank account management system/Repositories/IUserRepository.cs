using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
    interface IUserRepository
    {
        public Bank Bank { get; }
        public void UserRegistration(User user);
        public void UserLogin(User user);

        public void FindUser(User user);
    }
}
