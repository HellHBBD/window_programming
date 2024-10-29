namespace H34111122_practice_6_2;

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
        panel_game = new Panel();
        hScrollBar1 = new HScrollBar();
        vScrollBar1 = new VScrollBar();
        panel_title = new Panel();
        button_leave = new Button();
        button_old = new Button();
        button_start = new Button();
        pictureBox_selected = new PictureBox();
        pictureBox_inventory = new PictureBox();
        pictureBox_dirt = new PictureBox();
        pictureBox_stone = new PictureBox();
        button_resume = new Button();
        button_save = new Button();
        button_title = new Button();
        panel_title.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox_selected).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox_inventory).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox_dirt).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox_stone).BeginInit();
        SuspendLayout();
        // 
        // panel_game
        // 
        panel_game.Location = new Point(0, 0);
        panel_game.Name = "panel_game";
        panel_game.Size = new Size(1200, 600);
        panel_game.TabIndex = 0;
        panel_game.Visible = false;
        // 
        // hScrollBar1
        // 
        hScrollBar1.Location = new Point(0, 427);
        hScrollBar1.Name = "hScrollBar1";
        hScrollBar1.Size = new Size(882, 26);
        hScrollBar1.TabIndex = 0;
        hScrollBar1.Visible = false;
        // 
        // vScrollBar1
        // 
        vScrollBar1.Location = new Point(856, 0);
        vScrollBar1.Name = "vScrollBar1";
        vScrollBar1.Size = new Size(26, 453);
        vScrollBar1.TabIndex = 1;
        vScrollBar1.Visible = false;
        // 
        // panel_title
        // 
        panel_title.Controls.Add(button_leave);
        panel_title.Controls.Add(button_old);
        panel_title.Controls.Add(button_start);
        panel_title.Location = new Point(0, 0);
        panel_title.Name = "panel_title";
        panel_title.Size = new Size(882, 453);
        panel_title.TabIndex = 0;
        // 
        // button_leave
        // 
        button_leave.Location = new Point(403, 285);
        button_leave.Name = "button_leave";
        button_leave.Size = new Size(94, 29);
        button_leave.TabIndex = 2;
        button_leave.Text = "離開遊戲";
        button_leave.UseVisualStyleBackColor = true;
        button_leave.Click += button_leave_Click;
        // 
        // button_old
        // 
        button_old.Location = new Point(403, 221);
        button_old.Name = "button_old";
        button_old.Size = new Size(94, 29);
        button_old.TabIndex = 1;
        button_old.Text = "開啟存檔";
        button_old.UseVisualStyleBackColor = true;
        button_old.Click += button_old_Click;
        // 
        // button_start
        // 
        button_start.Location = new Point(403, 150);
        button_start.Name = "button_start";
        button_start.Size = new Size(94, 29);
        button_start.TabIndex = 0;
        button_start.Text = "開新遊戲";
        button_start.UseVisualStyleBackColor = true;
        button_start.Click += button_start_Click;
        // 
        // pictureBox_selected
        // 
        pictureBox_selected.Location = new Point(258, 358);
        pictureBox_selected.Name = "pictureBox_selected";
        pictureBox_selected.Size = new Size(44, 44);
        pictureBox_selected.TabIndex = 2;
        pictureBox_selected.TabStop = false;
        pictureBox_selected.Visible = false;
        // 
        // pictureBox_inventory
        // 
        pictureBox_inventory.Location = new Point(260, 360);
        pictureBox_inventory.Name = "pictureBox_inventory";
        pictureBox_inventory.Size = new Size(360, 40);
        pictureBox_inventory.TabIndex = 1;
        pictureBox_inventory.TabStop = false;
        pictureBox_inventory.Visible = false;
        // 
        // pictureBox_dirt
        // 
        pictureBox_dirt.Location = new Point(270, 370);
        pictureBox_dirt.Name = "pictureBox_dirt";
        pictureBox_dirt.Size = new Size(20, 20);
        pictureBox_dirt.TabIndex = 1;
        pictureBox_dirt.TabStop = false;
        pictureBox_dirt.Visible = false;
        // 
        // pictureBox_stone
        // 
        pictureBox_stone.Location = new Point(310, 370);
        pictureBox_stone.Name = "pictureBox_stone";
        pictureBox_stone.Size = new Size(20, 20);
        pictureBox_stone.TabIndex = 2;
        pictureBox_stone.TabStop = false;
        pictureBox_stone.Visible = false;
        // 
        // button_resume
        // 
        button_resume.Location = new Point(363, 129);
        button_resume.Name = "button_resume";
        button_resume.Size = new Size(187, 29);
        button_resume.TabIndex = 0;
        button_resume.Text = "回到遊戲";
        button_resume.UseVisualStyleBackColor = true;
        button_resume.Visible = false;
        button_resume.Click += button_resume_Click;
        // 
        // button_save
        // 
        button_save.Location = new Point(363, 209);
        button_save.Name = "button_save";
        button_save.Size = new Size(187, 29);
        button_save.TabIndex = 1;
        button_save.Text = "儲存並回到主畫面";
        button_save.UseVisualStyleBackColor = true;
        button_save.Visible = false;
        button_save.Click += button_save_Click;
        // 
        // button_title
        // 
        button_title.Location = new Point(363, 285);
        button_title.Name = "button_title";
        button_title.Size = new Size(187, 29);
        button_title.TabIndex = 2;
        button_title.Text = "回到標題畫面";
        button_title.UseVisualStyleBackColor = true;
        button_title.Visible = false;
        button_title.Click += button_title_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 453);
        Controls.Add(pictureBox_stone);
        Controls.Add(pictureBox_dirt);
        Controls.Add(vScrollBar1);
        Controls.Add(hScrollBar1);
        Controls.Add(pictureBox_selected);
        Controls.Add(pictureBox_inventory);
        Controls.Add(button_title);
        Controls.Add(button_save);
        Controls.Add(button_resume);
        Controls.Add(panel_game);
        Controls.Add(panel_title);
        Name = "Form1";
        Text = "Form1";
        KeyDown += Form1_KeyDown;
        panel_title.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox_selected).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox_inventory).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox_dirt).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox_stone).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel_game;
    private VScrollBar vScrollBar1;
    private HScrollBar hScrollBar1;
    private Panel panel_title;
    private Button button_start;
    private PictureBox pictureBox_inventory;
    private PictureBox pictureBox_selected;
    private PictureBox pictureBox_stone;
    private PictureBox pictureBox_dirt;
    private Button button_leave;
    private Button button_old;
    private Button button_title;
    private Button button_save;
    private Button button_resume;
}
