using System;

namespace Roleplay
{
    public class Paladin
    {
        private string name;
        
        private double health = 175;

        private double defence = 45;

        private double baseDamage = 25;

        

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

        public double Defence
        {
            get
            {
                return this.defence;
            }
            set
            {
                this.defence = value;
            }
        }

        public double BaseDamage
        {
            get
            {
                return this.baseDamage;
            }
            set
            {
                this.baseDamage = value;
            }
        }

        public Paladin(string name)
        {
            this.Name = name;
        }

        
    }
}