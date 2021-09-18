using System;

namespace Program
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
}