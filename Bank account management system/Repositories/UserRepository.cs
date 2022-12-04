using Bank_account_management_system.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Repositories
{
    class UserRepository : IUserRepository
    {
        private Bank _bank;
        public Bank  Banks { get => _bank; }
        public UserRepository()
        {
            _bank = new Bank();
        }

        public void UserRegistration(string name, string surname, string email, string password, bool isadmin)
        {
            User user = new User(name,surname,email,password,isadmin);
            Array.Resize(ref _bank.users, _bank.users.Length + 1);
            _bank.users[_bank.users.Length - 1] = user;
             
        }
        public bool UserLogin(string email, string password)
        {
            foreach (User user1 in _bank.users)
            {
                if (user1.Email == email && user1.Password == password)
                {
                    user1.IsLogged = true;
                    return user1.IsLogged;
                }
            }
            return false;
        }
        public bool FindUser(User[] user, string email)
        {
            foreach (User user1 in _bank.users)
            {
                if (user1.Email == email)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        
    }
}
