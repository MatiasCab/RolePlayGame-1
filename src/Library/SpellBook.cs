using System;
using System.Text;
using System.Collections;

namespace Program
{
    public class SpellBook
    {
        private string name;
        private double attackStat;
        private double defenseStat;
        private double mana;
        private string restriction;
        private ArrayList spells;

        public SpellBook(string name, double attackStat, double defenseStat, double mana)
        {
            this.Name = name;
            this.AttackStat = attackStat;
            this.DefenseStat = defenseStat;
            this.Mana = mana;
            this.Spells = new ArrayList();
            this.Restriction ="Wizard";
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
        public double AttackStat
        {
            get
            {
                return this.attackStat;
            }
            set
            {
                this.attackStat = value;
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
                this.defenseStat = value;
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
        public string Restriction
        {
            get
            {
                return this.Restriction;
            }
        }

        public ArrayList Spells
        {
            get
            {
                return this.spells;
            }
            set
            {
                this.spells = value;
            }
        }

        public void AddSpells(string spell)
        {
            this.Spells.Add(spell);
        }

        public void RemoveSpells(string spell)
        {
            foreach (var item in this.spells)
            {
                if (spell.Equals(item))
                {
                    this.spells.Remove(item);
                }
            }
        }
        public double NumberOfSpells()
        {
            double hechizos = 0;
            foreach (var item in this.Spells)
            {
                hechizos++;
            }
            return hechizos;
        }
    }
}