using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Entities
{
    class Bank
    {
        public int Id;
        public User[] users;
        static int _count=0;

        public Bank(User[] users)
        {
            users = new User[0];
            Id = ++_count; 
        }

        public Bank()
        {

        }
    }
}
