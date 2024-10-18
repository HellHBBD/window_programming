namespace H34111122_practice_5_1;

public partial class Form1 : Form
{
    int step = 10;
    int catch_count = 0;
    int miss_count = 0;
    Image picture;
    static int size = 5;
    int speed = 4;
    PictureBox[] fruit = new PictureBox[Form1.size];
    Random random = new Random();

    /*private Image ResizeImage(Image image, int width, int height)*/
    /*{*/
    /*    Bitmap resizedBitmap = new Bitmap(width, height);*/
    /**/
    /*    using (Graphics g = Graphics.FromImage(resizedBitmap))*/
    /*    {*/
    /*        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;*/
    /**/
    /*        g.DrawImage(image, 0, 0, width, height);*/
    /*    }*/
    /**/
    /*    return resizedBitmap;*/
    /*}*/

    public Form1()
    {
        InitializeComponent();
        KeyPreview = true;
        /*picture = ResizeImage(Image.FromFile("Images/dog.png"), 30, 30);*/
        picture = Image.FromFile("img/g1.png");
        for (int i = 0; i < fruit.Length; i++)
        {
            fruit[i] = new PictureBox();
            fruit[i].Image = picture;
            fruit[i].SizeMode = PictureBoxSizeMode.StretchImage;
            fruit[i].Size = new Size(30, 30);
            fruit[i].Top = -fruit[i].Height - i * ClientSize.Height / size;
            fruit[i].Left = random.Next(ClientSize.Width - fruit[i].Width);
            panel_game.Controls.Add(fruit[i]);
        }
    }

    private void moveLeft()
    {
        if (pictureBox_plate.Location.X > 0)
        {
            pictureBox_plate.Left -= step;
        }
    }

    private void moveRight()
    {
        if (pictureBox_plate.Location.X + pictureBox_plate.Width < ClientSize.Width)
        {
            pictureBox_plate.Left += step;
        }
    }

    private void button_start_Click(object sender, EventArgs e)
    {
        button_start.Visible = false;
        panel_game.Visible = true;
        timer.Start();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && e.Shift)
        {
            step = 40;
            moveLeft();
            step = 10;
            return;
        }
        if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && e.Shift)
        {
            step = 40;
            moveLeft();
            step = 10;
            return;
        }
        switch (e.KeyCode)
        {
            case Keys.A:
            case Keys.Left:
                moveLeft();
                break;
            case Keys.D:
            case Keys.Right:
                moveRight();
                break;
        }
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.Shift)
        {
            step = 10;
        }
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        foreach (var item in fruit)
        {
            item.Top += speed;
            if (item.Location.X + item.Size.Width > pictureBox_plate.Location.X &&
                item.Location.X < pictureBox_plate.Location.X + pictureBox_plate.Size.Width &&
                item.Location.Y + item.Size.Height > pictureBox_plate.Location.Y &&
                item.Location.Y < pictureBox_plate.Location.Y + pictureBox_plate.Size.Height)
            {
                item.Top = -item.Height;
                item.Left = random.Next(ClientSize.Width - item.Width);
                catch_count++;
            }
            else if (item.Top > ClientSize.Height)
            {
                item.Top = -item.Height;
                item.Left = random.Next(ClientSize.Width - item.Width);
                miss_count++;
            }
            label.Text = catch_count + "/" + miss_count;
        }
    }
}
