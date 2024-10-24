namespace H34111122_practice_5_2
{
    internal class Myrtle : MainCharacter
    {
        public Myrtle(int index)
        : base(index)
        {
            reset();
        }

        public override void reset()
        {
            base.reset();
            name = "Myrtle";
            MaxHealth = currentHealth = 1565;
            MaxCD = currentCD = 22; //TODO 22
            attack = 520;
            defense = 300;
            cost = 10;
            pb.Text = name + "\n" + cost;
        }

        public override void skill()
        {
            Program.Game.money += 14;
            if (Program.Game.money > 99)
            {
                Program.Game.money = 99;
            }
            Program.Game.label_money.Text = Program.Game.money.ToString();
            pb.BackColor = Color.Gray;
            currentCD = MaxCD;
        }
    }
}
