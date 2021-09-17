using System;
using Roleplay;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Paladin paladin1 = new Paladin("Arthur",);
            Console.WriteLine($"Hello, my name is {paladin1.Name} and I have a base health of {paladin1.Health}, I also have a defence of {paladin1.Defence} and my base damage is {paladin1.BaseDamage}");
            Durendal Durendal1 = new Durendal();
            Console.WriteLine(" ");
            Console.WriteLine($"This is the {Durendal1.WeaponType} named {Durendal1.Name}, it's current durability is {Durendal1.Durability} and it seams to multiply the Base Damage {Durendal1.BaseDamageMultiplier} times, it also seems to have somthing inscribed on it");
            Console.WriteLine(" ");
            Console.WriteLine($"It says,\n\"{Durendal1.Description}\"");
            Greatshield_of_Artorias Greatshield_of_Artorias1 = new Greatshield_of_Artorias();
            Console.WriteLine(" ");
            Console.WriteLine($"This is the {Greatshield_of_Artorias1.WeaponType} named {Greatshield_of_Artorias1.Name}, it's current durability is... strange its current durability is {Greatshield_of_Artorias1.Durability} but that is rather a high number, ignoring that it seams to add {Greatshield_of_Artorias1.Defence} defence to its wielder");
            Console.WriteLine(" ");
            Console.WriteLine($"It's description says,\n\"{Greatshield_of_Artorias1.Description}\" so thats why it durability was that high");
            */
            /*
            Item arma = new Item("Maza común",5,0);
            Item escudo = new Item("Escudo grande",0,15);        
            
            Console.WriteLine("Insert the number of the class you want to be:\n1: Paladin\n2:Cualquier otra");
            string eleccion = Console.ReadLine(); 
            
            
            if (eleccion == "1")
            {
                Paladin personaje = new Paladin("Protector del enano de boca",35,55,175);
                //Aca ponele que se crea un enemigo de la categoria enemy
                while (pensonaje.Health > 0 || enemy.Health > 0)
                {
                    Console.WriteLine(le damos las eleciones de lo que puede hacer);

                }
            }

            if (eleccion == "2")
            {
                Paladin personaje = new Paladin("Protector del enano de boca",35,55,175);
                //Aca ponele que se crea un enemigo de la categoria enemy
                while (pensonaje.Health > 0 || enemy.Health > 0)
                {
                    Console.WriteLine(le damos las elleciones de lo que puede hacer);

                }
            }
            //personaje.AddItem(arma);
            //personaje.AddItem(escudo);
            Console.WriteLine(personaje.ShowStats());
            

            Paladin personaje = new Paladin("Protector del enano de boca",25,25,100);
            Item arma = new Item("Maza común",5,0,"");
            Item escudo = new Item("Greatshield of Artorias",0,45,"Paladin");
            Enemy enemy = new Enemy();

            personaje.AddItem(arma);
            Thread.Sleep(5000);
            personaje.AddItem(escudo);
            Thread.Sleep(5000);
            Console.WriteLine(personaje.ShowStats());
            Thread.Sleep(5000);
            personaje.Attack(enemy);
            Thread.Sleep(5000);
            personaje.Attack(enemy);
            Thread.Sleep(5000);
            personaje.Attack(enemy);
            Thread.Sleep(5000);
            */
            Item arma = new Item("Broken Hero Sword",35,0,"");
            Item escudo = new Item("Greatshield of Artorias",0,45,"Paladin");
            Item liquadora = new Item("Liquadora de tu vieja",0,0,"Paladin");
            Item martillo = new Item("Martillo de Herrero",35,5,"Dwarf");
            

            string eleccioningame = "";
            string nombrepersonaje = "";

            Thread.Sleep(5000);
            Console.WriteLine("Hola, Bienvenido a nuestro minijuego de simulador de batalla.");
            Thread.Sleep(6000);
            Console.WriteLine("Inserte el numero de la clase con la que le gustaria jugar:\n1: Paladin\n2: Enano\n3:Cualquier otra cosa");
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
                Console.WriteLine("¿Como te gustaria que se llame tu paladin?");
                Thread.Sleep(3000);
                nombrepersonaje = Console.ReadLine();
                
                Dwarf personaje = new Dwarf(nombrepersonaje,35,55,175);
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
            
        }
    }
}
