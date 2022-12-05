using Bank_account_management_system.Services;
using System;
using System.Threading;

namespace Bank_account_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            char UserServiceSelect;
            do
            {
                Console.WriteLine("1. Registration");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Find User");
                Console.WriteLine("0. Exit");
            selection:
                UserServiceSelect = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine();
                switch (UserServiceSelect)
                {
                    case '1':
                        MenuService.Registration();
                        Console.Clear();
                        break;
                    case '2':
                        MenuService.Login();
                        Console.Clear();
                        break;
                    case '3':
                        MenuService.FindUser();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (UserServiceSelect != '0');

            char BankServiceSelect;
            do
            {
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Top up balance");
                Console.WriteLine("3. Change password");
                Console.WriteLine("4. Bank user list");
                Console.WriteLine("5. Block user");
                Console.WriteLine("6. Logout");
            selection1:
                BankServiceSelect = Console.ReadKey().KeyChar;
                Console.Clear();
                Console.WriteLine();
                switch (BankServiceSelect)
                {
                    case '1':
                        MenuService.CheckBalans();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case '2':
                        MenuService.TopUpBalance();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case '3':
                        MenuService.ChangePassword();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case '4':
                        MenuService.UserList();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case '5':
                        MenuService.BlockUser();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case '6':
                        MenuService.Logout();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto selection1;
                }
            } while (BankServiceSelect != '0');
        }
    }
}

