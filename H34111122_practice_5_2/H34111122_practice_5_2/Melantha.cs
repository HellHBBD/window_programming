namespace H34111122_practice_5_2
{
    internal class Melantha : MainCharacter
    {
        public Melantha(int index)
        : base(index)
        {
            reset();
        }

        public override void reset()
        {
            base.reset();
            name = "Shaw";
            MaxHealth = currentHealth = 1785;
            MaxCD = currentCD = 5;
            attack = 580;
            defense = 365;
            cost = 19;
            pb.Text = name + "\n" + cost;
        }

        public override void skill()
        {
            Enemy enemy = Program.Game.enemy;
            int centerX = enemy.pb.Left + enemy.size / 2;
            int centerY = enemy.pb.Top + enemy.size / 2;
            if ((centerX >= pb.Left - size && centerX <= pb.Right && centerY >= pb.Top && centerY <= pb.Bottom) || (centerX >= pb.Left && centerX <= pb.Right && centerY >= pb.Top - size && centerY <= pb.Bottom + size))
            {
                enemy.pb.Left -= size;
                pb.BackColor = Color.Gray;
                currentCD = MaxCD;
            }
        }
    }
}
