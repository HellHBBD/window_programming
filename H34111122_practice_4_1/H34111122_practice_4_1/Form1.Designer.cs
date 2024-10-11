namespace H34111122_practice_4_1;

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
        richTextBox_left = new RichTextBox();
        button_send = new Button();
        textBox_chat = new TextBox();
        tabControl = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        richTextBox_right = new RichTextBox();
        panel1.SuspendLayout();
        tabControl.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(richTextBox_left);
        panel1.Controls.Add(button_send);
        panel1.Controls.Add(textBox_chat);
        panel1.Controls.Add(tabControl);
        panel1.Controls.Add(richTextBox_right);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 450);
        panel1.TabIndex = 0;
        panel1.DoubleClick += panel1_DoubleClick;
        // 
        // richTextBox_left
        // 
        richTextBox_left.Location = new Point(60, 50);
        richTextBox_left.Name = "richTextBox_left";
        richTextBox_left.Size = new Size(692, 332);
        richTextBox_left.TabIndex = 5;
        richTextBox_left.Text = "";
        // 
        // button_send
        // 
        button_send.Enabled = false;
        button_send.Location = new Point(655, 403);
        button_send.Name = "button_send";
        button_send.Size = new Size(94, 29);
        button_send.TabIndex = 2;
        button_send.Text = "傳送";
        button_send.UseVisualStyleBackColor = true;
        button_send.Click += button_send_Click;
        // 
        // textBox_chat
        // 
        textBox_chat.Enabled = false;
        textBox_chat.Location = new Point(60, 403);
        textBox_chat.Name = "textBox_chat";
        textBox_chat.Size = new Size(565, 27);
        textBox_chat.TabIndex = 1;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPage1);
        tabControl.Controls.Add(tabPage2);
        tabControl.Location = new Point(55, 22);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(700, 362);
        tabControl.TabIndex = 0;
        tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        // 
        // tabPage1
        // 
        tabPage1.Location = new Point(4, 28);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(692, 330);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "斗哥";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 28);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(692, 330);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "楷特";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // richTextBox_right
        // 
        richTextBox_right.Location = new Point(60, 50);
        richTextBox_right.Name = "richTextBox_right";
        richTextBox_right.Size = new Size(692, 332);
        richTextBox_right.TabIndex = 6;
        richTextBox_right.Text = "";
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
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button_send;
    private TextBox textBox_chat;
    public TabControl tabControl;
    public TabPage tabPage1;
    public TabPage tabPage2;
    private RichTextBox richTextBox_left;
    private RichTextBox richTextBox_right;
}
