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
            public Bank bank
            {
                get
                {
                    return _bank;
                }
            }
        public Bank Bank => throw new NotImplementedException();

         public UserRepository(Bank bank)
            {
                _bank = bank;
            }
            public void UserRegistration(User user)
            {
                Array.Resize(ref _bank.users, _bank.users.Length + 1);

                _bank.users[_bank.users.Length - 1] = user;

                Console.WriteLine("You have Logined");
                Thread.Sleep(2000);
            }
            public void UserLogin(User user)
            {
                user.IsLogged = true;
                Console.WriteLine($"User:{user.Name} {user.SurName}");
                Thread.Sleep(2000);
            }
            public void FindUser(User user)
            {
                Console.WriteLine($"User: {user.Name} {user.SurName}");
                Thread.Sleep(2000);
            }
        }
    }

