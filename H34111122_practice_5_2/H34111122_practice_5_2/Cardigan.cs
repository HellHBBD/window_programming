namespace H34111122_practice_5_2
{
    internal class Cardigan : MainCharacter
    {
        public Cardigan(int index)
        : base(index)
        {
            reset();
        }

        public override void reset()
        {
            base.reset();
            name = "Cardigan";
            MaxHealth = currentHealth = 2130;
            MaxCD = currentCD = 20; //TODO 20
            attack = 305;
            defense = 475;
            cost = 18;
            pb.Text = name + "\n" + cost;
        }

        public override void skill()
        {
            currentHealth += (int)(0.4 * MaxHealth);
            if (currentHealth > MaxHealth)
            {
                currentHealth = MaxHealth;
            }
            pb.BackColor = Color.Gray;
            currentCD = MaxCD;
            show();
        }
    }
}
