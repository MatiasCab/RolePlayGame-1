using System;
using System.Collections;

namespace Program
{
    public class Game
    {
        ArrayList playersInGame;
        ArrayList enemies;

        public Game()
        {
            this.playersInGame = new ArrayList();
            CreateEnemies();
            
        }
        public void Start()
        {
            bool playing = true;
            bool choosing = true;
            int players;
            

            while(choosing)
            {
                Console.WriteLine("1 - Seleccione la cantidad de jugadores\n");
                players = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Quiere jugar con {players} personajes? (y/n)\n");
                string confirm = Console.ReadLine();
                if(confirm.Equals("y"))
                {
                    choosing = false;
                    for (int i = 0; i < players; i++)
                    {
                        CreateChar();
                    }
                }
                else if(!confirm.Equals("n"))
                {
                    Console.WriteLine("Input no valido");
                }
            }


            while(playing)
            {
                Console.WriteLine($"Hay {this.enemies.Count} enemigos");
                
            }


        }

        private void CreateChar()
        {
            Console.WriteLine("Seleccione raza");
            Console.WriteLine("1 - Enano\n");

            int character = Convert.ToInt32(Console.ReadLine());

            if(character.Equals(1))
            {
                Console.WriteLine("Elija un nombre");
                string name = Console.ReadLine();
                Console.WriteLine("Elija la fuerza");
                double strength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Elija la defensa");
                double defense = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Elija la vida");
                double health = Convert.ToDouble(Console.ReadLine());
                Dwarf enano =  new Dwarf(name,strength,defense,health);
                this.playersInGame.Add(enano);
            }
        }

        private void CreateEnemies()
        {
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();
            this.enemies = new ArrayList();
            this.enemies.Add(e1);
            this.enemies.Add(e2);
        }
    }
}