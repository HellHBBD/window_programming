namespace H34111122_practice_5_2
{
    internal class Enemy : Character
    {
        public bool canMove = true;

        public Enemy()
        : base()
        {
            x = Program.Game.xstart + Program.Game.size * 5 / 6;
            y = Program.Game.ystart + Program.Game.size * 7 / 6;
            size = Program.Game.size * 2 / 3;

            currentHealth = MaxHealth = 1500;
            attack = 500;
            defense = 200;

            pb.BackColor = Color.Yellow;
            pb.Location = new Point(x, y);
            pb.Size = new Size(size, size);
            pb.Text = currentHealth.ToString();
        }

        public void move()
        {
            pb.Left += 3;
        }
    }
}
