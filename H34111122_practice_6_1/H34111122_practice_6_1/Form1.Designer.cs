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
        button_stone = new Button();
        button_dirt = new Button();
        hScrollBar1 = new HScrollBar();
        vScrollBar1 = new VScrollBar();
        panel_start = new Panel();
        button_start = new Button();
        panel_start.SuspendLayout();
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
        // button_stone
        // 
        button_stone.Location = new Point(508, 377);
        button_stone.Name = "button_stone";
        button_stone.Size = new Size(94, 29);
        button_stone.TabIndex = 1;
        button_stone.Text = "石頭";
        button_stone.UseVisualStyleBackColor = true;
        button_stone.Visible = false;
        button_stone.Click += button_red_Click;
        // 
        // button_dirt
        // 
        button_dirt.Location = new Point(313, 377);
        button_dirt.Name = "button_dirt";
        button_dirt.Size = new Size(94, 29);
        button_dirt.TabIndex = 0;
        button_dirt.Text = "泥土";
        button_dirt.UseVisualStyleBackColor = true;
        button_dirt.Visible = false;
        button_dirt.Click += button_blue_Click;
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
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 453);
        Controls.Add(hScrollBar1);
        Controls.Add(vScrollBar1);
        Controls.Add(button_stone);
        Controls.Add(button_dirt);
        Controls.Add(panel_start);
        Controls.Add(panel_game);
        Name = "Form1";
        Text = "Form1";
        panel_start.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel_game;
    private VScrollBar vScrollBar1;
    private HScrollBar hScrollBar1;
    private Button button_stone;
    private Button button_dirt;
    private Panel panel_start;
    private Button button_start;
}
