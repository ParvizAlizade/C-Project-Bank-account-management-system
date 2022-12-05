using Bank_account_management_system.Entities;
using Bank_account_management_system.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bank_account_management_system.Services
{
    class UserService
    {
        readonly IUserRepository _repository;
        Bank bank;
        public UserService(Bank bank)
        {
            this.bank = new Bank();
            _repository = new UserRepository(this.bank);
        }

        public bool UserRegistration(string name, string surname, string email, string password, bool isAdmin)
        {
            foreach (User user1 in bank.users)
            {
                if (user1.Email == email)
                {
                    Console.WriteLine("This email had been registered");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuService.Registration();
                    return false;
                }
            }
            User user = new User(name, surname, email, password, isAdmin);
            _repository.UserRegistration(user);
            return true;

        }

        public bool UserLogin(string email, string password)
        {
            foreach (User item in bank.users)
            {
                if (item.Email == email && item.Password == password)
                {
                    _repository.UserLogin(item);

                    
                    return true;
                }
            }
            MenuService.AllServicess();
            Console.WriteLine("Incorrect");
            Thread.Sleep(2000);
            return false;
        }


        public bool FindUser(string email)
        {
            User exicted = default;
            foreach (User gmail in bank.users)
            {
                if (gmail.Email == email)
                {
                    exicted = gmail;
                    _repository.FindUser(exicted);
                    return false;
                }
            }
            if (exicted == null)
            {
                Console.WriteLine("--This email is not registered--");
                return false;
            }
            Console.WriteLine("Not Found");
            _repository.FindUser(exicted);
            return false;
        }
    }
}
