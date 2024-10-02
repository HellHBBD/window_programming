using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_2_2
{
    internal class Customer
    {
        string name;
        int[] record;
        int max;

        public Customer(string name, int cost)
        {
            this.name = name;
            record = new int[3];
            record[1] = record[2] = 0;
            record[0] = max = cost;
        }

        public void add(int cost)
        {
            record[2] = record[1];
            record[1] = record[0];
            record[0] = cost;
            if (cost > max)
            {
                max = cost;
            }
        }

        public void print()
        {
            Console.WriteLine("消費者 {0} 歷史資訊:\n", name);
            Console.WriteLine("此消費者歷史訂單中，最大金額為: {0} 元", max);
            Console.WriteLine("近期交易 1: {0}", record[0]);
            Console.WriteLine("近期交易 2: {0}", record[1]);
            Console.WriteLine("近期交易 3: {0}", record[2]);
        }
    }
}
