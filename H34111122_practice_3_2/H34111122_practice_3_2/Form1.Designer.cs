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
        label_account.Visible = false;
        // 
        // label_password
        // 
        label_password.AutoSize = true;
        label_password.Location = new Point(273, 360);
        label_password.Name = "label_password";
        label_password.Size = new Size(39, 19);
        label_password.TabIndex = 3;
        label_password.Text = "密碼";
        label_password.Visible = false;
        // 
        // textBox_account
        // 
        textBox_account.Location = new Point(342, 193);
        textBox_account.Margin = new Padding(3, 4, 3, 4);
        textBox_account.Name = "textBox_account";
        textBox_account.Size = new Size(223, 27);
        textBox_account.TabIndex = 4;
        textBox_account.Visible = false;
        // 
        // textBox_password
        // 
        textBox_password.Location = new Point(342, 356);
        textBox_password.Margin = new Padding(3, 4, 3, 4);
        textBox_password.Name = "textBox_password";
        textBox_password.Size = new Size(223, 27);
        textBox_password.TabIndex = 5;
        textBox_password.Visible = false;
        // 
        // button_login
        // 
        button_login.Location = new Point(616, 263);
        button_login.Margin = new Padding(3, 4, 3, 4);
        button_login.Name = "button_login";
        button_login.Size = new Size(84, 29);
        button_login.TabIndex = 6;
        button_login.Text = "登入";
        button_login.UseVisualStyleBackColor = true;
        button_login.Visible = false;
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
        button_add.Visible = false;
        button_add.Click += button_add_Click;
        // 
        // button_list
        // 
        button_list.Location = new Point(57, 263);
        button_list.Margin = new Padding(3, 4, 3, 4);
        button_list.Name = "button_list";
        button_list.Size = new Size(84, 29);
        button_list.TabIndex = 8;
        button_list.Text = "列出所有訂單";
        button_list.UseVisualStyleBackColor = true;
        button_list.Visible = false;
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
        listBox.Visible = false;
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
        button_penguin.Visible = false;
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
        button_pork.Visible = false;
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
        button_shrimp.Visible = false;
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
        button_submit.Visible = false;
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
        label_amount.Visible = false;
        // 
        // textBox_amount
        // 
        textBox_amount.Location = new Point(386, 241);
        textBox_amount.Margin = new Padding(3, 4, 3, 4);
        textBox_amount.Name = "textBox_amount";
        textBox_amount.Size = new Size(223, 27);
        textBox_amount.TabIndex = 15;
        textBox_amount.Visible = false;
        // 
        // button_new_account
        // 
        button_new_account.Location = new Point(57, 339);
        button_new_account.Name = "button_new_account";
        button_new_account.Size = new Size(84, 29);
        button_new_account.TabIndex = 16;
        button_new_account.Text = "新增帳號";
        button_new_account.UseVisualStyleBackColor = true;
        button_new_account.Visible = false;
        button_new_account.Click += button_new_account_Click;
        // 
        // button_logout
        // 
        button_logout.Location = new Point(57, 407);
        button_logout.Name = "button_logout";
        button_logout.Size = new Size(84, 29);
        button_logout.TabIndex = 17;
        button_logout.Text = "登出";
        button_logout.UseVisualStyleBackColor = true;
        button_logout.Visible = false;
        button_logout.Click += button_logout_Click;
        // 
        // button_add_account
        // 
        button_add_account.Location = new Point(616, 263);
        button_add_account.Name = "button_add_account";
        button_add_account.Size = new Size(84, 29);
        button_add_account.TabIndex = 18;
        button_add_account.Text = "新增帳號";
        button_add_account.UseVisualStyleBackColor = true;
        button_add_account.Visible = false;
        button_add_account.Click += button_add_account_Click;
        // 
        // button_cancel
        // 
        button_cancel.Location = new Point(616, 427);
        button_cancel.Name = "button_cancel";
        button_cancel.Size = new Size(84, 29);
        button_cancel.TabIndex = 19;
        button_cancel.Text = "取消";
        button_cancel.UseVisualStyleBackColor = true;
        button_cancel.Visible = false;
        button_cancel.Click += button_cancel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 570);
        Controls.Add(button_cancel);
        Controls.Add(button_add_account);
        Controls.Add(button_logout);
        Controls.Add(button_new_account);
        Controls.Add(textBox_amount);
        Controls.Add(label_amount);
        Controls.Add(button_submit);
        Controls.Add(button_shrimp);
        Controls.Add(button_pork);
        Controls.Add(button_penguin);
        Controls.Add(button_list);
        Controls.Add(button_add);
        Controls.Add(button_login);
        Controls.Add(textBox_password);
        Controls.Add(textBox_account);
        Controls.Add(label_password);
        Controls.Add(label_account);
        Controls.Add(button_open);
        Controls.Add(message);
        Controls.Add(listBox);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox message;
    private System.Windows.Forms.Button button_open;
    private System.Windows.Forms.Label label_account;
    private System.Windows.Forms.Label label_password;
    private System.Windows.Forms.TextBox textBox_account;
    private System.Windows.Forms.TextBox textBox_password;
    private System.Windows.Forms.Button button_login;
    private System.Windows.Forms.Button button_add;
    private System.Windows.Forms.Button button_list;
    private System.Windows.Forms.ListBox listBox;
    private System.Windows.Forms.Button button_penguin;
    private System.Windows.Forms.Button button_pork;
    private System.Windows.Forms.Button button_shrimp;
    private System.Windows.Forms.Button button_submit;
    private System.Windows.Forms.Label label_amount;
    private System.Windows.Forms.TextBox textBox_amount;
    private Button button_new_account;
    private Button button_logout;
    private Button button_add_account;
    private Button button_cancel;
}
