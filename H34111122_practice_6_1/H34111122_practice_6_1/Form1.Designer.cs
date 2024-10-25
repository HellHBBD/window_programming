namespace H34111122_practice_6_1;

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
        panel_start = new Panel();
        button_start = new Button();
        pictureBox_selected = new PictureBox();
        pictureBox_inventory = new PictureBox();
        pictureBox_dirt = new PictureBox();
        pictureBox_stone = new PictureBox();
        panel_start.SuspendLayout();
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
        hScrollBar1.Tag = "ui";
        hScrollBar1.Visible = false;
        // 
        // vScrollBar1
        // 
        vScrollBar1.Location = new Point(856, 0);
        vScrollBar1.Name = "vScrollBar1";
        vScrollBar1.Size = new Size(26, 453);
        vScrollBar1.TabIndex = 1;
        vScrollBar1.Tag = "ui";
        vScrollBar1.Visible = false;
        // 
        // panel_start
        // 
        panel_start.Controls.Add(button_start);
        panel_start.Location = new Point(0, 0);
        panel_start.Name = "panel_start";
        panel_start.Size = new Size(882, 453);
        panel_start.TabIndex = 0;
        // 
        // button_start
        // 
        button_start.Location = new Point(408, 210);
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
        pictureBox_selected.Tag = "ui";
        pictureBox_selected.Visible = false;
        // 
        // pictureBox_inventory
        // 
        pictureBox_inventory.Location = new Point(260, 360);
        pictureBox_inventory.Name = "pictureBox_inventory";
        pictureBox_inventory.Size = new Size(360, 40);
        pictureBox_inventory.TabIndex = 1;
        pictureBox_inventory.TabStop = false;
        pictureBox_inventory.Tag = "ui";
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
        pictureBox_dirt.Tag = "ui";
        // 
        // pictureBox_stone
        // 
        pictureBox_stone.Location = new Point(310, 370);
        pictureBox_stone.Name = "pictureBox_stone";
        pictureBox_stone.Size = new Size(20, 20);
        pictureBox_stone.TabIndex = 2;
        pictureBox_stone.TabStop = false;
        pictureBox_stone.Visible = false;
        pictureBox_stone.Tag = "ui";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 453);
        Controls.Add(pictureBox_stone);
        Controls.Add(pictureBox_dirt);
        Controls.Add(pictureBox_selected);
        Controls.Add(pictureBox_inventory);
        Controls.Add(vScrollBar1);
        Controls.Add(hScrollBar1);
        Controls.Add(panel_start);
        Controls.Add(panel_game);
        Name = "Form1";
        Text = "Form1";
        KeyDown += Form1_KeyDown;
        panel_start.ResumeLayout(false);
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
    private Panel panel_start;
    private Button button_start;
    private PictureBox pictureBox_inventory;
    private PictureBox pictureBox_selected;
    private PictureBox pictureBox_stone;
    private PictureBox pictureBox_dirt;
}
