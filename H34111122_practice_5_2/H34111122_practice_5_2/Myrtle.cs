﻿namespace H34111122_practice_5_2
{
    internal class Myrtle : MainCharacter
    {
        public Myrtle(int index)
        : base(index)
        {
            name = "Myrtle";
            MaxHealth = currentHealth = 1565;
            attack = 520;
            defense = 300;
            cost = 10;
            pb.Text = name + "\n" + cost;
        }
    }
}
