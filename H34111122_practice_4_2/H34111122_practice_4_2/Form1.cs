namespace H34111122_practice_4_2;

public partial class Form1 : Form
{
    public Color color1, color2;
    Image dog, cat, emoji;
    bool game;

    private Image ResizeImage(Image image, int width, int height)
    {
        Bitmap resizedBitmap = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(resizedBitmap))
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

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
        game = false;
    }

    private void add_dog(string msg)
    {
        richTextBox_dog.SelectionAlignment = HorizontalAlignment.Right;
        using (MemoryStream stream = new MemoryStream())
        {
            dog.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_dog.Paste();
        }
        richTextBox_dog.AppendText("斗哥:" + msg + "\n");

        richTextBox_cat.SelectionAlignment = HorizontalAlignment.Left;
        using (MemoryStream stream = new MemoryStream())
        {
            dog.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_cat.Paste();
        }
        richTextBox_cat.AppendText("斗哥:" + msg + "\n");
    }

    private void add_dog(int index)
    {
        richTextBox_dog.SelectionAlignment = HorizontalAlignment.Right;
        using (MemoryStream stream = new MemoryStream())
        {
            dog.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_dog.Paste();
        }
        richTextBox_dog.AppendText("斗哥:");
        using (MemoryStream stream = new MemoryStream())
        {
            Image emoji = ResizeImage(Image.FromFile("Images/" + index + ".png"), 18, 18);
            emoji.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_dog.Paste();
        }
        richTextBox_dog.AppendText("\n");

        richTextBox_cat.SelectionAlignment = HorizontalAlignment.Left;
        using (MemoryStream stream = new MemoryStream())
        {
            dog.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_cat.Paste();
        }
        richTextBox_cat.AppendText("斗哥:");
        using (MemoryStream stream = new MemoryStream())
        {
            Image emoji = ResizeImage(Image.FromFile("Images/" + index + ".png"), 18, 18);
            emoji.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_cat.Paste();
        }
        richTextBox_cat.AppendText("\n");
    }

    private void add_cat(string msg)
    {
        richTextBox_dog.SelectionAlignment = HorizontalAlignment.Left;
        using (MemoryStream stream = new MemoryStream())
        {
            cat.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_dog.Paste();
        }
        richTextBox_dog.AppendText("楷特:" + msg + "\n");

        richTextBox_cat.SelectionAlignment = HorizontalAlignment.Right;
        using (MemoryStream stream = new MemoryStream())
        {
            cat.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_cat.Paste();
        }
        richTextBox_cat.AppendText("楷特:" + msg + "\n");
    }

    private void add_cat(int index)
    {
        richTextBox_dog.SelectionAlignment = HorizontalAlignment.Left;
        using (MemoryStream stream = new MemoryStream())
        {
            cat.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_dog.Paste();
        }
        richTextBox_dog.AppendText("楷特:");
        using (MemoryStream stream = new MemoryStream())
        {
            Image emoji = ResizeImage(Image.FromFile("Images/" + index + ".png"), 18, 18);
            emoji.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_dog.Paste();
        }
        richTextBox_dog.AppendText("\n");

        richTextBox_cat.SelectionAlignment = HorizontalAlignment.Right;
        using (MemoryStream stream = new MemoryStream())
        {
            cat.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_cat.Paste();
        }
        richTextBox_cat.AppendText("楷特:");
        using (MemoryStream stream = new MemoryStream())
        {
            Image emoji = ResizeImage(Image.FromFile("Images/" + index + ".png"), 18, 18);
            emoji.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;


            Clipboard.SetImage(Image.FromStream(stream));
            richTextBox_cat.Paste();
        }
        richTextBox_cat.AppendText("\n");
    }

    private void chat_dog()
    {
        BackColor = color1;
        richTextBox_dog.BackColor = color1;
    }

    private void chat_cat()
    {
        BackColor = color2;
        richTextBox_cat.BackColor = color2;
    }

    public void change_color(Color color)
    {
        this.BackColor = color;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl.SelectedTab == tabPage_dog)
        {
            if (game)
            {
                textBox_chat.Enabled = true;
                button_send.Enabled = true;
            }

            // print chat record
            chat_dog();
            textBox_chat.Focus();
        }
        if (tabControl.SelectedTab == tabPage_cat)
        {
            if (game)
            {
                textBox_chat.Enabled = false;
                button_send.Enabled = false;
            }

            // print chat record
            chat_cat();
            textBox_chat.Focus();
        }
    }

    private void mora()
    {
        switch (textBox_chat.Text)
        {
            case "剪刀":
                add_dog(textBox_chat.Text);
                add_cat("布");
                chat_dog();
                game = false;
                textBox_chat.Enabled = true;
                button_emoji.Enabled = true;
                button_send.Enabled = true;
                textBox_chat.Clear();
                return;
            case "石頭":
                add_dog(textBox_chat.Text);
                add_cat("剪刀");
                chat_dog();
                game = false;
                button_emoji.Enabled = true;
                textBox_chat.Enabled = true;
                button_send.Enabled = true;
                textBox_chat.Clear();
                return;
            case "布":
                add_dog(textBox_chat.Text);
                add_cat("石頭");
                chat_dog();
                game = false;
                button_emoji.Enabled = true;
                textBox_chat.Enabled = true;
                button_send.Enabled = true;
                textBox_chat.Clear();
                return;
            default:
                textBox_chat.Clear();
                return;
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
            if (game)
            {
                mora();
                return;
            }
            add_dog(textBox_chat.Text);
            if (textBox_chat.Text == "汪!")
            {
                add_cat("喵");
            }
            if (textBox_chat.Text == "猜拳")
            {
                game = true;
                button_emoji.Enabled = false;
                add_cat("遊戲開始");
            }
            chat_dog();
        }
        if (tabControl.SelectedTab == tabPage_cat)
        {
            add_cat(textBox_chat.Text);
            if (textBox_chat.Text == "喵!")
            {
                add_dog("汪");
            }
            chat_cat();
        }
        textBox_chat.Clear();
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        Form2 f = new Form2();
        f.ShowDialog();

        Color color = f.ReturnValue;
        BackColor = color;
        if (tabControl.SelectedTab == tabPage_dog)
        {
            color1 = color;
            richTextBox_dog.BackColor = color1;
        }
        if (tabControl.SelectedTab == tabPage_cat)
        {
            color2 = color;
            richTextBox_cat.BackColor = color2;
        }
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
        f.ShowDialog();

        int index = f.ReturnValue;
        if (index == -1)
        {
            return;
        }
        if (tabControl.SelectedTab == tabPage_dog)
        {
            add_dog(index);
            chat_dog();
        }
        if (tabControl.SelectedTab == tabPage_cat)
        {
            add_cat(index);
            chat_cat();
        }
    }
}
