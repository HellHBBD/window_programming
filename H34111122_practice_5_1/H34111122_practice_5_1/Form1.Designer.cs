namespace H34111122_practice_5_1;

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
        components = new System.ComponentModel.Container();
        button_start = new Button();
        pictureBox_plate = new PictureBox();
        panel_game = new Panel();
        label = new Label();
        timer_fall = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)pictureBox_plate).BeginInit();
        panel_game.SuspendLayout();
        SuspendLayout();
        // 
        // button_start
        // 
        button_start.Location = new Point(356, 204);
        button_start.Name = "button_start";
        button_start.Size = new Size(94, 29);
        button_start.TabIndex = 0;
        button_start.Text = "開始遊戲";
        button_start.UseVisualStyleBackColor = true;
        button_start.Click += button_start_Click;
        // 
        // pictureBox_plate
        // 
        pictureBox_plate.BackColor = Color.Red;
        pictureBox_plate.Location = new Point(346, 350);
        pictureBox_plate.Name = "pictureBox_plate";
        pictureBox_plate.Size = new Size(114, 10);
        pictureBox_plate.TabIndex = 1;
        pictureBox_plate.TabStop = false;
        // 
        // panel_game
        // 
        panel_game.Controls.Add(label);
        panel_game.Controls.Add(pictureBox_plate);
        panel_game.Location = new Point(0, 0);
        panel_game.Name = "panel_game";
        panel_game.Size = new Size(800, 450);
        panel_game.TabIndex = 2;
        panel_game.Visible = false;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Location = new Point(-1, 0);
        label.Name = "label";
        label.Size = new Size(33, 19);
        label.TabIndex = 2;
        label.Text = "0/0";
        // 
        // timer_fall
        // 
        timer_fall.Interval = 20;
        timer_fall.Tick += timer_fall_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button_start);
        Controls.Add(panel_game);
        Name = "Form1";
        Text = "Form1";
        KeyDown += Form1_KeyDown;
        KeyUp += Form1_KeyUp;
        ((System.ComponentModel.ISupportInitialize)pictureBox_plate).EndInit();
        panel_game.ResumeLayout(false);
        panel_game.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button button_start;
    private PictureBox pictureBox_plate;
    private Panel panel_game;
    private System.Windows.Forms.Timer timer_fall;
    private Label label;
}
