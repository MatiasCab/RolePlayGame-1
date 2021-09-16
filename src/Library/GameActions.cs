using System;

namespace Program
{
    public class GameActions
    {
        public GameActions()
        {
            Console.WriteLine($"Elija una raza con la cual jugar(Wizard,Dwarf,Elves)");
            dynamic personaje=ChooseCharacter();
            Console.WriteLine($"Elija una raza con la cual luchar(Wizard,Dwarf,Elves)\nRaza:");
            dynamic oponente=ChooseCharacter();
            GameLogic(personaje,oponente);
        }

        static dynamic ChooseCharacter()
        {
            while(true)
            {
                Console.Write("Raza:");
                string raza=Console.ReadLine();
                if (raza == "Wizard")
                {
                    Wizard mago = new Wizard ("Gandalf",10,10,150,1);
                    Item libro = new Item("Baston blanco",10,2);
                    Item capa = new Item("Capa protectora",0,15);
                    mago.AddItem(libro);
                    mago.AddItem(capa);
                    return mago;
                }

                if (raza == "Dwarf")
                {
                    Dwarf enano = new Dwarf("Enano de boca",25,25,100);
                    Item arma = new Item("Maza común",5,0);
                    Item escudo = new Item("Escudo grande",0,15);
                    enano.AddItem(arma);
                    enano.AddItem(escudo);
                    return enano;
                }
                if (raza == "Elves")
                {
                    Elves elfo = new Elves("Legolas",20,20,200);
                    Item arco = new Item("Arco largo",20,0);
                    Item armadura = new Item("Armadura ligera",0,10);
                    elfo.AddItem(arco);
                    elfo.AddItem(armadura);
                    return elfo;
                }
                Console.WriteLine("Invalid Data");
            }
            

        }

        static void Atacar(dynamic atacante, dynamic oponente,double defensa)
        {
            if  (atacante.Strength-defensa>0)
            {
            oponente.ReciveDamage((atacante.Strength-defensa));
            Console.WriteLine($"{atacante.Name} le quito {atacante.Strength-defensa} de vida a {oponente.Name} (vida restante {oponente.Health})");
            }else
            {
                Console.WriteLine($"La defensa de {oponente.Name} es muy alta, no recivio daño");
            }
        }
        static void Curar(dynamic personaje)
        {
            Elves elfo = new Elves("Petreus",20,20,200);
            elfo.CureCharacter(personaje);
        }

        static string PlayerActions()
        {
            while (true)
            {
            Console.WriteLine("Haga un movimiento (Atacar,Defender,Recivir curacion(solo una por partida)):");
            string accion=Console.ReadLine();
            if (accion=="Atacar" || accion=="Defender" || accion=="Recivir curacion")
            {
                return accion;
            }else
            {
                Console.WriteLine("Invalid data");
            }
            }
        }
        
        static string OponentActions()
        {
            Random random=new Random();
            int numero =random.Next(1,3);
            switch (numero)
            {
                case (1):
                return "Atacar";

                default :
                return "Defender";
            }
        }

        static void GameLogic(dynamic jugador, dynamic oponente)
        {
            bool FinDelJuego = false;
            while (!FinDelJuego)
            {
                string accionJugador = PlayerActions();
                string accionOponente = OponentActions();
                if (accionJugador=="Atacar" && accionOponente=="Defender")
                {
                    Atacar(jugador,oponente,oponente.Defense*0.70);
                    if (oponente.Health <=0)
                    {
                        FinDelJuego=true;
                    }
                }
                if (accionJugador=="Atacar" && accionOponente=="Atacar")
                {
                    Atacar(jugador,oponente,0);
                    Atacar(oponente,jugador,0);
                    if (oponente.Health <=0 || jugador.Health<=0)
                    {
                        FinDelJuego=true;
                    }
                }
                if (accionJugador=="Defender" && accionOponente=="Atacar")
                {
                    Atacar(oponente,jugador,jugador.Defense*0.70);
                    if (jugador.Health <=0)
                    {
                        FinDelJuego=true;
                    }
                }
                if (accionJugador=="Defender" && accionOponente=="Defender")
                {
                    Console.WriteLine("Ambos se defendieron");
                }
                if (accionJugador=="Recivir curacion")
                {
                    Curar(jugador);
                    Console.WriteLine($"{jugador.Name} se curo");
                }
            }
        }
    } 
}