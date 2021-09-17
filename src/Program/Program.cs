using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dwarf enano = new Dwarf("Enano de boca",25,25,100);
            Item arma = new Item("Maza común",5,0,"");
            Item escudo = new Item("Escudo grande",0,15,"");
            Enemy enemy = new Enemy();

            enano.AddItem(arma);
            enano.AddItem(escudo);
            Console.WriteLine(enano.ShowStats());
            enano.Attack(enemy);
            enano.Attack(enemy);
            enano.Attack(enemy);
            */
            Game game = new Game();
            game.Start();
        }
    }
}
