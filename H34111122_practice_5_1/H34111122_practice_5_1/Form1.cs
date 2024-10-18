namespace H34111122_practice_5_1;

public partial class Form1 : Form
{
    // 盤子移動速度
    static int nornal = 15;
    // 盤子加速速度
    static int super = 30;
    // 水果掉落速度
    static int speed = 4;
    // 畫面最多水果數量
    static int size = 5;

    int step = nornal;
    int catch_count = 0;
    int miss_count = 0;
    Image picture;
    PictureBox[] fruit = new PictureBox[Form1.size];
    Random random = new Random();
    bool left, right;

    public Form1()
    {
        InitializeComponent();
        KeyPreview = true;
        picture = Image.FromFile("img/g1.png");
        pictureBox_plate.Top = ClientSize.Height - ClientSize.Height / size;
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
        timer_fall.Start();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.A:
            case Keys.Left:
                left = true;
                break;
            case Keys.D:
            case Keys.Right:
                right = true;
                break;
            case Keys.ShiftKey:
                step = super;
                break;
        }
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.A:
            case Keys.Left:
                left = false;
                break;
            case Keys.D:
            case Keys.Right:
                right = false;
                break;
            case Keys.ShiftKey:
                step = nornal;
                break;
        }
    }

    private void timer_fall_Tick(object sender, EventArgs e)
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
        if (right && !left)
        {
            moveRight();
        }
        else if (left && !right)
        {
            moveLeft();
        }
    }
}
