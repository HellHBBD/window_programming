using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_2_1
{
    internal class Goods
    {
        public string name;
        public int price;
        public int amount;
        public int sold;
        public int index;

        public Goods()
        {
            name = null;
            price = 0;
            amount = 0;
            sold = 0;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public void setAmount(int amount)
        {
            this.amount = amount;
        }

        public void setSold(int sold)
        {
            this.sold = sold;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }

        public string getName()
        {
            return name;
        }

        public int getPrice()
        {
            return price;
        }

        public int getAmount()
        {
            return amount;
        }

        public int getSold()
        {
            return sold;
        }

        public int getIndex()
        {
            return index;
        }
    }
}
