namespace H34111122_practice_5_2;

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
        panel_start = new Panel();
        button_start = new Button();
        panel_choose = new Panel();
        button_action = new Button();
        button_remove = new Button();
        button_add = new Button();
        listBox_selected = new ListBox();
        listBox_list = new ListBox();
        panel_game = new Panel();
        panel_over = new Panel();
        panel_start.SuspendLayout();
        panel_choose.SuspendLayout();
        SuspendLayout();
        // 
        // panel_start
        // 
        panel_start.Controls.Add(button_start);
        panel_start.Location = new Point(0, 0);
        panel_start.Name = "panel_start";
        panel_start.Size = new Size(800, 450);
        panel_start.TabIndex = 0;
        // 
        // button_start
        // 
        button_start.Location = new Point(363, 195);
        button_start.Name = "button_start";
        button_start.Size = new Size(94, 29);
        button_start.TabIndex = 0;
        button_start.Text = "開始遊戲";
        button_start.UseVisualStyleBackColor = true;
        button_start.Click += button_start_Click;
        // 
        // panel_choose
        // 
        panel_choose.Controls.Add(button_action);
        panel_choose.Controls.Add(button_remove);
        panel_choose.Controls.Add(button_add);
        panel_choose.Controls.Add(listBox_selected);
        panel_choose.Controls.Add(listBox_list);
        panel_choose.Location = new Point(0, 0);
        panel_choose.Name = "panel_choose";
        panel_choose.Size = new Size(800, 450);
        panel_choose.TabIndex = 1;
        panel_choose.Visible = false;
        // 
        // button_action
        // 
        button_action.Location = new Point(559, 282);
        button_action.Name = "button_action";
        button_action.Size = new Size(94, 29);
        button_action.TabIndex = 4;
        button_action.Text = "開始行動";
        button_action.UseVisualStyleBackColor = true;
        button_action.Click += button_action_Click;
        // 
        // button_remove
        // 
        button_remove.Location = new Point(363, 244);
        button_remove.Name = "button_remove";
        button_remove.Size = new Size(94, 29);
        button_remove.TabIndex = 3;
        button_remove.Text = "<";
        button_remove.UseVisualStyleBackColor = true;
        button_remove.Click += button_remove_Click;
        // 
        // button_add
        // 
        button_add.Location = new Point(363, 125);
        button_add.Name = "button_add";
        button_add.Size = new Size(94, 29);
        button_add.TabIndex = 2;
        button_add.Text = ">";
        button_add.UseVisualStyleBackColor = true;
        button_add.Click += button_add_Click;
        // 
        // listBox_selected
        // 
        listBox_selected.FormattingEnabled = true;
        listBox_selected.ItemHeight = 19;
        listBox_selected.Location = new Point(502, 98);
        listBox_selected.Name = "listBox_selected";
        listBox_selected.Size = new Size(202, 175);
        listBox_selected.TabIndex = 1;
        // 
        // listBox_list
        // 
        listBox_list.FormattingEnabled = true;
        listBox_list.ItemHeight = 19;
        listBox_list.Items.AddRange(new object[] { "Cardigan", "Myrtle", "Melantha" });
        listBox_list.Location = new Point(119, 98);
        listBox_list.Name = "listBox_list";
        listBox_list.Size = new Size(202, 213);
        listBox_list.TabIndex = 0;
        // 
        // panel_game
        // 
        panel_game.Location = new Point(0, 0);
        panel_game.Name = "panel_game";
        panel_game.Size = new Size(800, 450);
        panel_game.TabIndex = 0;
        panel_game.Visible = false;
        // 
        // panel_over
        // 
        panel_over.Location = new Point(0, 0);
        panel_over.Name = "panel_over";
        panel_over.Size = new Size(800, 450);
        panel_over.TabIndex = 1;
        panel_over.Visible = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel_game);
        Controls.Add(panel_choose);
        Controls.Add(panel_start);
        Controls.Add(panel_over);
        Name = "Form1";
        Text = "Form1";
        panel_start.ResumeLayout(false);
        panel_choose.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel_start;
    private Button button_start;
    private Panel panel_choose;
    private Panel panel_over;
    private Panel panel_game;
    private Button button_action;
    private Button button_remove;
    private Button button_add;
    private ListBox listBox_selected;
    private ListBox listBox_list;
}
