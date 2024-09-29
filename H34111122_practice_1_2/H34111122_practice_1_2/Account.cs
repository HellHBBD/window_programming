using System;
using System.Collections.Generic;

namespace H34111122_practice_1_2
{
    internal class Account
    {
        public int number;
        public int balance;
        public int point;
        public List<List<int>> list;

        public Account(int account)
        {
            balance = 10000;
            number = account;
            list = new List<List<int>>();
        }

        public void check()
        {
            Console.WriteLine("balance: {0}", balance);
        }

        public void withdraw()
        {
            Console.Write("Enter amount: ");
            int amount = 0;
            try
            {
                amount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Amount should be an integer");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Exceed the existing amount");
                return;
            }
            balance -= amount;
            Console.WriteLine("Successfully withdraw");
            check();
            List<int> temp = new List<int>();
            temp.Add(1);
            temp.Add(balance);
            list.Add(temp);
        }

        public void deposit()
        {
            Console.Write("Enter amount: ");
            int amount = 0;
            try
            {
                amount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Amount should be an integer");
                return;
            }
            if (amount < 0 || amount > 100000)
            {
                Console.WriteLine("Exceed the valid amount 0~100000");
                return;
            }
            balance += amount;
            check();
            List<int> temp = new List<int>();
            temp.Add(2);
            temp.Add(balance);
            list.Add(temp);
        }

        public void deposit(int amount)
        {
            if (amount < 0 || amount > 100000)
            {
                Console.WriteLine("Exceed the valid amount 0~100000");
                return;
            }
            balance += amount;
            check();
            List<int> temp = new List<int>();
            temp.Add(2);
            temp.Add(balance);
            list.Add(temp);
        }

        public void transfer(ATM atm)
        {
            Console.Write("Enter transfer account: ");
            int account = 0;
            try
            {
                account = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Account should be an integer");
                return;
            }
            if (account == number)
            {
                Console.WriteLine("You can't transfer to yourself");
                return;
            }
            else if (!atm.exist(account))
            {
                Console.WriteLine("This is not a exist account, press 1 if you want to open one and keep going");
                if (int.Parse(Console.ReadLine()) != 1)
                {
                    return;
                }
                else
                {
                    atm.add(account);
                }
            }
            Account targetAccount = atm.getAccount(account);

            Console.Write("Enter amount: ");
            int amount = 0;
            try
            {
                amount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Amount should be an integer");
                return;
            }
            if (amount < 0 || amount > 100000)
            {
                Console.WriteLine("Exceed the valid amount 0~100000");
                return;
            }

            int cost = 0;
            if (point != 0)
            {
                Console.WriteLine("You have {0} points, press 1 to use 1 point to save handing fee?", point);
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    cost = amount;
                    Console.WriteLine("Final cost (+0%) = {0}", cost);
                }
                else
                {
                    cost = (int)(amount * 1.1);
                    Console.WriteLine("Final cost (+10%) = {0}", cost);
                }
            }
            else
            {
                cost = (int)(amount * 1.1);
                Console.WriteLine("Final cost (+10%) = {0}", cost);
            }

            if (cost > balance)
            {
                Console.WriteLine("Exceed the existing amount");
                return;
            }
            balance -= cost;
            /*targetAccount.balance += amount;*/
            targetAccount.deposit(amount);
            Console.WriteLine("Successfully transfer");
            check();
            List<int> temp = new List<int>();
            temp.Add(3);
            temp.Add(balance);
            list.Add(temp);
        }

        public void donate()
        {
            Console.Write("Enter amount: ");
            int amount = 0;
            try
            {
                amount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Amount should be an integer");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Exceed the existing amount");
                return;
            }
            balance -= amount;
            point += (amount / 1000);
            Console.WriteLine("Successfully withdraw");
            check();
            List<int> temp = new List<int>();
            temp.Add(4);
            temp.Add(balance);
            list.Add(temp);
        }

        public void history()
        {
            Console.WriteLine("transaction history");
            foreach (var record in list)
            {
                Console.WriteLine("\t{0} - {1}", record[0], record[1]);
            }
        }
    }
}
