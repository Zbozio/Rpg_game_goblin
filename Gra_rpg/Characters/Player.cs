using Gra_rpg.Przedmioty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Characters
{
    public class Player : Character
    {
        public List<string> Inventory = new List<string>() { " " };


        public int Mana { get; set; }
        Random rdn = new Random();
        public Player(string name,string description,int health,int attack_points, List<string> inventory, int mana )
            :base(name, description, health,attack_points)
        {

            this.Inventory = inventory;
            this.Mana = mana;

        }
        public void Attack(Enemy enemy,Item sword)
        {
            Attack_points= rdn.Next(5,10)+sword.Value;
            enemy.Health -= Attack_points;
            Console.WriteLine($"{Name} attack {enemy.Name} and deals {Attack_points} damage!");
        }
        public void Pick_up(Item item)
        {
            if (item.Value == 0)
            {
                Console.WriteLine($"{Name} use {item.Name}");
                item.Value = 5;
            }
            else item.Info();
        }
        public void Mana_skill(Player player,Enemy enemy,Item ice)
        {
                if (player.Mana>=5)
            {
                player.Mana -= 5;
                enemy.Health -= ice.Value;
                Console.WriteLine($"{player.Name} use {ice.Name} and deals {ice.Value} damage!");
                player.Mana += 1;
            }
                else
            {
                Console.WriteLine("You dont have enough mana");
                player.Mana += 1;
            }
        }
        public void Stats(Player player)
        {
            Console.WriteLine($"You have {player.Health} hp");
            Console.WriteLine($"You have {player.Mana} mana");
        }
        public void ShowInventory()
        {
            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
