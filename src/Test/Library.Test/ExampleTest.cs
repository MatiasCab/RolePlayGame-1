using NUnit.Framework;

namespace Roleplay
{

    [TestFixture]
    public class ExampleTest
    {


        /*Este test se hizo para determinar si el libro de hechizos se agregaba de forma correcta al inventario del mago
        y si este(el libro) seteaba de forma correcta los stats del mago(ya que tanto el libro como los hechizos de este 
        afectaban algunos de sus stats
        [Test]
        public void TestAddSpellBook()
        {
            Wizard mago1=new Wizard("Gandalf",5,10,50,70);
            SpellBook libro1= new SpellBook("Grimorio comun",5,4,10);
            Spells spell1=new Spells("Bola de fuego",2,0);
            libro1.AddSpells(spell1);
            mago1.AddItem(libro1);
            double actual =mago1.AttackStat();
            double expected =10;
            Assert.AreEqual(expected,actual);
        }
        */
        [Test]
        public void Probandomodogrupal()
        {
            Item martillo = new Item("Martillo de Herrero",35,5,"Dwarf");

            Dwarf personaje = new Dwarf("enano de boca",1,999999,999999999);

            personaje.AddItem(martillo);
            double expected = 36;
            Assert.AreEqual(personaje.AttackStat(),expected);


        }
        


    }


}
