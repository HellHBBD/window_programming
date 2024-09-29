using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_2_1
{
    internal class Program
    {
        static Goods[] list;
        static int count, income;

        static void open()
        {
            Console.Write("請輸入今日總共有幾種商品要販售: ");
            count = int.Parse(Console.ReadLine());
            list = new Goods[count];

            Console.Write("請依序輸入每一種商品的名稱: ");
            string[] line = Console.ReadLine().Split(' ');
            for (int i = 0; i < count; i++)
            {
                list[i] = new Goods();
                list[i].setIndex(i);
                list[i].setName(line[i]);
            }

            Console.Write("接下來，請你依序輸入每一個商品的價格: ");
            line = Console.ReadLine().Split(' ');
            for (int i = 0; i < count; i++)
            {
                list[i].setPrice(int.Parse(line[i]));
            }

            Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
            foreach (var item in list)
            {
                Console.WriteLine("{0}: {1}", item.getName(), item.getPrice());
            }

            Console.Write("\n最後，請你依序輸入每一個商品目前的庫存數量: ");
            line = Console.ReadLine().Split(' ');
            for (int i = 0; i < count; i++)
            {
                list[i].setAmount(int.Parse(line[i]));
            }

            Console.Write("\n輸入完成! 每一種商品的庫存數量依序為: \n");
            foreach (var item in list)
            {
                Console.WriteLine("{0}: {1}", item.getName(), item.getAmount());
            }

            Console.WriteLine("\n開店程序完成，已開店\n");
        }

        static void add()
        {
            Console.Write("請依序輸入此訂單每一種類的商品各需要買幾個: ");
            string[] line = Console.ReadLine().Split(' ');
            int[] neededAmount = new int[count];
            int totalPrice = 0;
            for (int i = 0; i < count; i++)
            {
                neededAmount[i] = int.Parse(line[i]);
                int amount = list[i].getAmount();
                if (amount < neededAmount[i])
                {
                    Console.WriteLine("\n庫存不足，此筆訂單不成立\n");
                    return;
                }
                int price = list[i].getPrice();
                totalPrice += (neededAmount[i] * price);
            }
            Console.Write("\n訂單成立!，總金額為: {0} ", totalPrice);
            Console.Write("請輸入消費者付款金額: ");
            int pay = int.Parse(Console.ReadLine());
            while (totalPrice > pay)
            {
                Console.Write("\n付款金額不足，請再輸入一次 (或輸入 -1 直接取消此筆訂單): ");
                pay = int.Parse(Console.ReadLine());
                if (pay == -1)
                {
                    Console.WriteLine("\n訂單取消\n");
                    return;
                }
            }
            Console.WriteLine("\n 付款完成! 請找零消費者共 {0} 元", pay - totalPrice);
            income += totalPrice;
            for (int i = 0; i < count; i++)
            {
                list[i].setAmount(list[i].getAmount() - neededAmount[i]);
                list[i].setSold(list[i].getSold() + neededAmount[i]);
            }
        }

        static void getInventory()
        {
            bool enough = true;
            foreach (var item in list)
            {
                int amount = item.getAmount();
                Console.WriteLine("{0}: {1}", item.getName(), amount);
                if (amount <= 5)
                {
                    enough = false;
                }
            }
            if (!enough)
            {
                Console.WriteLine(" 有商品的庫存數量不足！！！");
            }
        }

        static void getIncome()
        {
            Console.WriteLine("總收入為: {0}", income);
        }

        static void calculateRank()
        {
            Array.Sort(list, compare);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("第 {0} 名: {1}, 總購買數量共 {2} 次", i + 1, list[i].getName(), list[i].getSold());
            }
        }

        static int compare(Goods a, Goods b)
        {
            int time = b.getSold().CompareTo(a.getSold());
            if (time == 0)
            {
                return a.getIndex().CompareTo(b.getIndex());
            }
            return time;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("歡迎來到 NCKU 卡比商店交易系統");
                Console.WriteLine("======================================");
                Console.WriteLine("(1) 開店");
                Console.WriteLine("(2) 新增訂單");
                Console.WriteLine("(3) 查詢庫存");
                Console.WriteLine("(4) 查詢總收入");
                Console.WriteLine("(5) 計算人氣商品排名");
                Console.WriteLine("(6) 關店");
                Console.WriteLine("======================================");
                Console.Write("請輸入您現在想要進行的操作: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        open();
                        break;
                    case 2:
                        add();
                        break;
                    case 3:
                        getInventory();
                        break;
                    case 4:
                        getIncome();
                        break;
                    case 5:
                        calculateRank();
                        break;
                    case 6:
                        return;
                }
            }


        }
    }
}
