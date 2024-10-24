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
            name = "Melantha";
            MaxHealth = currentHealth = 2745;
            MaxCD = currentCD = 40;
            attack = 738;
            defense = 155;
            cost = 15;
            pb.Text = name + "\n" + cost;
        }

        public override void skill()
        {
            pb.BackColor = Color.Gray;
            currentCD = MaxCD;
        }
    }
}
