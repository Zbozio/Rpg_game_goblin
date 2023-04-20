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
    public class Stage3
    {
        public void Stage(GameObject myGameObject, Game_loop game_loop, Player player, Enemy enemy2, Item sword, Item ice, ref int stage, ref int count, ref int counter, Item potion,Load lod,Save save,ref int smth)
        {
            if (smth==3)
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
            Console.WriteLine("You see the king's chamber in front of you. Are you going to come in?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("You encountered a monster who is responsible for all the problems in your village");
                while (player.Health > 0 && enemy2.Health > 0)
                {
                    myGameObject.Menu();
                    var choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            {
                                game_loop.Game(player, enemy2, sword, ice, stage,ref smth);
                                if (enemy2.Health <= 0)
                                {
                                    Console.WriteLine("You successfully cleared this cave");
                                    Console.WriteLine("Press ENTER to close a game");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }
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
                                int choice2 = Convert.ToInt32(Console.ReadLine());
                                if (choice2 == 1 && counter == 0)
                                {
                                    player.Pick_up(sword);
                                    sword.Value = 5;
                                    counter++;
                                }
                                else if (choice2 == 2 && count == 0)

                                {
                                    potion.Healing(player,potion);
                                    potion.Value = 0;
                                    count++;
                                }
                                else if (choice2 == 3) continue;
                                else sword.Info();
                            }
                            break;
                        case 4:
                            enemy2.Look();
                            break;
                        case 5:
                            player.Stats(player);
                            break;
                       
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("You manage to escape from a goblin cave!");
                Console.WriteLine("Press ENTER to close a game");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
