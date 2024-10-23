namespace H34111122_practice_5_2
{
    public enum Status
    {
        unplace, cool, skill
    }

    internal class MainCharacter : Character
    {
        bool drag = false;
        int xrecord, yrecord;

        public string name;
        public int cost;
        public int MaxCD;
        public int currentCD;
        public Status status;

        public MainCharacter(int index)
        : base()
        {
            x = Program.Game.xstart + Program.Game.size * index;
            y = Program.Game.ystart + 3 * Program.Game.size + 80;
            size = Program.Game.size;
            pb.BackColor = Color.White;
            pb.Location = new Point(x, y);
            pb.Size = new Size(size, size);

            pb.MouseDown += new MouseEventHandler(pb_MouseDown);
            pb.MouseMove += new MouseEventHandler(pb_MouseMove);
            pb.MouseUp += new MouseEventHandler(pb_MouseUp);
            pb.MouseClick += new MouseEventHandler(pb_MouseClick);

            status = Status.unplace;
        }

        public void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (status == Status.unplace && drag)
            {
                pb.Left += e.X - xrecord;
                pb.Top += e.Y - yrecord;
            }
        }

        public void pb_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            int mouseX = pb.Left + e.X - xrecord + size / 2;
            int mouseY = pb.Top + e.Y - yrecord + size / 2;
            int indexX = (mouseX - Program.Game.xstart) / size;
            int indexY = (mouseY - Program.Game.ystart) / size;
            if (status == Status.unplace && indexX >= 0 && indexX <= 10 && indexY >= 0 && indexY <= 2 && Program.Game.occupy[indexY, indexX] == false)
            {
                pb.Left = Program.Game.xstart + indexX * size;
                pb.Top = Program.Game.ystart + indexY * size;
                status = Status.cool;
            }
            else if (status == Status.unplace)
            {
                pb.Location = new Point(x, y);
            }
        }

        public void pb_MouseDown(object sender, MouseEventArgs e)
        {
            if (status == Status.unplace && e.Button == MouseButtons.Left)
            {
                drag = true;
                xrecord = e.X;
                yrecord = e.Y;
            }
        }

        public void pb_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pb.Location = new Point(x, y);
                status = Status.unplace;
            }
        }

        public void Attack(Enemy enemy)
        {
            enemy.damage = 0;
            int centerX = enemy.pb.Left + enemy.size / 2;
            int centerY = enemy.pb.Top + enemy.size / 2;
            /*Program.Game.label1.Text = "x:" + centerX + " y:" + centerY;*/
            if ((centerX >= pb.Left - size && centerX <= pb.Right && centerY >= pb.Top && centerY <= pb.Bottom) || (centerX >= pb.Left && centerX <= pb.Right && centerY >= pb.Top - size && centerY <= pb.Bottom + size))
            /*if (pb.Bounds.IntersectsWith(enemy.pb.Bounds))*/
            {
                enemy.damage = attack - enemy.defense;
                /*enemy.currentHealth -= (attack - enemy.defense);*/
                enemy.pb.Text = enemy.currentHealth.ToString();
            }
        }

        public void Defense(Enemy enemy)
        {
            damage = 0;
            int centerX = enemy.pb.Left + enemy.size / 2;
            int centerY = enemy.pb.Top + enemy.size / 2;
            Program.Game.label1.Text = "x:" + centerX + " y:" + centerY + "\n" + pb.Left + " " + pb.Top;
            if (centerX >= pb.Left && centerX <= pb.Right && centerY >= pb.Top && centerY <= pb.Bottom)
            {
                Program.Game.timer_move.Stop();
                damage = enemy.attack - defense;
                /*currentHealth -= (enemy.attack - defense);*/
                pb.Text = name + "\n" + currentHealth + "/" + MaxHealth + "\n" + currentCD;
            }
        }
    }
}
