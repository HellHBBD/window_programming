namespace H34111122_practice_5_2
{
    internal class Melantha : MainCharacter
    {
        public Melantha(int index)
        : base(index)
        {
            name = "Melantha";
            MaxHealth = currentHealth = 2745;
            attack = 738;
            defense = 155;
            cost = 15;
            pb.Text = name + "\n" + cost;
        }
    }
}
