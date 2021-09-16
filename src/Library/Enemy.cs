using System;

namespace Program
{
    public class Enemy
    {
        private double damage;
        private double defense;
        private double health;
        private bool alive;

        public Enemy()
        {
            this.Damage = 5;
            this.Defense = 5;
            this.Health = 30;
            this.Alive = true;
        }

        public double Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage=value;
            }
        }

        public double Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                this.defense=value;
            }
        }

        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health=value;
            }
        }

        public bool Alive
        {
            get
            {
                return this.alive;
            }
            set
            {
                this.alive=value;
            }
        }
    }

}