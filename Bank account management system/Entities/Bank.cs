using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Entities
{
    class Bank
    {
            public int Id;
            public User[] users = new User[0];
            static int count = 0;

            public Bank()
            {
                Id = ++count;
            }
            static Bank()
            {
                count = 0;
            }

        }
    }
