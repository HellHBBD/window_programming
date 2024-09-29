using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_1_2
{
    internal class ATM
    {
        Hashtable list;

        public ATM()
        {
            list = new Hashtable();
            for (int i = 10000; i < 20000; i += 1000)
            {
                list.Add(i, new Account(i));
            }
        }

        public void add(int account)
        {
            list.Add(account, new Account(account));
        }

        public bool exist(int key)
        {
            return list.ContainsKey(key);
        }

        public void print()
        {
            Console.WriteLine("Welcome to backend system");
            Console.WriteLine("Below are the existing accounts and their balances");
            foreach (var key in list.Keys)
            {
                Account temp = (Account)list[key];
                Console.WriteLine("\tAccount: {0} - {1}", key, temp.balance);
            }
        }

        public Account getAccount(int account)
        {
            return (Account)list[account];
        }
    }
}
