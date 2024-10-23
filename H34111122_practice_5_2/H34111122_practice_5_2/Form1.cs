namespace H34111122_practice_5_2;

public partial class Form1 : Form
{
    Dictionary<string, bool> agentSelect = new Dictionary<string, bool>();
    public int xstart = 100;
    public int ystart = 100;
    public int size = 95;
    PictureBox[,] arena = new PictureBox[3, 11];
    public bool[,] occupy = new bool[3, 11];

    int health = 3;
    int enemyRemain = 10;
    int money = 30;
    int tickCount = 0;

    int n = 0;
    MainCharacter[] character;
    Enemy enemy;

    public Form1()
    {
        InitializeComponent();
        agentSelect["Cardigan"] = false;
        agentSelect["Myrtle"] = false;
        agentSelect["Melantha"] = false;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                arena[i, j] = new PictureBox();
                arena[i, j].Size = new Size(size, size);
                arena[i, j].Location = new Point(xstart + j * size, ystart + i * size);
                arena[i, j].BackColor = Color.White;
                arena[i, j].BorderStyle = BorderStyle.FixedSingle;
                panel_game.Controls.Add(arena[i, j]);
            }
        }
        arena[1, 0].BackColor = Color.Red;
        occupy[1, 0] = true;
        arena[1, 10].BackColor = Color.PaleTurquoise;
        occupy[1, 10] = true;
    }

    private void button_start_Click(object sender, EventArgs e)
    {
        panel_start.Visible = false;
        panel_choose.Visible = true;
    }

    private void button_add_Click(object sender, EventArgs e)
    {
        if (listBox_list.SelectedItem == null)
        {
            MessageBox.Show("請選擇角色");
            return;
        }
        string name = listBox_list.SelectedItem.ToString();
        if (agentSelect[name] == true)
        {
            MessageBox.Show("請勿重複選擇角色");
            return;
        }
        agentSelect[name] = true;
        listBox_selected.Items.Add(name);
        listBox_list.ClearSelected();
    }

    private void button_remove_Click(object sender, EventArgs e)
    {
        if (listBox_selected.SelectedItem == null)
        {
            MessageBox.Show("請選擇要移除的角色");
            return;
        }
        string name = listBox_selected.SelectedItem.ToString();
        agentSelect[name] = false;
        listBox_selected.Items.Remove(name);
        listBox_selected.ClearSelected();
    }

    private void button_action_Click(object sender, EventArgs e)
    {
        int n = listBox_selected.Items.Count;
        if (n == 0)
        {
            MessageBox.Show("至少選擇一個角色");
            return;
        }
        panel_choose.Visible = false;
        panel_game.Visible = true;
        character = new MainCharacter[n];
        int index = 0;
        if (agentSelect["Cardigan"])
        {
            character[index] = new Cardigan(index);
            index++;
        }
        if (agentSelect["Myrtle"])
        {
            character[index] = new Myrtle(index);
            index++;
        }
        if (agentSelect["Melantha"])
        {
            character[index] = new Melantha(index);
            index++;
        }
        enemy = new Enemy();
        timer1.Start();
        timer_move.Start();
    }

    private void second_Tick()
    {
        foreach (var item in character)
        {
            item.currentHealth -= item.damage;
            if (item.currentHealth <= 0)
            {
                item.reset();
            }
        }
        enemy.currentHealth -= enemy.damage;
        if (enemy.currentHealth <= 0)
        {
            enemyRemain--;
            enemy.reset();
        }
        if (money < 99)
        {
            money++;
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        foreach (var item in character)
        {
            item.Defense(enemy);
            item.Attack(enemy);
        }
        int centerX = enemy.pb.Left + enemy.size / 2;
        int centerY = enemy.pb.Top + enemy.size / 2;
        PictureBox main = arena[1, 10];
        if (centerX >= main.Left && centerX <= main.Right && centerY >= main.Top && centerY <= main.Bottom)
        {
            health--;
            if (health == 0)
            {
                timer1.Stop();
                timer_move.Stop();
                panel_game.Visible = false;
                panel_over.Visible = true;
                label_msg.Text = "通關失敗";
            }
            enemyRemain--;
            enemy.reset();
            timer_move.Start();
        }
        label_health_remain.Text = health + "/" + enemyRemain;
        label_money.Text = money.ToString();

        tickCount++;
        if (tickCount % 50 == 0)
        {
            second_Tick();
        }
        if (enemyRemain == 0 && health > 0)
        {
            timer1.Stop();
            timer_move.Stop();
            panel_game.Visible = false;
            panel_over.Visible = true;
            label_msg.Text = "通關成功";
        }
    }

    private void timer_move_Tick(object sender, EventArgs e)
    {
        enemy.move();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        timer_move.Stop();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        timer_move.Start();
    }
}
