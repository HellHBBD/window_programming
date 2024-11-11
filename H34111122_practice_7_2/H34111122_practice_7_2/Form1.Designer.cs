namespace H34111122_practice_7_2;

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
        menuStrip = new MenuStrip();
        toolStripMenuItem_file = new ToolStripMenuItem();
        新增ToolStripMenuItem = new ToolStripMenuItem();
        開啟舊檔ToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem_exit = new ToolStripMenuItem();
        openFileDialog = new OpenFileDialog();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.ImageScalingSize = new Size(20, 20);
        menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_file, toolStripMenuItem_exit });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(800, 28);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip1";
        // 
        // toolStripMenuItem_file
        // 
        toolStripMenuItem_file.DropDownItems.AddRange(new ToolStripItem[] { 新增ToolStripMenuItem, 開啟舊檔ToolStripMenuItem });
        toolStripMenuItem_file.Name = "toolStripMenuItem_file";
        toolStripMenuItem_file.Size = new Size(53, 24);
        toolStripMenuItem_file.Text = "檔案";
        // 
        // 新增ToolStripMenuItem
        // 
        新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
        新增ToolStripMenuItem.Size = new Size(224, 26);
        新增ToolStripMenuItem.Text = "新增";
        新增ToolStripMenuItem.Click += 新增ToolStripMenuItem_Click;
        // 
        // 開啟舊檔ToolStripMenuItem
        // 
        開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
        開啟舊檔ToolStripMenuItem.Size = new Size(224, 26);
        開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
        開啟舊檔ToolStripMenuItem.Click += 開啟舊檔ToolStripMenuItem_Click;
        // 
        // toolStripMenuItem_exit
        // 
        toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
        toolStripMenuItem_exit.Size = new Size(53, 23);
        toolStripMenuItem_exit.Text = "結束";
        toolStripMenuItem_exit.Click += toolStripMenuItem_exit_Click;
        // 
        // openFileDialog
        // 
        openFileDialog.Filter = "自訂文字檔 (*.mytxt)|*.mytxt|文字檔 (*.txt)|*.txt";
        openFileDialog.Title = "開啟檔案";
        openFileDialog.RestoreDirectory = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Name = "Form1";
        Text = "Form1";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem toolStripMenuItem_file;
    private ToolStripMenuItem toolStripMenuItem_exit;
    private ToolStripMenuItem 新增ToolStripMenuItem;
    private ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
    private OpenFileDialog openFileDialog;
}
