using System;
using System.Text;
using System.Collections;

namespace Roleplay
{
    public class Wizard
    {
        private string id;
        private string name;
        private double strength;
        private double defense;
        private double health;
        private double mana;
        private ArrayList inventory;

        public Wizard(string name, double strength, double defense, double health, double mana)
        {
            this.id = "Wizard";
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
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
        public double Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                this.mana=value;
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

        public void AddItem(dynamic item)
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

        public void RemoveItem(dynamic item)
        {
                this.Inventory.Remove(item);
        }
        

        public double AttackStat()  // Aca obtengo el ataque total del mago(el base mas lo que aporta los items), para esto se siguio el patron expert(el mago es el que tiene toda la informacion) 
        {
            double attackDamage = this.Strength;
            int spells = 0;
            foreach (dynamic item in this.Inventory)
            {
                if (item.GetType()==Type.GetType("Roleplay.SpellBook"))
                {
                    spells=item.NumberOfSpells();
                }
                    attackDamage += item.AttackStat;
            }
            attackDamage *= spells;
            return attackDamage;
        }

        public double DefenseStat()// Aca obtengo la defensa total del mago(el base mas lo que aporta los items), por el mismo patron
        {
            double defense = this.Defense; 
            int spells=0;
            foreach (dynamic item in this.Inventory)
            {
                if (item.GetType()==Type.GetType("Roleplay.SpellBook"))
                {
                    spells=item.NumberOfSpells();
                }
                defense += item.DefenseStat;
            }
            defense *= spells;
            return defense;
        }

        public string ShowStats()//Se arma un texto con los stats de defensa y ataque del mago(se sigui el patron expert, el mago es el que conoce esta informacion)
        {
            StringBuilder stringBuilder = new StringBuilder($"El personaje {this.Name} tiene:\n");
            stringBuilder.Append($"{AttackStat()} de ataque\n");
            stringBuilder.Append($"{DefenseStat()} de defensa");
            return stringBuilder.ToString();
        }

/* Metodo para atacar a un enemigo, como es el mago el que conoce todas las caracteristicas necesarioas para atacar
el es el responsable de hacer la accion de atacr, ademas, si se le quieren agregar mas caracteristicas a su modo de 
ataque, solo se tendria que modificar esta parte del codigo */

        public void Attack(Enemy enemy)
        {
            if(enemy.Health > 0)
            {
                double dmg = 0;
                if(this.AttackStat() >= enemy.Defense)
                {
                    dmg = this.AttackStat() - enemy.Defense;
                }
                if(dmg < enemy.Health )
                {
                    if (this.Mana - 10 >= 0)
                    {
                    enemy.Health -= dmg;
                    this.Mana -= 10;
                    }else
                    {
                        Console.WriteLine("Imposible atacar, mana insuficiente");
                    }

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
    }
}