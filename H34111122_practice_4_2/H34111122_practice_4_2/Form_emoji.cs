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
        /*RadioButton[] radioButton = new RadioButton[6];*/
        Image[] emoji = new Image[6];

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
                emoji[i] = ResizeImage(Image.FromFile("Images/button.png"), 100, 100);
            }
        }
    }
}
