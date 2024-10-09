namespace H34111122_practice_3_2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        message = new TextBox();
        button_open = new Button();
        label_account = new Label();
        label_password = new Label();
        textBox_account = new TextBox();
        textBox_password = new TextBox();
        button_login = new Button();
        button_add = new Button();
        button_list = new Button();
        listBox = new ListBox();
        button_penguin = new Button();
        button_pork = new Button();
        button_shrimp = new Button();
        button_submit = new Button();
        label_amount = new Label();
        textBox_amount = new TextBox();
        button_new_account = new Button();
        button_logout = new Button();
        button_add_account = new Button();
        button_cancel = new Button();
        button_clear = new Button();
        panel_open = new Panel();
        panel_login = new Panel();
        button_exit = new Button();
        panel_menu = new Panel();
        panel_order = new Panel();
        panel_open.SuspendLayout();
        panel_login.SuspendLayout();
        panel_menu.SuspendLayout();
        panel_order.SuspendLayout();
        SuspendLayout();
        // 
        // message
        // 
        message.Enabled = false;
        message.Location = new Point(206, 57);
        message.Margin = new Padding(3, 4, 3, 4);
        message.Name = "message";
        message.Size = new Size(496, 27);
        message.TabIndex = 0;
        message.Text = "歡迎來到角落生物商店";
        message.TextAlign = HorizontalAlignment.Center;
        // 
        // button_open
        // 
        button_open.Location = new Point(413, 265);
        button_open.Margin = new Padding(3, 4, 3, 4);
        button_open.Name = "button_open";
        button_open.Size = new Size(84, 29);
        button_open.TabIndex = 1;
        button_open.Text = "開店";
        button_open.UseVisualStyleBackColor = true;
        button_open.Click += button_open_Click;
        // 
        // label_account
        // 
        label_account.AutoSize = true;
        label_account.Location = new Point(273, 196);
        label_account.Name = "label_account";
        label_account.Size = new Size(39, 19);
        label_account.TabIndex = 2;
        label_account.Text = "帳號";
        // 
        // label_password
        // 
        label_password.AutoSize = true;
        label_password.Location = new Point(273, 360);
        label_password.Name = "label_password";
        label_password.Size = new Size(39, 19);
        label_password.TabIndex = 3;
        label_password.Text = "密碼";
        // 
        // textBox_account
        // 
        textBox_account.Location = new Point(342, 193);
        textBox_account.Margin = new Padding(3, 4, 3, 4);
        textBox_account.Name = "textBox_account";
        textBox_account.Size = new Size(223, 27);
        textBox_account.TabIndex = 4;
        // 
        // textBox_password
        // 
        textBox_password.Location = new Point(342, 356);
        textBox_password.Margin = new Padding(3, 4, 3, 4);
        textBox_password.Name = "textBox_password";
        textBox_password.Size = new Size(223, 27);
        textBox_password.TabIndex = 5;
        // 
        // button_login
        // 
        button_login.Location = new Point(618, 263);
        button_login.Margin = new Padding(3, 4, 3, 4);
        button_login.Name = "button_login";
        button_login.Size = new Size(84, 29);
        button_login.TabIndex = 6;
        button_login.Text = "登入";
        button_login.UseVisualStyleBackColor = true;
        button_login.Click += button_login_Click;
        // 
        // button_add
        // 
        button_add.Location = new Point(57, 191);
        button_add.Margin = new Padding(3, 4, 3, 4);
        button_add.Name = "button_add";
        button_add.Size = new Size(84, 29);
        button_add.TabIndex = 7;
        button_add.Text = "新增訂單";
        button_add.UseVisualStyleBackColor = true;
        button_add.Click += button_add_Click;
        // 
        // button_list
        // 
        button_list.Location = new Point(57, 244);
        button_list.Margin = new Padding(3, 4, 3, 4);
        button_list.Name = "button_list";
        button_list.Size = new Size(84, 29);
        button_list.TabIndex = 8;
        button_list.Text = "列出訂單";
        button_list.UseVisualStyleBackColor = true;
        button_list.Click += button_list_Click;
        // 
        // listBox
        // 
        listBox.FormattingEnabled = true;
        listBox.ItemHeight = 19;
        listBox.Location = new Point(206, 158);
        listBox.Margin = new Padding(3, 4, 3, 4);
        listBox.Name = "listBox";
        listBox.Size = new Size(496, 308);
        listBox.TabIndex = 9;
        // 
        // button_penguin
        // 
        button_penguin.Location = new Point(246, 314);
        button_penguin.Margin = new Padding(3, 4, 3, 4);
        button_penguin.Name = "button_penguin";
        button_penguin.Size = new Size(125, 29);
        button_penguin.TabIndex = 10;
        button_penguin.Text = "企鵝";
        button_penguin.UseVisualStyleBackColor = true;
        button_penguin.Click += button_penguin_Click;
        // 
        // button_pork
        // 
        button_pork.Location = new Point(404, 314);
        button_pork.Margin = new Padding(3, 4, 3, 4);
        button_pork.Name = "button_pork";
        button_pork.Size = new Size(125, 29);
        button_pork.TabIndex = 11;
        button_pork.Text = "炸豬排";
        button_pork.UseVisualStyleBackColor = true;
        button_pork.Click += button_pork_Click;
        // 
        // button_shrimp
        // 
        button_shrimp.Location = new Point(566, 314);
        button_shrimp.Margin = new Padding(3, 4, 3, 4);
        button_shrimp.Name = "button_shrimp";
        button_shrimp.Size = new Size(125, 29);
        button_shrimp.TabIndex = 12;
        button_shrimp.Text = "炸蝦";
        button_shrimp.UseVisualStyleBackColor = true;
        button_shrimp.Click += button_shrimp_Click;
        // 
        // button_submit
        // 
        button_submit.Location = new Point(413, 427);
        button_submit.Margin = new Padding(3, 4, 3, 4);
        button_submit.Name = "button_submit";
        button_submit.Size = new Size(84, 29);
        button_submit.TabIndex = 13;
        button_submit.Text = "送出訂單";
        button_submit.UseVisualStyleBackColor = true;
        button_submit.Click += button_submit_Click;
        // 
        // label_amount
        // 
        label_amount.AutoSize = true;
        label_amount.Location = new Point(287, 244);
        label_amount.Name = "label_amount";
        label_amount.Size = new Size(84, 19);
        label_amount.TabIndex = 14;
        label_amount.Text = "請輸入數量";
        // 
        // textBox_amount
        // 
        textBox_amount.Location = new Point(386, 241);
        textBox_amount.Margin = new Padding(3, 4, 3, 4);
        textBox_amount.Name = "textBox_amount";
        textBox_amount.Size = new Size(223, 27);
        textBox_amount.TabIndex = 15;
        // 
        // button_new_account
        // 
        button_new_account.Location = new Point(57, 360);
        button_new_account.Name = "button_new_account";
        button_new_account.Size = new Size(84, 29);
        button_new_account.TabIndex = 16;
        button_new_account.Text = "新增帳號";
        button_new_account.UseVisualStyleBackColor = true;
        button_new_account.Click += button_new_account_Click;
        // 
        // button_logout
        // 
        button_logout.Location = new Point(57, 427);
        button_logout.Name = "button_logout";
        button_logout.Size = new Size(84, 29);
        button_logout.TabIndex = 17;
        button_logout.Text = "登出";
        button_logout.UseVisualStyleBackColor = true;
        button_logout.Click += button_logout_Click;
        // 
        // button_add_account
        // 
        button_add_account.Location = new Point(616, 263);
        button_add_account.Name = "button_add_account";
        button_add_account.Size = new Size(86, 29);
        button_add_account.TabIndex = 18;
        button_add_account.Text = "新增帳號";
        button_add_account.UseVisualStyleBackColor = true;
        button_add_account.Click += button_add_account_Click;
        // 
        // button_cancel
        // 
        button_cancel.Location = new Point(616, 427);
        button_cancel.Name = "button_cancel";
        button_cancel.Size = new Size(86, 29);
        button_cancel.TabIndex = 19;
        button_cancel.Text = "取消";
        button_cancel.UseVisualStyleBackColor = true;
        button_cancel.Click += button_cancel_Click;
        // 
        // button_clear
        // 
        button_clear.Location = new Point(57, 302);
        button_clear.Name = "button_clear";
        button_clear.Size = new Size(84, 29);
        button_clear.TabIndex = 20;
        button_clear.Text = "清空列表";
        button_clear.UseVisualStyleBackColor = true;
        button_clear.Click += button_clear_Click;
        // 
        // panel_open
        // 
        panel_open.Controls.Add(button_open);
        panel_open.Location = new Point(0, 0);
        panel_open.Name = "panel_open";
        panel_open.Size = new Size(900, 570);
        panel_open.TabIndex = 20;
        // 
        // panel_login
        // 
        panel_login.Controls.Add(button_add_account);
        panel_login.Controls.Add(button_login);
        panel_login.Controls.Add(textBox_password);
        panel_login.Controls.Add(textBox_account);
        panel_login.Controls.Add(label_password);
        panel_login.Controls.Add(label_account);
        panel_login.Controls.Add(button_exit);
        panel_login.Location = new Point(0, 0);
        panel_login.Name = "panel_login";
        panel_login.Size = new Size(900, 570);
        panel_login.TabIndex = 21;
        // 
        // button_exit
        // 
        button_exit.Location = new Point(616, 427);
        button_exit.Name = "button_exit";
        button_exit.Size = new Size(86, 29);
        button_exit.TabIndex = 19;
        button_exit.Text = "退出程式";
        button_exit.UseVisualStyleBackColor = true;
        button_exit.Click += button_exit_Click;
        // 
        // panel_menu
        // 
        panel_menu.Controls.Add(button_add);
        panel_menu.Controls.Add(button_list);
        panel_menu.Controls.Add(button_clear);
        panel_menu.Controls.Add(button_new_account);
        panel_menu.Controls.Add(button_logout);
        panel_menu.Controls.Add(listBox);
        panel_menu.Location = new Point(0, 0);
        panel_menu.Name = "panel_menu";
        panel_menu.Size = new Size(900, 570);
        panel_menu.TabIndex = 22;
        // 
        // panel_order
        // 
        panel_order.Controls.Add(label_amount);
        panel_order.Controls.Add(textBox_amount);
        panel_order.Controls.Add(button_shrimp);
        panel_order.Controls.Add(button_pork);
        panel_order.Controls.Add(button_penguin);
        panel_order.Controls.Add(button_submit);
        panel_order.Location = new Point(0, 0);
        panel_order.Name = "panel_order";
        panel_order.Size = new Size(900, 570);
        panel_order.TabIndex = 23;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 570);
        Controls.Add(message);
        Controls.Add(button_cancel);
        Controls.Add(panel_login);
        Controls.Add(panel_menu);
        Controls.Add(panel_order);
        Controls.Add(panel_open);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Form1";
        panel_open.ResumeLayout(false);
        panel_login.ResumeLayout(false);
        panel_login.PerformLayout();
        panel_menu.ResumeLayout(false);
        panel_order.ResumeLayout(false);
        panel_order.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox message;
    private Button button_open;
    private Label label_account;
    private Label label_password;
    private TextBox textBox_account;
    private TextBox textBox_password;
    private Button button_login;
    private Button button_add;
    private Button button_list;
    private ListBox listBox;
    private Button button_penguin;
    private Button button_pork;
    private Button button_shrimp;
    private Button button_submit;
    private Label label_amount;
    private TextBox textBox_amount;
    private Button button_new_account;
    private Button button_logout;
    private Button button_add_account;
    private Button button_cancel;
    private Button button_clear;
    private Panel panel_open;
    private Panel panel_order;
    private Panel panel_menu;
    private Panel panel_login;
    private Button button_exit;
}
