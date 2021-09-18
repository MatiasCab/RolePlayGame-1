using NUnit.Framework;

namespace Test.Library
{

    [TestFixture]
    public class TestClass
    {

        /*Este test se hizo para determinar si efectivamente se agregaban de forma correcta los hecizos al libro
        de hechizos, al igual que para saber si el metdod de contar hechizos funcinaba de forma correcta
        */
        [Test]
        public void TestAddSpells()
        {
            SpellBook libro1= new SpellBook("Grimorio comun",5,4,10);
            libro1.AddSpells(new Spells("Bola de fuego",2,0));
            libro1.AddSpells(new Spells("Bola de hielo",3,0));
            libro1.AddSpells(new Spells("Bola de aire",5,0));
            int expected = 3;
            int actual = libro1.NumberOfSpells();
            Assert.AreEqual(expected,actual);
        }
        /*Este test se hizo para determinar si cuando se agregaba un hechizo al libro de hechizos, estos reajustaban de forma
        correcta los stats del libro, o si habia algun timpo de error*/
        [Test]
        public void TestRemoveSpells()
        {
            SpellBook libro1= new SpellBook("Grimorio comun",5,4,10);
            Spells spell1=new Spells("Bola de fuego",2,0);
            libro1.AddSpells(spell1);
            libro1.RemoveSpells(spell1);
            double actual =libro1.AttackStat();
            double expected =5;
            Assert.AreEqual(expected,actual);
        }
        /*Este test se hizo para determinar si el libro de hechizos se agregaba de forma correcta al inventario del mago
        y si este(el libro) seteaba de forma correcta los stats del mago(ya que tanto el libro como los hechizos de este 
        afectaban algunos de sus stats*/
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

    }


}