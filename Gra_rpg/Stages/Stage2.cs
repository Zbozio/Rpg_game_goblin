using Gra_rpg.Characters;
using Gra_rpg.Przedmioty;
using Gra_rpg.Save_Load;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Stages
{
    public class Stage2
    {
        public void Stage(GameObject myGameObject, Game_loop game_loop, Player player, Enemy enemy1, Item sword, Item ice, ref int stage, ref int count, ref int counter, Item potion, Save save,Load lod,ref int smth)
        {
            if (smth==2)
            {
                Console.WriteLine("Do you wish to save a game?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("> ");
                int choiceee = Convert.ToInt32(Console.ReadLine());
                if (choiceee == 1)
                {
                    save.Save_(player, ref stage,sword,potion,ref smth);

                }
            }


            Console.WriteLine("Where do you want to go");
                Console.WriteLine("1. Right");
                Console.WriteLine("2. Left");
                Console.Write("> ");
                smth = 2;
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("You encountered a goblin knight that decided to attack you");
                    while (player.Health > 0 && enemy1.Health > 0)
                    {
                        myGameObject.Menu();
                        var choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                {
                                    game_loop.Game(player, enemy1, sword, ice, stage,ref smth);
                                    if (enemy1.Health <= 0) stage += 1;
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
                                    Console.WriteLine("--Exit--");
                                Console.Write("> ");
                                int choice1 = Convert.ToInt32(Console.ReadLine());
                                    if (choice1 == 1 && counter == 0)
                                    {
                                        player.Pick_up(sword);
                                        sword.Value = 5;
                                        counter++;
                                    }
                                    else if (choice1 == 2 && count == 0)

                                    {
                                        potion.Healing(player,potion);
                                        potion.Value = 0;
                                        count++;
                                    }
                                    else if (choice1 == 3) continue;
                                    else sword.Info();
                                }
                                break;
                            case 4:
                                enemy1.Look();
                                break;
                            case 5:
                                player.Stats(player);
                                break;
                           
                        }
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You fell into a trap and you are dead");
                    Console.WriteLine("Press ENTER to close a game");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            
        }

    }

}