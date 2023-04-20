using Gra_rpg.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Przedmioty
{
    public class Item:GameObject
    {
        public int Value { get; set; }
        public Item(string name,string description,int value)
            :base(name,description)
        {
            this.Value = value;
        }
        public void Healing(Player player,Item potion)
        {if (Value==25)
                    {
                Console.WriteLine($"{player.Name} use {potion.Name}");
                player.Health += Value;
                Console.WriteLine($"{Name} heals for {Value} Hp");
                Console.WriteLine($"After using the potion player have {player.Health} hp");
            }
        else  potion.Info();

        }
        public void Txt_sword(Item sword)
        {
            if (sword.Value == 0)
            {
                Console.WriteLine("1. Sword which add 5 dmg");
            }
            
            else
            {
                Console.WriteLine("1. ------");
            }

        }
        public void Txt_potion(Item potion)
        {
            if (potion.Value == 25) { Console.WriteLine($"2. Potion which heals you for {potion.Value} hp"); }
            else { Console.WriteLine("2. ------"); }
        }
        public void Info()
        {
            Console.WriteLine("You don't have this item anymore");
        }
    }
}
