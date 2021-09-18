using System;
using System.Collections; 
using System.Text; 


namespace Roleplay
{
    public class Elf
    {
        private string id;
        private string name;
        private double strength;
        private double defense;
        private double MaxHealth;
        private double health;
        private ArrayList inventory;

        public Elf(string name, double strength, double defense, double health)
        {
            this.id = "Elf";
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.MaxHealth = health;
            this.Health = health;
            this.inventory = new ArrayList();
        }

        public string ID
        {
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name=value;
            }
        }
        public double Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                this.strength=value;
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

        public ArrayList Inventory
        {
            get
            {
                return this.inventory;
            }
            set
            {
                this.inventory=value;
            }
        }

        public void AddItem(Item item)
        {
            if(item.Restriction.Equals(this.ID) || item.Restriction.Equals(""))
            {
                this.Inventory.Add(item);
                Console.WriteLine($"{this.Name} agarró el objeto {item.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} no cumple con los requisitos de clase de {item.Name}");
            }
        }

        public void RemoveItem(Item item)
        {
                    this.Inventory.Remove(item);
        }

        public double AttackStat()
        {
            double attackDamage = this.Strength;
            foreach (Item item in this.Inventory)
            {
                attackDamage += item.AttackStat;
            }
            return attackDamage;
        }

        public double DefenseStat()
        {
            double defense = this.Defense;
            foreach (Item item in this.Inventory)
            {
                defense += item.DefenseStat;
            }
            return defense;
        }

        public string ShowStats()
        {
            StringBuilder stringBuilder = new StringBuilder($"El personaje {this.Name} tiene:\n");
            stringBuilder.Append($"{AttackStat()} de ataque\n");
            stringBuilder.Append($"{DefenseStat()} de defensa");
            return stringBuilder.ToString();
        }

        public void Attack(Enemy enemy)
        {
            if(enemy.Health > 0)
            {
                double dmg = 0;
                if(this.AttackStat() >= enemy.Defense)
                {
                    dmg = this.AttackStat() - enemy.Defense;
                }
                if(dmg < enemy.Health)
                {
                    enemy.Health -= dmg;
                }
                else
                {
                    enemy.Health = 0;
                }
                if(enemy.Health > 0)
                {
                    Console.WriteLine($"El enemigo sufrio {dmg} de daño, vida restante {enemy.Health}");
                }
                else
                {
                    Console.WriteLine($"El enemigo sufrio {dmg} de daño y murió, RIP");
                }
            }
            else
            {
                Console.WriteLine("Ese enemigo ya está muerto");
            }
        }

        public void Heal()//Aca se cura elmelfo en base a su vida maxima, es una caracteristica propia del elfo por su raza
        {
            this.Health = this.MaxHealth;
            Console.WriteLine($"Tu vida ahora es {this.MaxHealth}");
        }
    }
}

