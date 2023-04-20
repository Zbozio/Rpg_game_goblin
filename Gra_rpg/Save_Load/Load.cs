using Gra_rpg.Characters;
using Gra_rpg.Przedmioty;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Save_Load
{
    public class Load
    {
        public void Load_(Player player ,ref int stage,ref int smth,Item sword,Item potion)
        {
            FileStream loadFile = File.OpenRead("savefile.txt");
            StreamReader reader = new StreamReader(loadFile);
            player.Name = reader.ReadLine();
            player.Description = reader.ReadLine();
            player.Health = int.Parse(reader.ReadLine());
            player.Attack_points = int.Parse(reader.ReadLine());
            player.Mana = int.Parse(reader.ReadLine());
            stage = int.Parse(reader.ReadLine());
            smth = int.Parse(reader.ReadLine());
            sword.Value = int.Parse(reader.ReadLine());
            potion.Value = int.Parse(reader.ReadLine());
            string inventoryString = reader.ReadLine();
            List<string> inventory = new List<string>();
            while (!string.IsNullOrEmpty(inventoryString))
            {
                inventory.Add(inventoryString);
                inventoryString = reader.ReadLine();
            }
            player.Inventory = inventory;
            Console.WriteLine("Game succesfully loaded!");
            Console.WriteLine("------------------------");
            reader.Close();
            loadFile.Close();
        }
    }
}
