using Gra_rpg.Characters;
using Gra_rpg.Przedmioty;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Save_Load
{
    public class Save
    {
        public void Save_(Player player,ref int stage,Item sword,Item potion,ref int smth)
        {

            {
                FileStream saveFile = File.Create("savefile.txt");
                StreamWriter writer = new StreamWriter(saveFile);
                writer.WriteLine(player.Name);
                writer.WriteLine(player.Description);
                writer.WriteLine(player.Health);
                writer.WriteLine(player.Attack_points);
                writer.WriteLine(player.Mana);
                writer.WriteLine(stage);
                writer.WriteLine(smth+1);
                writer.WriteLine(sword.Value);
                writer.WriteLine(potion.Value);
                foreach (string item in player.Inventory)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
                saveFile.Close();
            }
        }
    }
}
