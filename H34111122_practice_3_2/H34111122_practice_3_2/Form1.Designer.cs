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
        this.message = new System.Windows.Forms.TextBox();
        this.button_open = new System.Windows.Forms.Button();
        this.label_account = new System.Windows.Forms.Label();
        this.label_password = new System.Windows.Forms.Label();
        this.textBox_account = new System.Windows.Forms.TextBox();
        this.textBox_password = new System.Windows.Forms.TextBox();
        this.button_login = new System.Windows.Forms.Button();
        this.button_add = new System.Windows.Forms.Button();
        this.button_list = new System.Windows.Forms.Button();
        this.listBox = new System.Windows.Forms.ListBox();
        this.button_penguin = new System.Windows.Forms.Button();
        this.button_pork = new System.Windows.Forms.Button();
        this.button_shrimp = new System.Windows.Forms.Button();
        this.button_submit = new System.Windows.Forms.Button();
        this.label_amount = new System.Windows.Forms.Label();
        this.textBox_amount = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // message
        // 
        this.message.Enabled = false;
        this.message.Location = new System.Drawing.Point(183, 45);
        this.message.Name = "message";
        this.message.Size = new System.Drawing.Size(441, 25);
        this.message.TabIndex = 0;
        this.message.Text = "歡迎來到角落生物商店";
        this.message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // button_open
        // 
        this.button_open.Location = new System.Drawing.Point(367, 209);
        this.button_open.Name = "button_open";
        this.button_open.Size = new System.Drawing.Size(75, 23);
        this.button_open.TabIndex = 1;
        this.button_open.Text = "開店";
        this.button_open.UseVisualStyleBackColor = true;
        this.button_open.Click += new System.EventHandler(this.button_open_Click);
        // 
        // label_account
        // 
        this.label_account.AutoSize = true;
        this.label_account.Location = new System.Drawing.Point(243, 155);
        this.label_account.Name = "label_account";
        this.label_account.Size = new System.Drawing.Size(37, 15);
        this.label_account.TabIndex = 2;
        this.label_account.Text = "帳號";
        this.label_account.Visible = false;
        // 
        // label_password
        // 
        this.label_password.AutoSize = true;
        this.label_password.Location = new System.Drawing.Point(243, 284);
        this.label_password.Name = "label_password";
        this.label_password.Size = new System.Drawing.Size(37, 15);
        this.label_password.TabIndex = 3;
        this.label_password.Text = "密碼";
        this.label_password.Visible = false;
        // 
        // textBox_account
        // 
        this.textBox_account.Location = new System.Drawing.Point(304, 152);
        this.textBox_account.Name = "textBox_account";
        this.textBox_account.Size = new System.Drawing.Size(199, 25);
        this.textBox_account.TabIndex = 4;
        this.textBox_account.Visible = false;
        // 
        // textBox_password
        // 
        this.textBox_password.Location = new System.Drawing.Point(304, 281);
        this.textBox_password.Name = "textBox_password";
        this.textBox_password.Size = new System.Drawing.Size(199, 25);
        this.textBox_password.TabIndex = 5;
        this.textBox_password.Visible = false;
        // 
        // button_login
        // 
        this.button_login.Location = new System.Drawing.Point(548, 208);
        this.button_login.Name = "button_login";
        this.button_login.Size = new System.Drawing.Size(75, 23);
        this.button_login.TabIndex = 6;
        this.button_login.Text = "登入";
        this.button_login.UseVisualStyleBackColor = true;
        this.button_login.Visible = false;
        this.button_login.Click += new System.EventHandler(this.button_login_Click);
        // 
        // button_add
        // 
        this.button_add.Location = new System.Drawing.Point(51, 151);
        this.button_add.Name = "button_add";
        this.button_add.Size = new System.Drawing.Size(75, 23);
        this.button_add.TabIndex = 7;
        this.button_add.Text = "新增訂單";
        this.button_add.UseVisualStyleBackColor = true;
        this.button_add.Visible = false;
        this.button_add.Click += new System.EventHandler(this.button_add_Click);
        // 
        // button_list
        // 
        this.button_list.Location = new System.Drawing.Point(51, 208);
        this.button_list.Name = "button_list";
        this.button_list.Size = new System.Drawing.Size(75, 23);
        this.button_list.TabIndex = 8;
        this.button_list.Text = "列出所有訂單";
        this.button_list.UseVisualStyleBackColor = true;
        this.button_list.Visible = false;
        this.button_list.Click += new System.EventHandler(this.button_list_Click);
        // 
        // listBox
        // 
        this.listBox.FormattingEnabled = true;
        this.listBox.ItemHeight = 15;
        this.listBox.Location = new System.Drawing.Point(183, 125);
        this.listBox.Name = "listBox";
        this.listBox.Size = new System.Drawing.Size(441, 244);
        this.listBox.TabIndex = 9;
        this.listBox.Visible = false;
        // 
        // button_penguin
        // 
        this.button_penguin.Location = new System.Drawing.Point(236, 248);
        this.button_penguin.Name = "button_penguin";
        this.button_penguin.Size = new System.Drawing.Size(75, 23);
        this.button_penguin.TabIndex = 10;
        this.button_penguin.Text = "企鵝";
        this.button_penguin.UseVisualStyleBackColor = true;
        this.button_penguin.Visible = false;
        this.button_penguin.Click += new System.EventHandler(this.button_penguin_Click);
        // 
        // button_pork
        // 
        this.button_pork.Location = new System.Drawing.Point(367, 248);
        this.button_pork.Name = "button_pork";
        this.button_pork.Size = new System.Drawing.Size(75, 23);
        this.button_pork.TabIndex = 11;
        this.button_pork.Text = "炸豬排";
        this.button_pork.UseVisualStyleBackColor = true;
        this.button_pork.Visible = false;
        this.button_pork.Click += new System.EventHandler(this.button_chicken_Click);
        // 
        // button_shrimp
        // 
        this.button_shrimp.Location = new System.Drawing.Point(492, 248);
        this.button_shrimp.Name = "button_shrimp";
        this.button_shrimp.Size = new System.Drawing.Size(75, 23);
        this.button_shrimp.TabIndex = 12;
        this.button_shrimp.Text = "炸蝦";
        this.button_shrimp.UseVisualStyleBackColor = true;
        this.button_shrimp.Visible = false;
        this.button_shrimp.Click += new System.EventHandler(this.button_shrimp_Click);
        // 
        // button_submit
        // 
        this.button_submit.Location = new System.Drawing.Point(367, 337);
        this.button_submit.Name = "button_submit";
        this.button_submit.Size = new System.Drawing.Size(75, 23);
        this.button_submit.TabIndex = 13;
        this.button_submit.Text = "送出訂單";
        this.button_submit.UseVisualStyleBackColor = true;
        this.button_submit.Visible = false;
        this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
        // 
        // label_amount
        // 
        this.label_amount.AutoSize = true;
        this.label_amount.Location = new System.Drawing.Point(255, 193);
        this.label_amount.Name = "label_amount";
        this.label_amount.Size = new System.Drawing.Size(82, 15);
        this.label_amount.TabIndex = 14;
        this.label_amount.Text = "請輸入數量";
        this.label_amount.Visible = false;
        // 
        // textBox_amount
        // 
        this.textBox_amount.Location = new System.Drawing.Point(343, 190);
        this.textBox_amount.Name = "textBox_amount";
        this.textBox_amount.Size = new System.Drawing.Size(199, 25);
        this.textBox_amount.TabIndex = 15;
        this.textBox_amount.Visible = false;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.textBox_amount);
        this.Controls.Add(this.label_amount);
        this.Controls.Add(this.button_submit);
        this.Controls.Add(this.button_shrimp);
        this.Controls.Add(this.button_pork);
        this.Controls.Add(this.button_penguin);
        this.Controls.Add(this.button_list);
        this.Controls.Add(this.button_add);
        this.Controls.Add(this.button_login);
        this.Controls.Add(this.textBox_password);
        this.Controls.Add(this.textBox_account);
        this.Controls.Add(this.label_password);
        this.Controls.Add(this.label_account);
        this.Controls.Add(this.button_open);
        this.Controls.Add(this.message);
        this.Controls.Add(this.listBox);
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);
        this.PerformLayout();

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
}
