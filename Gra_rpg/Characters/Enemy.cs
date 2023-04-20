using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Characters
{
   public class Enemy:Character
    {
        public string Loot { get; set; }
        Random rnd = new Random();

        public Enemy(string name, string description, int health, int attack_points,string loot)
            :base(name, description, health, attack_points)
        {
            this.Loot = loot;
        }
        public void Attack(Player player,int stage)
        {
            if (stage==1)
            {
                Attack_points = rnd.Next(1,5);
                player.Health-=Attack_points;
                Console.WriteLine($"{Name} attacks {player.Name} and deals {Attack_points} damage!");
            }

            if (stage == 2)
            {
                Attack_points = rnd.Next(2, 7);
                player.Health -= Attack_points;
                Console.WriteLine($"{Name} attacks {player.Name} and deals {Attack_points} damage!");
            }

            if (stage == 3)
            {
               int a = rnd.Next(1, 5);
                if (a >=8)
                {
                    Attack_points = rnd.Next(16, 25);
                    player.Health -= Attack_points;
                    Console.WriteLine($"{Name} attacks {player.Name} and deals {Attack_points} damage!");
                }
                else
                {
                    Attack_points = rnd.Next(6, 15);
                    player.Health -= Attack_points;
                    Console.WriteLine($"{Name} attacks {player.Name} and deals {Attack_points} damage!");
                }
                
            }
        }
        public void Look()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine($"{Health} health");
        }
    }
}
