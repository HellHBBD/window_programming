﻿namespace H34111122_practice_5_2
{
    internal class Cardigan : MainCharacter
    {
        public Cardigan(int index)
        : base(index)
        {
            name = "Cardigan";
            MaxHealth = currentHealth = 2130;
            attack = 305;
            defense = 475;
            cost = 18;
            pb.Text = name + "\n" + cost;
        }
    }
}
