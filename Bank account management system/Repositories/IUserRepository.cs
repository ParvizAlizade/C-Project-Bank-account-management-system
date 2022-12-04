using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
    interface IUserRepository
    {
        public void UserRegistration(string name,string surname,string email,string password,bool isadmin);
        public bool UserLogin(string email,string password);

        public bool FindUser(User[] user,string email);
    }
}
