using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H34111122_practice_3_1
{
    public enum Option { penguin, pork, shrimp }
    public partial class Form1 : Form
    {
        public static Option current;
        public static int index;
        internal static List<Order> orders;

        public Form1()
        {
            InitializeComponent();
            orders = new List<Order>();
            index = 1000;
        }

        private void page_open()
        {
            // open
            message.Text = "歡迎來到角落生物商店";
            button_open.Visible = true;

            // login
            label_account.Visible = false;
            label_password.Visible = false;
            textBox_account.Visible = false;
            textBox_password.Visible = false;
            button_login.Visible = false;

            // menu
            button_add.Visible = false;
            button_list.Visible = false;
            listBox.Visible = false;

            // order
            label_amount.Visible = false;
            textBox_amount.Visible = false;
            button_penguin.Visible = false;
            button_pork.Visible = false;
            button_shrimp.Visible = false;
            button_submit.Visible = false;
        }

        private void page_login()
        {
            // open
            button_open.Visible = false;

            // login
            label_account.Visible = true;
            label_password.Visible = true;
            textBox_account.Visible = true;
            textBox_password.Visible = true;
            button_login.Visible = true;

            // menu
            button_add.Visible = false;
            button_list.Visible = false;
            listBox.Visible = false;

            // order
            label_amount.Visible = false;
            textBox_amount.Visible = false;
            button_penguin.Visible = false;
            button_pork.Visible = false;
            button_shrimp.Visible = false;
            button_submit.Visible = false;
        }

        private void page_menu()
        {
            // open
            button_open.Visible = false;

            // login
            label_account.Visible = false;
            label_password.Visible = false;
            textBox_account.Visible = false;
            textBox_password.Visible = false;
            button_login.Visible = false;

            // menu
            button_add.Visible = true;
            button_list.Visible = true;
            listBox.Visible = true;

            // order
            label_amount.Visible = false;
            textBox_amount.Visible = false;
            button_penguin.Visible = false;
            button_pork.Visible = false;
            button_shrimp.Visible = false;
            button_submit.Visible = false;
        }

        private void page_order()
        {
            // open
            button_open.Visible = false;

            // login
            label_account.Visible = false;
            label_password.Visible = false;
            textBox_account.Visible = false;
            textBox_password.Visible = false;
            button_login.Visible = false;

            // menu
            button_add.Visible = false;
            button_list.Visible = false;
            listBox.Visible = false;

            // order
            label_amount.Visible = true;
            textBox_amount.Visible = true;
            button_penguin.Visible = true;
            button_pork.Visible = true;
            button_shrimp.Visible = true;
            button_submit.Visible = true;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            message.Text = "歡迎光臨!請登入";
            page_login();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_account.Text == "admin" && textBox_password.Text == "admin")
            {
                message.Text = "歡迎登入，admin";
                page_menu();
            }
            else
            {
                message.Text = "帳號密碼錯誤";
                textBox_account.Text = "";
                textBox_password.Text = "";
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            message.Text = "輸入完數量後，點選對應商品按鈕，並按送出";
            page_order();
        }

        private void button_penguin_Click(object sender, EventArgs e)
        {
            current = Option.penguin;
        }

        private void button_chicken_Click(object sender, EventArgs e)
        {
            current = Option.pork;
        }

        private void button_shrimp_Click(object sender, EventArgs e)
        {
            current = Option.shrimp;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBox_amount.Text);
            textBox_amount.Text = "";
            string option = "";
            switch (current)
            {
                case Option.penguin:
                    option = "企鵝";
                    break;
                case Option.pork:
                    option = "炸豬排";
                    break;
                case Option.shrimp:
                    option = "炸蝦";
                    break;
            }
            Order temp = new Order(index, amount, option);
            orders.Add(temp);
            message.Text = "新增訂單成功，訂單編號 " + index.ToString();
            index++;
            page_menu();

        }

        private void button_list_Click(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                string text = "訂單編號: " + item.index + " 購買了 " + item.amount + " 個 " + item.option;
                listBox.Items.Add(text);
            }
        }
    }
}
