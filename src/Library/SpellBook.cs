using System;
using System.Text;
using System.Collections;

namespace Roleplay
{
    /*Se hizo una clase spellbook, para el item del libro de hechizos,ya que este es un item especial que posee nuevas mecanicas y 
    caracteristicas*/
    public class SpellBook
    {
        private string name;
        private double attackStat;
        private double defenseStat;
        private double mana;
        private string restriction = "Wizard";
        private ArrayList spells;

        public SpellBook(string name, double attackStat, double defenseStat, double mana)
        {
            this.Name = name;
            this.AttackStat = attackStat;
            this.DefenseStat = defenseStat;
            this.Mana = mana;
            this.Spells = new ArrayList();
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
                return this.restriction;
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
            if (this.Spells.Contains(spell))
            {
            this.Spells.Remove(spell);
            this.AttackStat -= spell.AttackStat;
            this.DefenseStat -= spell.DefenseStat;
            }else
            {
                Console.WriteLine("El hechizo no exite en este libro");
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