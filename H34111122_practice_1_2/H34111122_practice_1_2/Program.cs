using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NiCKU ATM\n");
            int account = 0;
            ATM atm = new ATM();

            while (true) //create personal account
            {
                Console.WriteLine("Enter your account");
                try
                {
                    account = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }
                if (account < 10000 || account > 99999)
                {
                    Console.WriteLine("Account should be 5 digits");
                }
                else if (atm.exist(account))
                {
                    Console.WriteLine("Account exists");
                }
                else
                {
                    break;
                }
            }
            Account myAccount = new Account(account);

            int option = -1;
            while (true) //account operation
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("\t(0) check");
                Console.WriteLine("\t(1) withdraw");
                Console.WriteLine("\t(2) deposit");
                Console.WriteLine("\t(3) transfer");
                Console.WriteLine("\t(4) donate");
                Console.WriteLine("\t(5) history");
                Console.WriteLine("\t(8) exit");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }
                switch (option)
                {
                    case 0: //check
                        myAccount.check();
                        break;
                    case 1: //withdraw
                        myAccount.withdraw();
                        break;
                    case 2: //deposit
                        myAccount.deposit();
                        break;
                    case 3: //transfer
                        myAccount.transfer(atm);
                        break;
                    case 4: //donate
                        myAccount.donate();
                        break;
                    case 5: //history
                        myAccount.history();
                        break;
                    case 8: //exit
                        return;
                    case 65304:
                        atm.print();
                        Console.WriteLine("\tAccount: {0} - {1}", account, myAccount.balance);
                        break;
                    default:
                        Console.WriteLine("There's no option");
                        break;
                }
            }
        }
    }
}
