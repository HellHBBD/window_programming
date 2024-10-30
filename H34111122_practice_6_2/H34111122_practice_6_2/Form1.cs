namespace H34111122_practice_6_2;

using System.Text.Json;
using System.Drawing;
using System.Drawing.Imaging;

public partial class Form1 : Form
{
    PictureBox[,] pb = new PictureBox[15, 30];
    static int size = 40;
    Image currentBlock, dirt, stone;
    PictureBox steve = new PictureBox();

    bool menuVisible = false;

    public Form1()
    {
        InitializeComponent();
        KeyPreview = true;
        panel_title.BackgroundImage = Image.FromFile("img/background.jpg");
        pictureBox_minecraft.Image = Image.FromFile("img/title.png");
        pictureBox_minecraft.BackColor = Color.Transparent;

        dirt = ResizeImage(Image.FromFile("img/dirt.png"), size, size);
        currentBlock = dirt;
        stone = ResizeImage(Image.FromFile("img/stone.png"), size, size);
        pictureBox_inventory.Image = ResizeImage(Image.FromFile("img/inventory.png"), 9 * size, size);

        pictureBox_selected.Image = ResizeImage(Image.FromFile("img/selected.png"), size + 4, size + 4);
        pictureBox_selected.BackColor = Color.Transparent;

        pictureBox_dirt.Image = ResizeImage(dirt, size - 10, size - 10);
        pictureBox_dirt.MouseClick += (sender, e) =>
        {
            pictureBox_selected.Left = 258;
            currentBlock = dirt;
        };

        pictureBox_stone.Image = ResizeImage(stone, size - 10, size - 10);
        pictureBox_stone.MouseClick += (sender, e) =>
        {
            pictureBox_selected.Left = 298;
            currentBlock = stone;
        };

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
            }
        }
        panel_game.Controls.Add(steve);
        steve.Image = ResizeImage(Image.FromFile("img/steve.png"), size, 2 * size);
        steve.Location = new Point(size, 6 * size);
        steve.Size = new Size(size, 2 * size);
        steve.BackColor = Color.LightGray;
        steve.BringToFront();

        vScrollBar1.Scroll += vScrollBar_Scroll;
        hScrollBar1.Scroll += hScrollBar_Scroll;
        /*vScrollBar1.ValueChanged += (sender, e) =>*/
        /*{*/
        /*    panel_game.Top = -2 * vScrollBar1.Value;*/
        /*};*/
        /*hScrollBar1.ValueChanged += (sender, e) =>*/
        /*{*/
        /*    panel_game.Left = -4 * hScrollBar1.Value;*/
        /*};*/
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

    public Image SetImageOpacity(Image image, float opacity)
    {
        ColorMatrix matrix = new ColorMatrix();
        matrix.Matrix33 = opacity;
        ImageAttributes attributes = new ImageAttributes();
        attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

        Bitmap bmp = new Bitmap(image.Width, image.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
        }
        return bmp;
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

    private void menu_on()
    {
        menuVisible = true;

        button_resume.Visible = true;
        button_resume.BringToFront();

        button_save.Visible = true;
        button_save.BringToFront();

        button_title.Visible = true;
        button_title.BringToFront();
    }

    private void menu_off()
    {
        menuVisible = false;

        button_resume.Visible = false;
        button_save.Visible = false;
        button_title.Visible = false;
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
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                if (i >= 8 && i <= 9)
                {
                    pb[i, j].Image = dirt;
                }
                else if (i >= 10)
                {
                    pb[i, j].Image = stone;
                }
                else
                {
                    pb[i, j].Image = null;
                }
            }
        }
        panel_title.Visible = false;
        panel_game.Visible = true;
        panel_game.Enabled = true;
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
        else if (e.KeyCode == Keys.Escape && panel_game.Visible)
        {
            if (menuVisible)
            {
                menu_off();
                panel_game.Enabled = false;
            }
            else
            {
                menu_on();
                panel_game.Enabled = true;
            }
        }
    }

    private void button_old_Click(object sender, EventArgs e)
    {
        string jsonString = File.ReadAllText("map.json");
        List<List<int>> map = JsonSerializer.Deserialize<List<List<int>>>(jsonString);
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                switch (map[i][j])
                {
                    case 0:
                        pb[i, j].Image = null;
                        break;
                    case 1:
                        pb[i, j].Image = dirt;
                        break;
                    case 2:
                        pb[i, j].Image = stone;
                        break;
                }
            }
        }
        panel_title.Visible = false;
        panel_game.Visible = true;
        panel_game.BringToFront();

        ui_on();
    }

    private void button_leave_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button_resume_Click(object sender, EventArgs e)
    {
        menu_off();
        panel_game.Enabled = true;
    }

    private void button_save_Click(object sender, EventArgs e)
    {
        List<List<int>> map = new List<List<int>>();
        for (int i = 0; i < 15; i++)
        {
            List<int> temp = new List<int>();
            for (int j = 0; j < 30; j++)
            {
                if (pb[i, j].Image == null)
                {
                    temp.Add(0);
                }
                else if (pb[i, j].Image == dirt)
                {
                    temp.Add(1);
                }
                else if (pb[i, j].Image == stone)
                {
                    temp.Add(2);
                }
            }
            map.Add(temp);
        }
        string jsonString = JsonSerializer.Serialize(map);
        File.WriteAllText("map.json", jsonString);

        menu_off();
        panel_game.Visible = false;
        panel_title.Visible = true;
        panel_title.BringToFront();
    }

    private void button_title_Click(object sender, EventArgs e)
    {
        menu_off();
        panel_game.Visible = false;
        panel_title.Visible = true;
        panel_title.BringToFront();
    }

    private float GetScrollPercent(ScrollBar scrollBar)
    {
        float scrollPos;
        if (scrollBar.Maximum == scrollBar.LargeChange)
            scrollPos = scrollBar.Value;
        else
            scrollPos = (float)scrollBar.Value / (scrollBar.Maximum - scrollBar.LargeChange);
        if (scrollPos > 1)
            scrollPos = 1;
        return scrollPos;
    }

    private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
    {
        int len = panel_game.Width - Width + size;
        if (len < 0)
        {
            panel_game.Left = 0;
            return;
        }
        panel_game.Left = (int)(-len * GetScrollPercent(hScrollBar1));
    }

    private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
    {
        int len = panel_game.Height - Height + 3 * size / 2;
        if (len < 0)
        {
            panel_game.Top = 0;
            return;
        }
        panel_game.Top = (int)(-len * GetScrollPercent(vScrollBar1));
    }

}
