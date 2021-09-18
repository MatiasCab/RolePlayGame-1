using System;
using System.Collections; 
using System.Text; 


namespace Roleplay
{
    public class Elfos 
    {
        private string id; 
        private string name; 
        private double health; 
        private double defense; 
        private double attack;
        private ArrayList inventory; 

        public Elfos(string name, double health, double defense, double attack)
        {
            this.id= "Elfos"; 
            this.Name= name; 
            this.Health= health; 
            this.Defense= defense; 
            this.Attack= attack; 
            this.Inventory= new ArrayList(); 
            
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
             this.name = value;    
            }
        }
        public int Health
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
        public int Defense
        {
            get
            {
                return this.defense; 
            }
            set 
            {
                this.defense= value; 
            }
        }
       
        public int Attack
        {
            get
            {
                return this.attack; 
            }
            set 
            {
                this.attack= value; 
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
                this.inventory = value; 
            }
        }
        public void AddItem(Item item)
        {
            if(item.Restriction.Equeals(this.ID)|| item.Restiction.Equals(""))
            {
                this.Inventory.Add(item); 
                Console.WriteLine(${this.Name} agarro el objeto {item.Name});
            }
            else
            {
                
                Cosole.WriteLine(${this.Name} no cumple con los requisitos de clase de {item.Name});
                
            }
        }

        public void RemoveItem(Item item)
        {
            foreach (Item i in this.Inventory)
            {
                if(i.Equals(item))
                {
                    this.Inventory.Remove(i); 
                }
            }
        }
        public double DefenseStat()
        {
            double defense=this.Defense; 
            foreach (Item item in this.Inventory)
            {
                defense += item.DefenseStat; 
            }
            return defense; 
        }
        public double AttackStat()
        {
            double attackDamage = this.attack; 
            foreach(Item item in this.Inventory)
            {
                attackDamage += itemAttackStat; 
            }
            return attackDamage; 
        }
        public string ShowStats()
        {
            StringBuilder stringBuilder = new StringBuilder ($"El personaje {this.Name} tiene \n"); 
            stringBuilder.Append($"{DefenseStat()} de defensa\n"); 
            return stringBuilder.ToString(); 
        }
        public void Attack(Enemy enemy)
        {
            if (enemy.Alive)
            {
                double dmg=0; 
                if (this.AttackStat()>=enemy.Defense)
                {
                    dmg = this.AttackStat()-enemy.Defense; 
                }
                if(dmg < enemy.Health)
                {
                    enemy.Health -= dmg;
                }
                else
                {
                    enemy.Health = 0;
                    enemy.Alive = false;
                }
                if(enemy.Alive)
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

