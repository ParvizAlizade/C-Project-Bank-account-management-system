using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Entities
{
    class User
    {

        public static int Id { get; set; }
        protected string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 3)
                {
                    _name = value;
                }
            }
        }
        private string _surName;
        public string SurName
        {
            get => _surName;
            set
            {
                if (value.Length > 3)
                {
                    _surName = value;
                }
            }
        }

        public double Balance { get; set; }
        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (EmailChecker(value))
                {
                    _email = value;
                }
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }

            }
        }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsLogged { get; set; }
        static int _count = 0;
        public User(string name, string surname, string email, string password, bool isadmin)
        {
            Name = name;
            SurName = surname;
            Email = email;
            Id = ++_count;
            Password = password;
            IsAdmin = false;
            IsBlocked = false;
            IsLogged = false;
        }


        public static bool CheckPassword(string pw)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool result = false;

            foreach (char item in pw)
            {


                if (char.IsDigit(item))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(item))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(item))
                {
                    hasUpper = true;
                }
                result = hasDigit && hasLower && hasUpper;
                if (result)
                {
                    break;
                }

            }
            return result;
        }

        public static bool EmailChecker(string symbol)
        {
            if (symbol.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
