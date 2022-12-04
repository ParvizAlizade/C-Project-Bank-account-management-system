using Bank_account_management_system.Entities;
using Bank_account_management_system.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Services
{
    class UserService
    {
        readonly IUserRepository _userrepository;
        public UserService()
        {
            _userrepository = new UserRepository();
        }

        public bool UserRegistration(string name, string surname, string email, string password, bool isadmin)
        {
            foreach (User user1 in _userrepository.Bank.users)
            {
                if (user1.Email==email)
                {
                    Console.WriteLine("This email had been registered");
                    return false;
                }
            }
            User user = new User(name, surname, email, password, isadmin);
            _userrepository.UserRegistration(user);
            return true;
        }
        
        public bool UserLogin(string email, string password)
        {
            foreach (User user in _userrepository.Bank.users)
            {
                if (user.Email.Equals(email) && user.Password.Equals(password))
                {
                    _userrepository.UserLogin(user);
                    return true;
                }
            }
            Console.WriteLine("Error!");

            Console.Clear();
            return false;
          
        }

        public bool? FindUser(string email)
        {
            foreach (User user in _userrepository.Bank.users)
            {
                if (user.Email==email)
                {
                    _userrepository.FindUser(user);
                    return true;
                }
            }
            return false;
        }
     
    }
}
