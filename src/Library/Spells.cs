using System;

namespace Program
{
    /*Se agrego una clase spara los hechizos, porque si se querian agregar nuevas mecanicas a los mismos
    solo se tenia que modficar esta clase, por lo que cumple el principio solid denresponsabilidad unica*/
    public class Spells 
    {
        private string name;
        private double attackStat;
        private double defenseStat;

        public  Spells(string name, double attackStat, double defenseStat)
        {
            this.Name = name;
            this.AttackStat = attackStat;
            this.DefenseStat = defenseStat;
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
    }
}