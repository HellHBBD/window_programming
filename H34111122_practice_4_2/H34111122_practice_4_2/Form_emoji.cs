using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H34111122_practice_4_2
{
    public partial class Form_emoji : Form
    {
        RadioButton[] radioButton = new RadioButton[6];
        Image[] emoji = new Image[6];
        public int ReturnValue;

        private Image ResizeImage(Image image, int width, int height)
        {
            // 創建一個 Bitmap 來存放調整大小後的圖片
            Bitmap resizedBitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                // 設置高質量插值模式
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // 繪製縮放後的圖片
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedBitmap;
        }

        public Form_emoji()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                emoji[i] = ResizeImage(Image.FromFile("Images/" + i + ".png"), 100, 100);
                radioButton[i] = new RadioButton();
                radioButton[i].AutoSize = true;
                radioButton[i].Size = new Size(17, 16);
                radioButton[i].TabIndex = i;
                radioButton[i].TabStop = true;
                radioButton[i].UseVisualStyleBackColor = true;
                radioButton[i].Image = emoji[i];
                Controls.Add(radioButton[i]);
            }
            radioButton[0].Location = new Point(25, 53);
            radioButton[1].Location = new Point(305, 53);
            radioButton[2].Location = new Point(578, 53);
            radioButton[3].Location = new Point(25, 215);
            radioButton[4].Location = new Point(305, 215);
            radioButton[5].Location = new Point(578, 215);
            ReturnValue = -1;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (radioButton[i].Checked)
                {
                    ReturnValue = i;
                    Close();
                }
            }
        }
    }
}
