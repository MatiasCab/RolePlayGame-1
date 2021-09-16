using System;
using System.Collections;
using System.Text;

namespace Program
{
    public class Elves
    {
        private string id;
        private string name;
        private double strength;
        private double defense;
        private double health;
        private ArrayList inventory;

        public Elves(string name, double strength, double defense, double health)
        {
            this.id="Elves";
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
            this.Defense = defense;
            this.Inventory = new ArrayList();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
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
                this.health = value;
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
                this.strength = value;
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
                this.defense = value;
            }
        }

        public string ID
        {
            get
            {
                return this.id;
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
            if(item.Restriction.Equals(this.ID) || item.Restriction.Equals(" "))
            {
                this.Inventory.Add(item);
                Console.WriteLine($"{this.Name} agarró el objeto {item.Name}");
                this.Strength+=item.AttackStat;
                this.Defense+=item.DefenseStat;
            }
            else
            {
                Console.WriteLine($"{this.Name} no cumple con los requisitos de clase de {item.Name}");
            }
        }

        public void RemoveItem(Item item)
        {
            foreach (Item i in this.Inventory)
            {
                if(i.Equals(item))
                {
                    this.Inventory.Remove(i);
                    this.Strength-=item.AttackStat;
                    this.Defense-=item.DefenseStat;
                }
            }
        }

        public string ShowStats()
        {
            StringBuilder stringBuilder = new StringBuilder($"El personaje {this.Name} tiene:\n");
            double attack = 0;
            double defense = 0;
            foreach (Item item in this.Inventory)
            {
                attack += item.AttackStat;
                defense += item.DefenseStat;
            }
            stringBuilder.Append($"{attack} de ataque\n");
            stringBuilder.Append($"{defense} de defensa");
            return stringBuilder.ToString();
        }

        public void ReciveDamage(double damage )
        {
            if (this.Health+this.defense>=damage)
            {
            this.Health -= (damage-this.defense);
            }
            else
            {
                this.Health = 0;
            }
            Console.WriteLine($"{this.Name} esta muerto");
        }

        public void CureCharacter(dynamic personaje)
        {
            if (personaje.Health>0)
            {
            personaje.Health += (this.Health*0.30);
            }
            else 
            {
                Console.WriteLine("El personaje esta muerto");
            }
        }
}
}