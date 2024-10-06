namespace H34111122_practice_3_2;

public enum Option { penguin, pork, shrimp, none }


public partial class Form1 : Form
{
    public Option current;
    public int index;
    public string currentUser = "";
    internal static List<Order> orders = new List<Order>();
    internal static Dictionary<string, string> accounts = new Dictionary<string, string>();

    public Form1()
    {
        InitializeComponent();
        index = 1000;
        accounts["admin"] = "admin";
        page_open();
    }

    private void page_open()
    {
        // open
        message.Text = "歡迎來到角落生物商店";
        panel_open.Visible = true;

        // login
        panel_login.Visible = false;

        // menu
        panel_menu.Visible = false;

        // order
        panel_order.Visible = false;

        button_cancel.Visible = false;
    }

    private void page_login()
    {
        // open
        panel_open.Visible = false;

        // login
        panel_login.Visible = true;
        button_login.Visible = true;
        button_add_account.Visible = false;
        textBox_account.Text = "";
        textBox_password.Text = "";

        // menu
        panel_menu.Visible = false;

        // order
        panel_order.Visible = false;

        button_cancel.Visible = false;
    }

    private void page_new_account()
    {
        // open
        panel_open.Visible = false;

        // login
        panel_login.Visible = true;
        button_add_account.Visible = true;
        button_login.Visible = false;
        textBox_account.Text = "";
        textBox_password.Text = "";

        // menu
        panel_menu.Visible = false;

        // order
        panel_order.Visible = false;

        button_cancel.Visible = true;
        button_cancel.BringToFront();
    }

    private void page_menu()
    {
        // open
        panel_open.Visible = false;

        // login
        panel_login.Visible = false;

        // menu
        panel_menu.Visible = true;

        // order
        panel_order.Visible = false;

        button_cancel.Visible = false;
    }

    private void page_order()
    {
        // open
        panel_open.Visible = false;

        // login
        panel_login.Visible = false;

        // menu
        panel_menu.Visible = false;

        // order
        panel_order.Visible = true;
        textBox_amount.Text = "";
        button_penguin.Text = "企鵝";
        button_pork.Text = "炸豬排";
        button_shrimp.Text = "炸蝦";

        button_cancel.Visible = true;
        button_cancel.BringToFront();
    }

    private void button_open_Click(object sender, EventArgs e)
    {
        message.Text = "歡迎光臨!請登入";
        page_login();
    }

    private void button_login_Click(object sender, EventArgs e)
    {
        if (accounts.ContainsKey(textBox_account.Text) && accounts[textBox_account.Text] == textBox_password.Text)
        {
            currentUser = textBox_account.Text;
            message.Text = "歡迎登入，" + currentUser;
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
        current = Option.none;
    }

    private void button_penguin_Click(object sender, EventArgs e)
    {
        button_penguin.Text = "企鵝(已選擇)";
        button_pork.Text = "炸豬排";
        button_shrimp.Text = "炸蝦";
        current = Option.penguin;
    }

    private void button_pork_Click(object sender, EventArgs e)
    {
        button_penguin.Text = "企鵝";
        button_pork.Text = "炸豬排(已選擇)";
        button_shrimp.Text = "炸蝦";
        current = Option.pork;
    }

    private void button_shrimp_Click(object sender, EventArgs e)
    {
        button_penguin.Text = "企鵝";
        button_pork.Text = "炸豬排";
        button_shrimp.Text = "炸蝦(已選擇)";
        current = Option.shrimp;
    }

    private void button_submit_Click(object sender, EventArgs e)
    {
        int amount = 0;
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
            case Option.none:
                message.Text = "請選擇商品";
                return;
        }
        try
        {
            amount = int.Parse(textBox_amount.Text);
            if (amount <= 0)
            {
                throw new Exception();
            }
        }
        catch (Exception)
        {
            message.Text = "商品數量必須是正整數";
            textBox_amount.Text = "";
            return;
        }
        Order temp = new Order(index, amount, option, currentUser);
        orders.Add(temp);
        message.Text = "新增訂單成功，訂單編號 " + index.ToString();
        index++;
        page_menu();

    }

    private void button_list_Click(object sender, EventArgs e)
    {
        foreach (var item in orders)
        {
            string text = "訂單編號: " + item.index + " 購買了 " + item.amount + " 個 " + item.option + ", 此訂單由 " + item.user + " 新增";
            listBox.Items.Add(text);
        }
        if (listBox.Items.Count != 0)
        {
            listBox.Items.Add("\n");
        }
    }

    private void button_new_account_Click(object sender, EventArgs e)
    {
        message.Text = "請輸入要新增的使用者帳號與密碼";
        page_new_account();
    }

    private void button_logout_Click(object sender, EventArgs e)
    {
        message.Text = "歡迎光臨!請登入";
        page_login();
    }

    private void button_add_account_Click(object sender, EventArgs e)
    {
        if (accounts.ContainsKey(textBox_account.Text))
        {
            message.Text = "此使用者已存在";
            return;
        }
        else
        {
            accounts[textBox_account.Text] = textBox_password.Text;
            currentUser = textBox_account.Text;
            message.Text = "歡迎登入，" + currentUser;
            page_menu();
        }
    }

    private void button_cancel_Click(object sender, EventArgs e)
    {
        message.Text = "歡迎登入，" + currentUser;
        page_menu();
    }

    private void button_clear_Click(object sender, EventArgs e)
    {
        listBox.Items.Clear();
    }

    private void button_exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
