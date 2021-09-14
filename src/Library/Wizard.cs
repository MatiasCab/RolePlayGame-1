using System;
using System.Collections;

namespace Roleplay
{
    public class Wizard
    {
        private int ataque;
        private int defensa;
        private int mana;
        private int vida;
        private ArrayList inventario;

        public Wizard(int vida, int ataque, int defensa, int mana, ArrayList inventario )
        {
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Mana = mana;
            this.Inventario = inventario;
        }

        public int Vida
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

        public int Ataque
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
        
        public int Defensa
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

        public int Mana
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
                this.inventario = value;
            }
        }
    }   
}