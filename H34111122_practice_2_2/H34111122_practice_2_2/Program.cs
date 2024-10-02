using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace H34111122_practice_2_2
{
    internal class Program
    {
        static Goods[] list;
        static Record record;
        static int count, income;
        static bool state;
        static string msg;

        static int ReadInt()
        {
            int result = 0;
            while (true)
            {
                Console.Write(msg);
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("請輸入正整數\n");
                    continue;
                }
                if (result <= 0)
                {
                    Console.WriteLine("請輸入正整數\n");
                    continue;
                }
                return result;
            }
        }

        static int ReadIntWithCancel()
        {
            int result = 0;
            while (true)
            {
                Console.Write(msg);
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("請輸入正整數或-1來取消\n");
                    continue;
                }
                if (result == -1)
                    return result;
                if (result <= 0)
                {
                    Console.WriteLine("請輸入正整數或-1來取消\n");
                    continue;
                }
                return result;
            }
        }

        static string[] ReadArray(int count)
        {
            string[] line;
            while (true)
            {
                Console.Write(msg);
                line = Console.ReadLine().Split(' ');
                if (line.Length == count)
                {
                    return line;
                }
                else
                {
                    Console.WriteLine("輸入數量有誤\n");
                }
            }
        }

        static int[] ReadArrayWithCancel(int count)
        {
            int[] array = new int[count];
            while (true)
            {
                Console.Write(msg);
                string line = Console.ReadLine();
                if (line.Equals("-1"))
                {
                    array[0] = -1;
                    return array;
                }
                string[] temp = line.Split(' ');
                if (temp.Length != count)
                {
                    Console.WriteLine("請輸入正確數量的正整數或-1來取消\n");
                    continue;
                }
                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        array[i] = int.Parse(temp[i]);
                        if (array[i] <= 0)
                        {
                            throw new Exception();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("請輸入正確數量的正整數或-1來取消\n");
                    continue;
                }
                return array;
            }
        }

        static string ReadName()
        {
            while (true)
            {
                Console.Write(msg);
                string name = Console.ReadLine();
                if (Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("名字只能有英文字母和空格\n");
                }
            }
        }

        static void open()
        {
            state = true;
            msg = "請輸入今日總共有幾種商品要販售: ";
            count = ReadInt();
            list = new Goods[count];
            record = new Record();

            msg = "請依序輸入每一種商品的名稱: ";
            string[] line = ReadArray(count);
            for (int i = 0; i < count; i++)
            {
                list[i] = new Goods();
                list[i].setIndex(i);
                list[i].setName(line[i]);
            }

            msg = "接下來，請你依序輸入每一個商品的價格: ";
            int[] array = ReadArrayWithCancel(count);
            if (array[0] == -1)
            {
                Console.WriteLine("\n開店取消\n");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                list[i].setPrice(array[i]);
            }

            Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
            foreach (var item in list)
            {
                Console.WriteLine("{0}: {1}", item.getName(), item.getPrice());
            }

            msg = "\n最後，請你依序輸入每一個商品目前的庫存數量: ";
            array = ReadArrayWithCancel(count);
            if (array[0] == -1)
            {
                Console.WriteLine("\n開店取消\n");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                list[i].setAmount(array[i]);
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
            if (!state)
            {
                Console.WriteLine("尚未開店，請先開店\n");
                return;
            }

            msg = "請依序輸入此訂單每一種類的商品各需要買幾個: ";
            int[] array = ReadArrayWithCancel(count);
            if (array[0] == -1)
            {
                Console.WriteLine("\n訂單取消\n");
                return;
            }
            int[] neededAmount = new int[count];
            int totalPrice = 0;
            for (int i = 0; i < count; i++)
            {
                neededAmount[i] = array[i];
                int amount = list[i].getAmount();
                if (amount < neededAmount[i])
                {
                    Console.WriteLine("\n庫存不足，此筆訂單不成立\n");
                    return;
                }
                int price = list[i].getPrice();
                totalPrice += (neededAmount[i] * price);
            }

            if (totalPrice >= 1000)
            {
                Console.Write("\n訂單成立!，總金額為: {0} ", totalPrice);
                Random random = new Random();
                int discount = random.Next(1, 9);
                totalPrice = (int)(totalPrice * discount * 0.1);
                Console.Write("因訂單滿 1000 元，因此總金額打 {0} 折，打折後為 {1} ", discount, totalPrice);
            }
            else
            {
                Console.Write("\n訂單成立!，總金額為: {0} ", totalPrice);
            }
            msg = "請輸入消費者付款金額: ";
            int pay = ReadIntWithCancel();
            while (totalPrice > pay)
            {
                msg = "\n付款金額不足，請再輸入一次 (或輸入 -1 直接取消此筆訂單): ";
                pay = ReadIntWithCancel();
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

            msg = "請輸入消費者名字: ";
            string name = ReadName();
            record.add(name, totalPrice);
        }

        static void getInventory()
        {
            if (!state)
            {
                Console.WriteLine("尚未開店，請先開店\n");
                return;
            }

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
            if (!state)
            {
                Console.WriteLine("尚未開店，請先開店\n");
                return;
            }

            Console.WriteLine("總收入為: {0}", income);
        }

        static void calculateRank()
        {
            if (!state)
            {
                Console.WriteLine("尚未開店，請先開店\n");
                return;
            }

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
                msg = "歡迎來到 NCKU 卡比商店交易系統\n======================================\n(1) 開店\n(2) 新增訂單\n(3) 查詢庫存\n(4) 查詢總收入\n(5) 計算人氣商品排名\n(6) 關店\n======================================\n請輸入您現在想要進行的操作: ";
                int option = ReadInt();
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
                    default:
                        Console.WriteLine("無效輸入，請重新輸入\n");
                        break;
                }
            }



        }
    }
}
