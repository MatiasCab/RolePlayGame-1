using System;

namespace Roleplay
{
    
    public class Item
    {
        private string name;
        private double attackStat;
        private double defenseStat;
        private string restriction;

        public Item(string name, double attackStat, double defenseStat, string restriction)
        {
            this.Name = name;
            this.AttackStat = attackStat;
            this.DefenseStat = defenseStat;
            if(restriction.Equals(""))
            {
                this.Restriction = "";
            }
            else
            {
                this.Restriction =  restriction;
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

        public double AttackStat
        {
            get
            {
                return this.attackStat;
            }
            set
            {
                this.attackStat=value;
            }
        }

        public double DefenseStat
        {
            get
            {
                return this.defenseStat;
            }
            set
            {
                this.defenseStat=value;
            }
        }

        public string Restriction
        {
            get
            {
                return this.restriction;
            }
            set
            {
                this.restriction=value;
            }
        }
    }

    
/*
    public class Durendal
    {
        private string name = "Durendal";
        
        private double durability = 100.0;

        private double baseDamageMultiplier = 5;

        private string weaponType = "Sword";

        private string description = $"This sword is an artifact from the past,\none that was wielded by the famous paladin Roland\nWhen wielded by a paladin all stats are doubled.";


        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public double Durability
        {
            get
            {
                return this.durability;
            }
            set
            {
                this.durability = value;
            }
        }

        public double BaseDamageMultiplier
        {
            get
            {
                return this.baseDamageMultiplier;
            }
        }

        public string WeaponType
        {
            get
            {
                return this.weaponType;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public Durendal()
        {
        }
    }

    public class Greatshield_of_Artorias
    {
        private string name = "Greatshield of Artorias";
        
        private double durability = 600.0;

        private double defence = 135;

        private string weaponType = "Greatshield";

        private string description = $"A big shield known for its durability and resistance.";



        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public double Durability
        {
            get
            {
                return this.durability;
            }
            set
            {
                this.durability = value;
            }
        }

        public double Defence
        {
            get
            {
                return this.defence;
            }
        }

        public string WeaponType
        {
            get
            {
                return this.weaponType;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public Greatshield_of_Artorias()
        {
        }
    }
*/
}
