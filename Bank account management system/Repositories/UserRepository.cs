using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bank_account_management_system.Repositories
{
    class UserRepository : IUserRepository
    {
        private Bank _bank;
        public Bank Bank { get; set; }

        public void UserRegistration(User user)
        {
            Array.Resize(ref _bank.users, _bank.users.Length + 1);
            _bank.users[_bank.users.Length - 1] = user;
            Console.WriteLine("Your Registration is done Succesfully:)");
        }
        public void UserLogin(User user)
        {
            user.IsLogged = true;
            Console.WriteLine("Login Ready \n");
            Thread.Sleep(1000);
            Console.WriteLine("Loading........");
            Thread.Sleep(2000);
            Console.WriteLine(user.Name+" "+user.SurName);
        }
        public void FindUser(User user)
        {
            Console.WriteLine(user.Name+" "+user.SurName);
        }
    }
}
