using System;
using System.Collections;
using System.Threading;


namespace Program
{
    public class Game
    {
        Dwarf enano;
        Wizard mago;
        ArrayList enemies;
        int players;

        public Game()
        {
            CreateEnemies();
        }
        public void Start()
        {
            bool playing = true;
            bool choosing = true;
            

            while(choosing)
            {
                Console.WriteLine("1 - Seleccione la cantidad de jugadores");
                this.Players = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Quiere jugar con {players} personaje/s? (y/n)");
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
                if (this.enemies.Count > 0 && this.Players > 0)
                {
                    if (!enano.Equals(null))
                    {
                        for (int i = 0; i < this.enemies.Count; i++)
                        {
                            int j = i+1;
                            Thread.Sleep(800);
                            Console.WriteLine($"{i} - Atacar enemigo numero {j}");
                        }
                        int enemySelected = Convert.ToInt32(Console.ReadLine());
                        Thread.Sleep(1200);
                        Enemy enemy = (Enemy)this.enemies[enemySelected];
                        enano.Attack(enemy);
                        if(enemy.Health <= 0)
                        {
                            this.enemies.Remove(enemy);
                        }
                    }

                    if (this.enemies.Count > 0)
                    {
                        for (int i = 0; i < this.enemies.Count; i++)
                        {
                            Thread.Sleep(800);
                            if (this.Players > 0)
                            {
                                Enemy enemy = (Enemy)this.enemies[i];
                                enemy.AttackDwarf(enano);
                            }
                            if(enano.Health <= 0)
                            {
                                this.Players -= 1;
                            }
                        }
                    }

                }
                else if (this.enemies.Count <= 0)
                {
                    playing = false;
                    Console.WriteLine("Ganaste");
                }
                else if (this.players <= 0)
                {
                    playing = false;
                    Console.WriteLine("Perdiste xD");
                }

            }


        }

        private void CreateChar()
        {
            Console.WriteLine("Seleccione raza");
            Console.WriteLine("1 - Enano\n2 - Mago");

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
                enano =  new Dwarf(name,strength,defense,health);
            }else if(character.Equals(2))
            {
                Console.WriteLine("Elija un nombre");
                string name = Console.ReadLine();
                Console.WriteLine("Elija la fuerza");
                double strength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Elija la defensa");
                double defense = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Elija la vida");
                double health = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Elija la cantidad de mana");
                double mana = Convert.ToDouble(Console.ReadLine());
                mago =  new Wizard(name,strength,defense,health,mana);
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

        public int Players
        {
            get
            {
                return this.players;
            }
            set
            {
                this.players=value;
            }
        }
    }
}