namespace H34111122_practice_6_2;

public partial class Form1 : Form
{
    PictureBox[,] pb = new PictureBox[15, 30];
    static int size = 40;
    Image currentBlock, dirt, stone;
    PictureBox steve = new PictureBox();

    public Form1()
    {
        InitializeComponent();
        KeyPreview = true;

        dirt = ResizeImage(Image.FromFile("img/dirt.png"), size, size);
        currentBlock = dirt;
        stone = ResizeImage(Image.FromFile("img/stone.png"), size, size);
        pictureBox_inventory.Image = ResizeImage(Image.FromFile("img/inventory.png"), 9 * size, size);
        pictureBox_selected.Image = ResizeImage(Image.FromFile("img/selected.png"), size + 4, size + 4);
        pictureBox_selected.BackColor = Color.Transparent;
        pictureBox_dirt.Image = ResizeImage(dirt, size - 20, size - 20);
        pictureBox_stone.Image = ResizeImage(stone, size - 20, size - 20);

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                pb[i, j] = new PictureBox();
                panel_game.Controls.Add(pb[i, j]);
                pb[i, j].Location = new Point(j * 40, i * 40);
                pb[i, j].Size = new Size(size, size);
                pb[i, j].BackColor = Color.LightGray;
                pb[i, j].MouseClick += pb_MouseClick;
                if (i >= 8 && i <= 9)
                {
                    pb[i, j].Image = dirt;
                }
                if (i >= 10)
                {
                    pb[i, j].Image = stone;
                }
            }
        }
        panel_game.Controls.Add(steve);
        steve.Image = ResizeImage(Image.FromFile("img/steve.png"), size, 2 * size);
        steve.Location = new Point(size, 6 * size);
        steve.Size = new Size(size, 2 * size);
        steve.BackColor = Color.LightGray;
        steve.BringToFront();

        vScrollBar1.ValueChanged += (sender, e) =>
        {
            panel_game.Top = -2 * vScrollBar1.Value;
        };
        hScrollBar1.ValueChanged += (sender, e) =>
        {
            panel_game.Left = -4 * hScrollBar1.Value;
        };
    }

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

    private void ui_on()
    {
        hScrollBar1.Visible = true;
        hScrollBar1.BringToFront();

        vScrollBar1.Visible = true;
        vScrollBar1.BringToFront();

        pictureBox_inventory.Visible = true;
        pictureBox_inventory.BringToFront();

        pictureBox_selected.Visible = true;
        pictureBox_selected.BringToFront();

        pictureBox_dirt.Visible = true;
        pictureBox_dirt.BringToFront();

        pictureBox_stone.Visible = true;
        pictureBox_stone.BringToFront();
    }

    private void ui_off()
    {
        hScrollBar1.Visible = false;
        vScrollBar1.Visible = false;
        pictureBox_selected.Visible = false;
        pictureBox_inventory.Visible = false;
        pictureBox_dirt.Visible = false;
        pictureBox_stone.Visible = false;
    }

    private void pb_MouseClick(Object sender, MouseEventArgs e)
    {
        PictureBox pb = (PictureBox)sender;
        if (e.Button == MouseButtons.Left)
        {
            pb.Image = null;
        }
        if (e.Button == MouseButtons.Right && pb.Image == null)
        {
            pb.Image = currentBlock;
        }
    }

    private void button_start_Click(object sender, EventArgs e)
    {
        panel_start.Visible = false;
        panel_game.Visible = true;
        panel_game.BringToFront();

        ui_on();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.D1)
        {
            pictureBox_selected.Left = 258;
            currentBlock = dirt;
        }
        else if (e.KeyCode == Keys.D2)
        {
            pictureBox_selected.Left = 298;
            currentBlock = stone;
        }
    }

    private void button_old_Click(object sender, EventArgs e)
    {

    }

    private void button_leave_Click(object sender, EventArgs e)
    {
        Close();
    }
}
