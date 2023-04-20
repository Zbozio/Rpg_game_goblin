using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Przedmioty
{
    public class GameObject
    {

        public string Name {  get; set; }
        public string Description { get; set; }
       public GameObject(string name,string description)
        {
        this.Name = name;
        this.Description = description;
        }
        public void Menu()
        {

            Console.WriteLine("------------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Look at inventory");
            Console.WriteLine("3. Use an item");
            Console.WriteLine("4. Show info about an enemy");
            Console.WriteLine("5. Show my stats");
            Console.WriteLine("------------------------");
            Console.Write("> ");
        }
    }
}
