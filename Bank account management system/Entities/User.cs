using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account_management_system.Entities
{
    class User
    {
        public static int Id { get; set; }
        private string _name;
        public string Name 
        {
           get =>_name;
             set
             {
               if (value.Length>3)
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
          get=>_email;
          set
          {
                if (value.Contains('@')==true)
                {
                    Email = value;
                }
                
          }
        }
        private string _password;
        public string Password 
        {
            get => _password;
            set {
                int haslower = 0;
                int hasupper = 0;
                int hasdigit = 0;

                if (Password.Length>8)
                {
                    foreach (char item in Password)
                    {
                        if (char.IsLower(item))
                        {
                            haslower++;
                        }
                        else if (char.IsUpper(item))
                        {
                            hasupper++;
                        }
                        else if (char.IsDigit(item))
                        {
                            hasdigit++;
                        }
                        else if (hasdigit > 0 && haslower > 0 && hasupper > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Duzgun daxil edin:");
                            break;
                        }
                    }
                    Password = value;
                }

            } }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsLogged { get; set; }
        static int _count=0 ;
        public User(string name, string surname, int balance, string email, string password, bool isadmin, bool isblocked=false, bool islogged=false)
        {
            Name = name;
            SurName = surname;
            Email = email;
            Id = ++_count;
            Password = password;
            IsAdmin = isadmin;
            IsBlocked = isblocked;
            IsLogged = islogged;
        }

        public User(string name, string surname, string email, string password,bool isadmin)
        {
            Name = name;
            SurName = surname;
            Email = email;
            Password = password;
            IsAdmin = isadmin;
        }
    }
}
