﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class Bankaccount : Menu
    {

        public static void bankaccount(Users Currentuser)
        {
            Console.Clear();
            Console.WriteLine("Which of your following bank account balance would you like to select?\n");
            Console.WriteLine("[1]. Accounts Balance\n[2]. Saving Balance\n");
            Console.WriteLine("[3]. Return to Main Menu");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your current balance is: {0}\n", Currentuser.balance().ToString("C"));
                    Console.WriteLine("Press [Enter] to return");
                    Console.ReadLine();
                    bankaccount(Currentuser);
                    break;

                case 2:
                    Console.WriteLine("Your current savings balance is: {0}\n", Currentuser.Savings());
                    Console.WriteLine("Press [Enter] to return");
                    Console.ReadLine();
                    bankaccount(Currentuser);
                    break;

                default:
                    Console.WriteLine("Press [Enter] to return to Main Menu...");
                    break;
            }

            Console.Clear();
        }


    }
}
