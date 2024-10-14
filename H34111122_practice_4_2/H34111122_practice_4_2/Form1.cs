namespace H34111122_practice_4_2;

public partial class Form1 : Form
{
    internal List<Message> record = new List<Message>();
    public Color color1, color2;
    Image dog, cat, emoji;

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

    public Form1()
    {
        InitializeComponent();
        dog = ResizeImage(Image.FromFile("Images/dog.png"), 18, 18);
        cat = ResizeImage(Image.FromFile("Images/cat.png"), 18, 18);
        emoji = ResizeImage(Image.FromFile("Images/button.png"), 22, 22);
        button_emoji.ImageAlign = ContentAlignment.MiddleCenter;
        button_emoji.Image = emoji;
        textBox_chat.Focus();
    }

    private void chat_dog()
    {
        BackColor = color1;
        richTextBox_dog.Clear();
        foreach (var item in record)
        {
            if (item.Sender == "dog")
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    dog.Save(stream, System.Drawing.Imaging.ImageFormat.Png); // 保存圖片到 stream
                    stream.Position = 0;  // 重置位置到流的起點

                    // 載入圖片到 Clipboard 並將其插入到 RichTextBox 中
                    Clipboard.SetImage(Image.FromStream(stream));
                    richTextBox_dog.Paste(); // 將圖片插入到 RichTextBox 當前光標位置
                }
                richTextBox_dog.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox_dog.AppendText("斗哥:" + item.Text + "\n");
            }
            if (item.Sender == "cat")
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    cat.Save(stream, System.Drawing.Imaging.ImageFormat.Png); // 保存圖片到 stream
                    stream.Position = 0;  // 重置位置到流的起點

                    Clipboard.SetImage(Image.FromStream(stream));
                    richTextBox_dog.Paste(); // 將圖片插入到 RichTextBox 當前光標位置
                }
                richTextBox_dog.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox_dog.AppendText("楷特:" + item.Text + "\n");
            }
        }
    }

    private void chat_cat()
    {
        BackColor = color2;
        richTextBox_cat.Clear();
        foreach (var item in record)
        {
            if (item.Sender == "dog")
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    dog.Save(stream, System.Drawing.Imaging.ImageFormat.Png); // 保存圖片到 stream
                    stream.Position = 0;  // 重置位置到流的起點

                    // 載入圖片到 Clipboard 並將其插入到 RichTextBox 中
                    Clipboard.SetImage(Image.FromStream(stream));
                    richTextBox_cat.Paste(); // 將圖片插入到 RichTextBox 當前光標位置
                }
                richTextBox_cat.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox_cat.AppendText("斗哥:" + item.Text + "\n");
            }
            if (item.Sender == "cat")
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    cat.Save(stream, System.Drawing.Imaging.ImageFormat.Png); // 保存圖片到 stream
                    stream.Position = 0;  // 重置位置到流的起點

                    Clipboard.SetImage(Image.FromStream(stream));
                    richTextBox_cat.Paste(); // 將圖片插入到 RichTextBox 當前光標位置
                }
                richTextBox_cat.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox_cat.AppendText("楷特:" + item.Text + "\n");
            }
        }
    }

    public void change_color(Color color)
    {
        this.BackColor = color;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl.SelectedTab == tabPage_dog)
        {
            /*textBox_chat.Enabled = false;*/
            /*button_send.Enabled = false;*/

            // print chat record
            chat_dog();
            textBox_chat.Focus();
        }
        if (tabControl.SelectedTab == tabPage_cat)
        {
            textBox_chat.Enabled = true;
            button_send.Enabled = true;

            // print chat record
            chat_cat();
            textBox_chat.Focus();
        }
    }

    private void button_send_Click(object sender, EventArgs e)
    {
        if (textBox_chat.Text == "")
        {
            return;
        }
        if (tabControl.SelectedTab == tabPage_dog)
        {
            record.Add(new Message("dog", textBox_chat.Text));
            if (textBox_chat.Text == "汪!")
            {
                record.Add(new Message("cat", "喵"));
            }
            chat_dog();
        }
        if (tabControl.SelectedTab == tabPage_cat)
        {
            record.Add(new Message("cat", textBox_chat.Text));
            if (textBox_chat.Text == "喵!")
            {
                record.Add(new Message("dog", "汪"));
            }
            chat_cat();
        }
        textBox_chat.Clear();
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        Form2 f = new Form2();
        f.Show();
    }

    private void textBox_chat_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            button_send_Click(sender, e);
            e.SuppressKeyPress = true;
        }
    }

    private void button_emoji_Click(object sender, EventArgs e)
    {
        Form_emoji f = new Form_emoji();
        f.Show();
    }
}
