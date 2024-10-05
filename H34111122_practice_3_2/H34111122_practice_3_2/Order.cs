using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_3_2
{
    internal class Order
    {
        public int index, amount;
        public string option;

        public Order(int number, int amount, string option)
        {
            index = number;
            this.amount = amount;
            this.option = option;
        }
    }
}
