using System;

namespace Program
{
    public class Enemy
    {
        private double damage;
        private double defense;
        private double health;

        public Enemy()
        {
            this.Damage = 5;
            this.Defense = 5;
            this.Health = 30;
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

        public void AttackDwarf(Dwarf enano)
        {
            if(enano.Health > 0)
            {
                double dmg = 0;
                if(this.Damage >= enano.Defense)
                {
                    dmg = this.Damage - enano.Defense;
                }
                if(dmg < enano.Health)
                {
                    enano.Health -= dmg;
                }
                else
                {
                    enano.Health = 0;
                }
                if(enano.Health > 0)
                {
                    Console.WriteLine($"{enano.Name} sufrio {dmg} de daño, vida restante {enano.Health}");
                }
                else
                {
                    Console.WriteLine($"{enano.Name} sufrio {dmg} de daño y murió, RIP");
                }
            }
            else
            {
                Console.WriteLine($"{enano.Name} ya está muerto");
            }
        }

    }

}