using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf enano = new Dwarf("Enano de boca",25,25,100);
            Item arma = new Item("Maza común",5,0);
            Item escudo = new Item("Escudo grande",0,15);
            enano.AddItem(arma);
            enano.AddItem(escudo);

            Wizard mago = new Wizard ("Gandalf",500,10,150,1);
            Item libro = new Item("Baston blanco",10,2);
            Item capa = new Item("Capa protectora",0,15);
            mago.AddItem(libro);
            mago.AddItem(capa);

            Elves elfo = new Elves("Legolas",20,20,200);
            Item arco = new Item("Arco largo",20,0);
            Item armadura = new Item("Armadura ligera",0,10);
            elfo.AddItem(arco);
            elfo.AddItem(armadura);
            GameActions juego1 = new GameActions();

        }
}
    }