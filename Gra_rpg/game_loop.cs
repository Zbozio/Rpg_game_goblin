using Gra_rpg.Characters;
using Gra_rpg.Przedmioty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg
{
    public class Game_loop
    {
        public void Game(Player player,Enemy enemy,Item sword,Item ice,int stage,ref int smth)
        {
            Console.WriteLine("What kind of attack");
            Console.WriteLine("1. Normal Attack");
            Console.WriteLine("2. \u001b[34mIce Attack\u001b[0m (5 mana cost)");
            Console.WriteLine("3. --Exit--");
            Console.Write("> ");
            int choice=Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                player.Attack(enemy, sword);
                if (player.Mana < 10) player.Mana += 1;
                if (enemy.Health<=0)
                {
                    Console.WriteLine($"{enemy.Name} has been defeated!");
                    Console.WriteLine($"{enemy.Name} drops {enemy.Loot}");
                    player.Inventory.Add(enemy.Loot);
                    smth += 1;
                }
                else
                {
                    enemy.Attack(player, stage);
                    {
                        if (player.Health<=0)
                        {
                            Console.Clear();
                            
                            Console.WriteLine("   ___                         ___                 \r\n  / _ \\__ _ _ __ ___   ___    /___\\__   _____ _ __ \r\n / /_\\/ _` | '_ ` _ \\ / _ \\  //  //\\ \\ / / _ \\ '__|\r\n/ /_\\\\ (_| | | | | | |  __/ / \\_//  \\ V /  __/ |   \r\n\\____/\\__,_|_| |_| |_|\\___| \\___/    \\_/ \\___|_|   \r\n                                                   ");
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("You have been defeated!");
                            Console.Write("Press ENTER to close a game");
                            Console.ReadKey();
                            Environment.Exit(0);


                        }
                    }
                }
            }
            if (choice == 2)
            {
                player.Mana_skill(player, enemy, ice);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Name} has been defeated!");
                    Console.WriteLine($"{enemy.Name} drops {enemy.Loot}");
                    player.Inventory.Add(enemy.Loot);
                    smth += 1;
                    
                }
                else
                {
                    enemy.Attack(player, stage);
                    {
                        if (player.Health <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("   ___                         ___                 \r\n  / _ \\__ _ _ __ ___   ___    /___\\__   _____ _ __ \r\n / /_\\/ _` | '_ ` _ \\ / _ \\  //  //\\ \\ / / _ \\ '__|\r\n/ /_\\\\ (_| | | | | | |  __/ / \\_//  \\ V /  __/ |   \r\n\\____/\\__,_|_| |_| |_|\\___| \\___/    \\_/ \\___|_|   \r\n                                                   ");
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("You have been defeated");
                            Console.Write("Press ENTER to close a game");
                            Console.ReadKey();
                            Environment.Exit(0);


                        }
                    }
                }
            }
        }
    }
}
