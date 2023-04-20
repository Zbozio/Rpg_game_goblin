using Gra_rpg.Characters;
using Gra_rpg.Przedmioty;
using Gra_rpg.Save_Load;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Stages
{
    public class Stage1
    {
        public void Stage(GameObject myGameObject,Game_loop game_loop,Player player,Enemy enemy,Item sword, Item ice,ref int stage,ref int count ,ref int counter,Item potion,Load lod,ref int smth)
        {
           
                
            

            myGameObject.Menu();
            var choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        game_loop.Game(player, enemy, sword, ice, stage,ref smth);
                        if (enemy.Health <= 0) stage += 1;
                    }
                    break;
                case 2:
                    player.ShowInventory();
                    break;

                case 3:
                    {
                        Console.WriteLine("What do you want to choose");
                        sword.Txt_sword(sword);
                        potion.Txt_potion(potion);
                        Console.WriteLine("3. --Exit--");
                        Console.Write("> ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1 && counter == 0)
                        {
                            player.Pick_up(sword);

                            counter++;
                        }
                        else if (choice == 2 && count == 0)

                        {
                            potion.Healing(player,potion);
                            potion.Value = 0 ;
                            count++;
                        }
                        else if (choice == 3)
                        {
                           
                        }
                            
                        else sword.Info();
                    }
                    break;
                case 4:
                    enemy.Look();
                    break;
                case 5:
                    player.Stats(player);
                    break;
                
            }
        }

    }
}
