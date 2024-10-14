namespace H34111122_practice_4_2;

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
        panel1 = new Panel();
        button_send = new Button();
        textBox_chat = new TextBox();
        tabControl = new TabControl();
        tabPage_dog = new TabPage();
        richTextBox_dog = new RichTextBox();
        tabPage_cat = new TabPage();
        richTextBox_cat = new RichTextBox();
        button_emoji = new Button();
        panel1.SuspendLayout();
        tabControl.SuspendLayout();
        tabPage_dog.SuspendLayout();
        tabPage_cat.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(button_emoji);
        panel1.Controls.Add(button_send);
        panel1.Controls.Add(textBox_chat);
        panel1.Controls.Add(tabControl);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 450);
        panel1.TabIndex = 0;
        panel1.DoubleClick += panel1_DoubleClick;
        // 
        // button_send
        // 
        button_send.Location = new Point(657, 401);
        button_send.Name = "button_send";
        button_send.Size = new Size(94, 29);
        button_send.TabIndex = 2;
        button_send.Text = "傳送";
        button_send.UseVisualStyleBackColor = true;
        button_send.Click += button_send_Click;
        // 
        // textBox_chat
        // 
        textBox_chat.Location = new Point(60, 403);
        textBox_chat.Name = "textBox_chat";
        textBox_chat.Size = new Size(550, 27);
        textBox_chat.TabIndex = 1;
        textBox_chat.KeyDown += textBox_chat_KeyDown;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPage_dog);
        tabControl.Controls.Add(tabPage_cat);
        tabControl.Location = new Point(55, 22);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(700, 362);
        tabControl.TabIndex = 0;
        tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        // 
        // tabPage_dog
        // 
        tabPage_dog.Controls.Add(richTextBox_dog);
        tabPage_dog.Location = new Point(4, 28);
        tabPage_dog.Name = "tabPage_dog";
        tabPage_dog.Padding = new Padding(3);
        tabPage_dog.Size = new Size(692, 330);
        tabPage_dog.TabIndex = 0;
        tabPage_dog.Text = "斗哥";
        tabPage_dog.UseVisualStyleBackColor = true;
        // 
        // richTextBox_dog
        // 
        richTextBox_dog.Location = new Point(-4, 0);
        richTextBox_dog.Name = "richTextBox_dog";
        richTextBox_dog.Size = new Size(700, 334);
        richTextBox_dog.TabIndex = 5;
        richTextBox_dog.Text = "";
        // 
        // tabPage_cat
        // 
        tabPage_cat.Controls.Add(richTextBox_cat);
        tabPage_cat.Location = new Point(4, 28);
        tabPage_cat.Name = "tabPage_cat";
        tabPage_cat.Padding = new Padding(3);
        tabPage_cat.Size = new Size(692, 330);
        tabPage_cat.TabIndex = 1;
        tabPage_cat.Text = "楷特";
        tabPage_cat.UseVisualStyleBackColor = true;
        // 
        // richTextBox_cat
        // 
        richTextBox_cat.Location = new Point(-4, 0);
        richTextBox_cat.Name = "richTextBox_cat";
        richTextBox_cat.Size = new Size(700, 334);
        richTextBox_cat.TabIndex = 6;
        richTextBox_cat.Text = "";
        // 
        // button_emoji
        // 
        button_emoji.Location = new Point(615, 401);
        button_emoji.Name = "button_emoji";
        button_emoji.Size = new Size(36, 29);
        button_emoji.TabIndex = 3;
        button_emoji.UseVisualStyleBackColor = true;
        button_emoji.Click += button_emoji_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "聊天室";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        tabControl.ResumeLayout(false);
        tabPage_dog.ResumeLayout(false);
        tabPage_cat.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button_send;
    private TextBox textBox_chat;
    public TabControl tabControl;
    public TabPage tabPage_dog;
    public TabPage tabPage_cat;
    private RichTextBox richTextBox_dog;
    private RichTextBox richTextBox_cat;
    private Button button_emoji;
}
