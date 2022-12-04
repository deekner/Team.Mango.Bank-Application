﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Menu 
    {

        public static void MenuOptions(List<User> Users, User CurrentUser)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("             MAIN MENU             ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|    [1.]  Accounts                  | ");
                Console.WriteLine("|    [2.]  Transfer                  | ");
                Console.WriteLine("|    [3.]  Withdraw                  | ");
                Console.WriteLine("|    [4.]  Logout                    | ");
                Console.WriteLine("|    [5.]  Exit application          | ");
                Console.WriteLine("--------------------------------------");


                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CurrentUser.ShowAccountInfo(CurrentUser);
                            break;

                        case 2:
                            Transfer.transfer();
                            break;

                        case 3:
                            Withdraw.withdraw();
                            break;

                        case 4:
                            Login logout = new Login();
                            logout.UserLogin(Users);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.ReadLine();
                }
            } while (true);
        }
    }
}

        
    
      
