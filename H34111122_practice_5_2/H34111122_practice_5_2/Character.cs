﻿namespace H34111122_practice_5_2
{
    internal class Character
    {
        public int x, y, size;
        public int MaxHealth, currentHealth, attack, defense, damage;
        public Button pb = new Button();

        public Character()
        {
            Program.Game.panel_game.Controls.Add(pb);
            pb.BringToFront();
        }

        public virtual void reset()
        {
            pb.Location = new Point(x, y);
        }
    }
}
