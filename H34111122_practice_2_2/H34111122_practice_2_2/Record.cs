using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_2_2
{
    internal class Record
    {
        Hashtable customers;

        public Record()
        {
            customers = new Hashtable();
        }

        public void add(string name, int cost)
        {
            Customer temp;
            if (customers.ContainsKey(name))
            {
                temp = (Customer)customers[name];
                temp.add(cost);
            }
            else
            {
                temp = new Customer(name, cost);
                customers.Add(name, temp);
            }
            temp.print();
        }
    }
}
