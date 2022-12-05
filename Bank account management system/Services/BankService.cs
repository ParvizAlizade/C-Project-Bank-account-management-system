using Bank_account_management_system.Entities;
using Bank_account_management_system.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Services
{
    class BankService
    {
        readonly IBankRepository _repository;
        Bank bank;
        public BankService(Bank bank)
        {
            this.bank = bank;
            _repository = new BankRepository(this.bank);
        }

        public BankService()
        {
        }

        public bool ChangePassword(string currentpas, string newPass)
        {
            foreach (User item in bank.users)
            {
                if (item.Password == currentpas)
                {
                    _repository.ChangePassword(item, newPass);
                    return true;
                }
            }
            return false;
        }
        public bool CheckBalance(string password)
        {

            foreach (User item in bank.users)
            {
                if (item.Password == password)
                {
                    _repository.CheckBalance(item);
                    return true;
                }
            }
            return false;
        }
        public bool TopUpBalance(string password, double newBal)
        {
            foreach (User item in bank.users)
            {
                if (item.Password == password)
                {
                    _repository.ToUpBalance(item, newBal);
                    return true;
                }
            }
            return false;
        }

        public bool BankUserList(string email)
        {
            User exicted;
            foreach (User item in bank.users)
            {
                if (item.Email == email)
                {
                    if (item.IsAdmin == true)
                    {
                        exicted = item;
                        _repository.BankUserList();
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public void LogOut(User user)
        {
            _repository.LogOut(user);
        }

        public bool BlockUser(string email)
        {
            User exicted;
            foreach (User item in bank.users)
            {
                if (item.Email == email)
                {
                    exicted = item;
                    _repository.BlockUser(exicted);
                    Console.WriteLine($"Blocked: {item.Name}");
                    return true;
                }
            }
            return false;
        }
    }
}