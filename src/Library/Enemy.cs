using System;

namespace Roleplay
{
    public class Enemy
    {
        private double damage;
        private double defense;
        private double health;
        private bool alive;

        public Enemy()
        {
            this.Damage = 75;
            this.Defense = 35;
            this.Health = 200;
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

        public void AttackPaladin(Paladin personaje)
        {
            if(personaje.Health > 0)
            {
                double dmg = 0;
                if(this.Damage >= personaje.Defense)
                {
                    dmg = this.Damage - personaje.Defense;
                }
                if(dmg < personaje.Health)
                {
                    personaje.Health -= dmg;
                }
                else
                {
                    personaje.Health = 0;
                }
                if(personaje.Health > 0)
                {
                    Console.WriteLine($"{personaje.Name} sufrio {dmg} de daño, vida restante {personaje.Health}");
                }
                else
                {
                    Console.WriteLine($"{personaje.Name} sufrio {dmg} de daño y murió, RIP");
                }
            }
            else
            {
                Console.WriteLine($"{personaje.Name} ya está muerto");
            }
        }
    

        public void AttackElf(Elf personaje)
        {
            if(personaje.Health > 0)
            {
                double dmg = 0;
                if(this.Damage >= personaje.Defense)
                {
                    dmg = this.Damage - personaje.Defense;
                }
                if(dmg < personaje.Health)
                {
                    personaje.Health -= dmg;
                }
                else
                {
                    personaje.Health = 0;
                }
                if(personaje.Health > 0)
                {
                    Console.WriteLine($"{personaje.Name} sufrio {dmg} de daño, vida restante {personaje.Health}");
                }
                else
                {
                    Console.WriteLine($"{personaje.Name} sufrio {dmg} de daño y murió, RIP");
                }
            }
            else
            {
                Console.WriteLine($"{personaje.Name} ya está muerto");
            }
        }
    }

}