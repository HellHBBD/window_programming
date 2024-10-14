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
        button_send = new Button();
        textBox_chat = new TextBox();
        tabControl = new TabControl();
        tabPage_dou = new TabPage();
        richTextBox_dou = new RichTextBox();
        tabPage_kai = new TabPage();
        richTextBox_kai = new RichTextBox();
        panel1.SuspendLayout();
        tabControl.SuspendLayout();
        tabPage_dou.SuspendLayout();
        tabPage_kai.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
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
        button_send.Enabled = false;
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
        textBox_chat.Enabled = false;
        textBox_chat.Location = new Point(60, 403);
        textBox_chat.Name = "textBox_chat";
        textBox_chat.Size = new Size(565, 27);
        textBox_chat.TabIndex = 1;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPage_dou);
        tabControl.Controls.Add(tabPage_kai);
        tabControl.Location = new Point(55, 22);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(700, 362);
        tabControl.TabIndex = 0;
        tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        // 
        // tabPage_dou
        // 
        tabPage_dou.Controls.Add(richTextBox_dou);
        tabPage_dou.Location = new Point(4, 28);
        tabPage_dou.Name = "tabPage_dou";
        tabPage_dou.Padding = new Padding(3);
        tabPage_dou.Size = new Size(692, 330);
        tabPage_dou.TabIndex = 0;
        tabPage_dou.Text = "斗哥";
        tabPage_dou.UseVisualStyleBackColor = true;
        // 
        // richTextBox_dou
        // 
        richTextBox_dou.Location = new Point(-4, 0);
        richTextBox_dou.Name = "richTextBox_dou";
        richTextBox_dou.Size = new Size(700, 334);
        richTextBox_dou.TabIndex = 5;
        richTextBox_dou.Text = "";
        // 
        // tabPage_kai
        // 
        tabPage_kai.Controls.Add(richTextBox_kai);
        tabPage_kai.Location = new Point(4, 28);
        tabPage_kai.Name = "tabPage_kai";
        tabPage_kai.Padding = new Padding(3);
        tabPage_kai.Size = new Size(692, 330);
        tabPage_kai.TabIndex = 1;
        tabPage_kai.Text = "楷特";
        tabPage_kai.UseVisualStyleBackColor = true;
        // 
        // richTextBox_kai
        // 
        richTextBox_kai.Location = new Point(-4, 0);
        richTextBox_kai.Name = "richTextBox_kai";
        richTextBox_kai.Size = new Size(700, 334);
        richTextBox_kai.TabIndex = 6;
        richTextBox_kai.Text = "";
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
        tabPage_dou.ResumeLayout(false);
        tabPage_kai.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button_send;
    private TextBox textBox_chat;
    public TabControl tabControl;
    public TabPage tabPage_dou;
    public TabPage tabPage_kai;
    private RichTextBox richTextBox_dou;
    private RichTextBox richTextBox_kai;
}
