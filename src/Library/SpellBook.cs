using System;
using System.Text;
using System.Collections;

namespace Program
{
    /*Se hizo una clase spellbook, para el item del libro de hechizos,ya que este es un item especial que posee nuevas mecanicas y 
    caracteristicas*/
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
            set 
            {
                this.restriction=value;
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

        public void AddSpells(Spells spell)
        {
            this.Spells.Add(spell);
            this.AttackStat += spell.AttackStat;
            this.DefenseStat += spell.DefenseStat;

        }

        public void RemoveSpells(Spells spell)
        {
            foreach (var item in this.spells)
            {
                if (spell.Equals(item))
                {
                    this.spells.Remove(item);
                    this.AttackStat -= spell.AttackStat;
                    this.DefenseStat -= spell.DefenseStat;
                }
            }
        }
        public int NumberOfSpells()
        {
            int hechizos = 0;
            foreach (Spells item in this.Spells)
            {
                hechizos++;
            }
            return hechizos;
        }
    }
}