using Bank_account_management_system.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Services
{
    class UserService
    {
        readonly IUserRepository _repository;
        public UserService()
        {
            _repository = new UserRepository();
        }



    }
}
