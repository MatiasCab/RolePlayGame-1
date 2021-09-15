using System;
using System.Collections;
using System.Text;

namespace Roleplay
{
    public class Wizard
    {
        private string name;
        private double ataque;
        private double defensa;
        private double mana;
        private double vida;
        private ArrayList inventario = new ArrayList{};

        public Wizard(string name, double vida, double ataque, double defensa, double mana, ArrayList inventario)
        {
            this.Name = name;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Mana = mana;
            this.Inventario = inventario;
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

        public double Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                this.vida = value;
            }
        }

        public double Ataque
        {
            get
            {
                return this.ataque;
            }
            set
            {
                this.ataque = value;
            }
        }
        
        public double Defensa
        {
            get
            {
                return this.defensa;
            }
            set
            {
                this.defensa = value;
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
                this.mana = value;
            }
        }

        public ArrayList Inventario
        {
            get
            {
                return this.inventario;
            }
            set
            {
                foreach (InventoryElements item in Inventory.WizardInventory)
                {
                    foreach (string element in value)
                    {
                        if (item.Name == element)
                        {
                            this.inventario.Add(item);
                            this.Ataque = this.Ataque + item.Ataque;
                            this.Defensa = this.Defensa + item.Defensa;
                            this.Mana = this.Mana + item.Mana;
                        }
                    }
                }
            }
        }

        public string GetStatus()
        {
            StringBuilder equipament= new StringBuilder();
            foreach (InventoryElements item in this.Inventario)
            {
                equipament.Append(item.Name+"("+item.Tipo+")"+"\n           ");
            }
            return $"Clase:Wizard\nNombre:{this.Name}\nVida:{this.Vida}\nAtaque:{this.Ataque}\nDefensa:{this.Defensa}\nMana:{this.Mana}\nInventario:{equipament}";
        }

        public StringBuilder GetInventarySpecifications()
        {
            StringBuilder inventario= new StringBuilder();
            foreach (InventoryElements item in this.Inventario)
            {
                inventario.Append($"\nNombre:{item.Name}\nTipo:{item.Tipo}\nAtaque:{item.Ataque}\nDefensa:{item.Defensa}\nMana:{item.Mana}\n\n{item.Descripcion}\n");
            }
            return inventario;
        }
}
}