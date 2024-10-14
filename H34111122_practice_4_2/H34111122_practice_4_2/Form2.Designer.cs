namespace H34111122_practice_4_2
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
            button_confirm = new Button();
            SuspendLayout();
            // 
            // button_confirm
            // 
            button_confirm.Location = new Point(356, 358);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(94, 29);
            button_confirm.TabIndex = 0;
            button_confirm.Text = "確定";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_confirm);
            Name = "Form2";
            Text = "顏色選擇";
            Load += Form2_Load;
            MouseClick += Form2_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private Button button_confirm;
    }
}
