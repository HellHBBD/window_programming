namespace H34111122_practice_7_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            toolStripMenuItem_file = new ToolStripMenuItem();
            儲存ToolStripMenuItem = new ToolStripMenuItem();
            另存新檔ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_edit = new ToolStripMenuItem();
            剪下ToolStripMenuItem = new ToolStripMenuItem();
            複製ToolStripMenuItem = new ToolStripMenuItem();
            貼上ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_text = new ToolStripMenuItem();
            字型ToolStripMenuItem = new ToolStripMenuItem();
            顏色ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_exit = new ToolStripMenuItem();
            textBox = new TextBox();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_file, toolStripMenuItem_edit, toolStripMenuItem_text, toolStripMenuItem_exit });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem_file
            // 
            toolStripMenuItem_file.DropDownItems.AddRange(new ToolStripItem[] { 儲存ToolStripMenuItem, 另存新檔ToolStripMenuItem });
            toolStripMenuItem_file.Name = "toolStripMenuItem_file";
            toolStripMenuItem_file.Size = new Size(53, 24);
            toolStripMenuItem_file.Text = "檔案";
            // 
            // 儲存ToolStripMenuItem
            // 
            儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            儲存ToolStripMenuItem.Size = new Size(224, 26);
            儲存ToolStripMenuItem.Text = "儲存";
            儲存ToolStripMenuItem.Click += 儲存ToolStripMenuItem_Click;
            // 
            // 另存新檔ToolStripMenuItem
            // 
            另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            另存新檔ToolStripMenuItem.Size = new Size(224, 26);
            另存新檔ToolStripMenuItem.Text = "另存新檔";
            另存新檔ToolStripMenuItem.Click += 另存新檔ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_edit
            // 
            toolStripMenuItem_edit.DropDownItems.AddRange(new ToolStripItem[] { 剪下ToolStripMenuItem, 複製ToolStripMenuItem, 貼上ToolStripMenuItem });
            toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            toolStripMenuItem_edit.Size = new Size(53, 24);
            toolStripMenuItem_edit.Text = "編輯";
            // 
            // 剪下ToolStripMenuItem
            // 
            剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            剪下ToolStripMenuItem.Size = new Size(224, 26);
            剪下ToolStripMenuItem.Text = "剪下";
            剪下ToolStripMenuItem.Click += 剪下ToolStripMenuItem_Click;
            // 
            // 複製ToolStripMenuItem
            // 
            複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            複製ToolStripMenuItem.Size = new Size(224, 26);
            複製ToolStripMenuItem.Text = "複製";
            複製ToolStripMenuItem.Click += 複製ToolStripMenuItem_Click;
            // 
            // 貼上ToolStripMenuItem
            // 
            貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            貼上ToolStripMenuItem.Size = new Size(224, 26);
            貼上ToolStripMenuItem.Text = "貼上";
            貼上ToolStripMenuItem.Click += 貼上ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_text
            // 
            toolStripMenuItem_text.DropDownItems.AddRange(new ToolStripItem[] { 字型ToolStripMenuItem, 顏色ToolStripMenuItem });
            toolStripMenuItem_text.Name = "toolStripMenuItem_text";
            toolStripMenuItem_text.Size = new Size(53, 24);
            toolStripMenuItem_text.Text = "文字";
            // 
            // 字型ToolStripMenuItem
            // 
            字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            字型ToolStripMenuItem.Size = new Size(122, 26);
            字型ToolStripMenuItem.Text = "字型";
            字型ToolStripMenuItem.Click += 字型ToolStripMenuItem_Click;
            // 
            // 顏色ToolStripMenuItem
            // 
            顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            顏色ToolStripMenuItem.Size = new Size(122, 26);
            顏色ToolStripMenuItem.Text = "顏色";
            顏色ToolStripMenuItem.Click += 顏色ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem_exit
            // 
            toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            toolStripMenuItem_exit.Size = new Size(53, 24);
            toolStripMenuItem_exit.Text = "結束";
            toolStripMenuItem_exit.Click += toolStripMenuItem_exit_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 30);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(776, 408);
            textBox.TabIndex = 2;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "自訂文字檔 (*.mytxt)|*.mytxt|文字檔 (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "保存文件";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form2";
            Text = "Form2";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem_edit;
        private ToolStripMenuItem 剪下ToolStripMenuItem;
        private ToolStripMenuItem 複製ToolStripMenuItem;
        private ToolStripMenuItem 貼上ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_file;
        private ToolStripMenuItem 儲存ToolStripMenuItem;
        private ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_text;
        private ToolStripMenuItem 字型ToolStripMenuItem;
        private ToolStripMenuItem 顏色ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_exit;
        private TextBox textBox;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private SaveFileDialog saveFileDialog;
    }
}
