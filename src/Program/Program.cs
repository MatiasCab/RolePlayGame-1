using System;
using Roleplay;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Item arma = new Item("Broken Hero Sword",35,0,"");
            Item escudo = new Item("Greatshield of Artorias",0,45,"Paladin");
            Item liquadora = new Item("Liquadora de tu vieja",0,0,"Paladin");
            Item martillo = new Item("Martillo de Herrero",35,5,"Dwarf");
            Item arco = new Item("Belthronding", 9000,0,"Elf");
            

            string eleccioningame = "";
            string nombrepersonaje = "";

            Thread.Sleep(800);
            Console.WriteLine("Hola, Bienvenido a nuestro minijuego de simulador de batalla.");
            Thread.Sleep(6000);
            Console.WriteLine("Inserte el numero de la clase con la que le gustaria jugar:\n1: Paladin\n2: Enano\n3: Elfo");
            Thread.Sleep(3000);
            string eleccion = Console.ReadLine(); 
            
            
            if (eleccion == "1")
            {
                Console.WriteLine("¿Como te gustaria que se llame tu paladin?");
                Thread.Sleep(3000);
                nombrepersonaje = Console.ReadLine();
                
                Paladin personaje = new Paladin(nombrepersonaje,35,55,175);
                Enemy enemy = new Enemy();
                Console.WriteLine("Recuerda que como jugador tienes la posibilidad de equiparte items dependiendo de tu clase, cuidado que los enemigos son bastante fuertes");

                while (personaje.Health > 0 && enemy.Health > 0)
                {
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("1: Atacar\n2: Revisar tu inventario");
                    eleccioningame = Console.ReadLine();
                    Thread.Sleep(500);

                    if (eleccioningame == "1")
                    {
                        personaje.Attack(enemy);
                    }
                    if (eleccioningame == "2")
                    {
                        Console.WriteLine("Tienes varias cosas de aventuras anteriores:");
                        Console.WriteLine($"1: {arma.Name}, aumentando tu estadistica de ataque en {arma.AttackStat} y de defensa en {arma.DefenseStat}. Restriccion: {arma.Restriction}");
                        Console.WriteLine($"2: {escudo.Name}, aumentando tu estadistica de ataque en {escudo.AttackStat} y de defensa en {escudo.DefenseStat}. Restriccion: {escudo.Restriction}");
                        Console.WriteLine($"3: {liquadora.Name}, aumentando tu estadistica de ataque en {liquadora.AttackStat} y de defensa en {liquadora.DefenseStat}. Restriccion: {liquadora.Restriction}");
                        Console.WriteLine($"4: {martillo.Name}, aumentando tu estadistica de ataque en {martillo.AttackStat} y de defensa en {martillo.DefenseStat}. Restriccion: {martillo.Restriction}");
                        Console.WriteLine($"4: {arco.Name}, aumentando tu estadistica de ataque en {arco.AttackStat} y de defensa en {arco.DefenseStat}. Restriccion: {arco.Restriction}");

                        Thread.Sleep(3000);
                        Console.WriteLine("¿Quieres equiparte alguna de ellas?");
                        Console.WriteLine("1: Si\n2: No");
                        eleccioningame = Console.ReadLine();

                        if (eleccioningame == "1")
                        {
                            Console.WriteLine("Ingrese el numero de cual te quieras equipar");
                            eleccioningame = Console.ReadLine();

                            if (eleccioningame == "1")
                            {
                            personaje.AddItem(arma);
                            }
                            if (eleccioningame == "2")
                            {
                            personaje.AddItem(escudo);
                            }
                            if (eleccioningame == "3")
                            {
                            personaje.AddItem(liquadora);
                            }
                            if (eleccioningame == "4")
                            {
                            personaje.AddItem(martillo);
                            }
                            if (eleccioningame == "5")
                            {
                            personaje.AddItem(arco);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ok");
                        }
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine("Termino tu turno");
                    Thread.Sleep(3500);
                    
                    if (enemy.Health > 0)
                    {
                        enemy.AttackPaladin(personaje);
                    }
                    Thread.Sleep(3500);

                }
                Console.WriteLine("Fin del juego");
            }
            
            if (eleccion == "2")
            {
                Console.WriteLine("¿Como te gustaria que se llame tu enano?");
                Thread.Sleep(3000);
                nombrepersonaje = Console.ReadLine();
                
                Dwarf personaje = new Dwarf(nombrepersonaje,25,25,300);
                Enemy enemy = new Enemy();
                Console.WriteLine("Recuerda que como jugador tienes la posibilidad de equiparte items dependiendo de tu clase, cuidado que los enemigos son bastante fuertes");

                while (personaje.Health > 0 && enemy.Health > 0)
                {
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("1: Atacar\n2: Revisar tu inventario");
                    eleccioningame = Console.ReadLine();
                    Thread.Sleep(500);

                    if (eleccioningame == "1")
                    {
                        personaje.Attack(enemy);
                    }
                    if (eleccioningame == "2")
                    {
                        Console.WriteLine("Tienes varias cosas de aventuras anteriores:");
                        Console.WriteLine($"1: {arma.Name}, aumentando tu estadistica de ataque en {arma.AttackStat} y de defensa en {arma.DefenseStat}. Restriccion: {arma.Restriction}");
                        Console.WriteLine($"2: {escudo.Name}, aumentando tu estadistica de ataque en {escudo.AttackStat} y de defensa en {escudo.DefenseStat}. Restriccion: {escudo.Restriction}");
                        Console.WriteLine($"3: {liquadora.Name}, aumentando tu estadistica de ataque en {liquadora.AttackStat} y de defensa en {liquadora.DefenseStat}. Restriccion: {liquadora.Restriction}");
                        Console.WriteLine($"4: {martillo.Name}, aumentando tu estadistica de ataque en {martillo.AttackStat} y de defensa en {martillo.DefenseStat}. Restriccion: {martillo.Restriction}");
                        Console.WriteLine($"5: {arco.Name}, aumentando tu estadistica de ataque en {arco.AttackStat} y de defensa en {arco.DefenseStat}. Restriccion: {arco.Restriction}");

                        Thread.Sleep(3000);
                        Console.WriteLine("¿Quieres equiparte alguna de ellas?");
                        Console.WriteLine("1: Si\n2: No");
                        eleccioningame = Console.ReadLine();

                        if (eleccioningame == "1")
                        {
                            Console.WriteLine("Ingrese el numero de cual te quieras equipar");
                            eleccioningame = Console.ReadLine();

                            if (eleccioningame == "1")
                            {
                            personaje.AddItem(arma);
                            }
                            if (eleccioningame == "2")
                            {
                            personaje.AddItem(escudo);
                            }
                            if (eleccioningame == "3")
                            {
                            personaje.AddItem(liquadora);
                            }
                            if (eleccioningame == "4")
                            {
                            personaje.AddItem(martillo);
                            }
                            if (eleccioningame == "5")
                            {
                            personaje.AddItem(arco);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ok");
                        }
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine("Termino tu turno");
                    Thread.Sleep(3500);
                    
                    if (enemy.Health > 0)
                    {
                        enemy.AttackDwarf(personaje);
                    }
                    Thread.Sleep(3500);

                }
                Console.WriteLine("Fin del juego");
            }

            if (eleccion == "3")
            {
                Console.WriteLine("¿Como te gustaria que se llame tu elfo?");
                Thread.Sleep(3000);
                nombrepersonaje = Console.ReadLine();
                
                Elf personaje = new Elf(nombrepersonaje,50,30,150);
                Enemy enemy = new Enemy();
                Console.WriteLine("Recuerda que como jugador tienes la posibilidad de equiparte items dependiendo de tu clase, cuidado que los enemigos son bastante fuertes");

                while (personaje.Health > 0 && enemy.Health > 0)
                {
                    Console.WriteLine("¿Que quieres hacer?");
                    Console.WriteLine("1: Atacar\n2: Revisar tu inventario\n3: Curarte");
                    eleccioningame = Console.ReadLine();
                    Thread.Sleep(500);

                    if (eleccioningame == "1")
                    {
                        personaje.Attack(enemy);
                    }
                    if (eleccioningame == "2")
                    {
                        Console.WriteLine("Tienes varias cosas de aventuras anteriores:");
                        Console.WriteLine($"1: {arma.Name}, aumentando tu estadistica de ataque en {arma.AttackStat} y de defensa en {arma.DefenseStat}. Restriccion: {arma.Restriction}");
                        Console.WriteLine($"2: {escudo.Name}, aumentando tu estadistica de ataque en {escudo.AttackStat} y de defensa en {escudo.DefenseStat}. Restriccion: {escudo.Restriction}");
                        Console.WriteLine($"3: {liquadora.Name}, aumentando tu estadistica de ataque en {liquadora.AttackStat} y de defensa en {liquadora.DefenseStat}. Restriccion: {liquadora.Restriction}");
                        Console.WriteLine($"4: {martillo.Name}, aumentando tu estadistica de ataque en {martillo.AttackStat} y de defensa en {martillo.DefenseStat}. Restriccion: {martillo.Restriction}");
                        Console.WriteLine($"5: {arco.Name}, aumentando tu estadistica de ataque en {arco.AttackStat} y de defensa en {arco.DefenseStat}. Restriccion: {arco.Restriction}");

                        Thread.Sleep(3000);
                        Console.WriteLine("¿Quieres equiparte alguna de ellas?");
                        Console.WriteLine("1: Si\n2: No");
                        eleccioningame = Console.ReadLine();

                        if (eleccioningame == "1")
                        {
                            Console.WriteLine("Ingrese el numero de cual te quieras equipar");
                            eleccioningame = Console.ReadLine();

                            if (eleccioningame == "1")
                            {
                            personaje.AddItem(arma);
                            }
                            if (eleccioningame == "2")
                            {
                            personaje.AddItem(escudo);
                            }
                            if (eleccioningame == "3")
                            {
                            personaje.AddItem(liquadora);
                            }
                            if (eleccioningame == "4")
                            {
                            personaje.AddItem(martillo);
                            }
                            if (eleccioningame == "5")
                            {
                            Console.WriteLine("No lo podes usar flaco");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ok");
                        }
                    }
                    if (eleccioningame == "3")
                    {
                        personaje.Heal();
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine("Termino tu turno");
                    Thread.Sleep(3500);
                    
                    if (enemy.Health > 0)
                    {
                        enemy.AttackElf(personaje);
                    }
                    Thread.Sleep(3500);

                }
                Console.WriteLine("Fin del juego");
            }
            
        }
    }
}
