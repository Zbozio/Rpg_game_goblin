using Gra_rpg.Characters;
using Gra_rpg.Przedmioty;
using Gra_rpg.Save_Load;
using Gra_rpg.Stages;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gra_rpg
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int count = 0;
            int counter = 0;
            int stage = 1;

            Random random = new Random();
            GameObject myGameObject = new GameObject("Name", "description");
            Game_loop gameloop = new Game_loop();
            Stage1 stage1 = new Stage1();
            Stage2 stage2 = new Stage2();
            Stage3 stage3 = new Stage3();
            List<string> dropListGoblin = new List<string> { "Gold", "an Apple" };
            List<string> dropListGoblin1 = new List<string> { "Helmet", "Boots", "Sword" };
            List<string> dropListGoblin2 = new List<string> { "Great Sword", "Goblin Crown", "Magic Staff" };
            int index = random.Next(dropListGoblin.Count);
            string string_random = dropListGoblin[index];
            int index1 = random.Next(dropListGoblin1.Count);
            string string_random1 = dropListGoblin1[index1];
            int index2 = random.Next(dropListGoblin2.Count);
            string string_random2 = dropListGoblin2[index2];
            int smth = 1;
            Intro intro = new Intro();
            Load lod = new Load();
            Save save = new Save();
            Item sword = new Item("Sword", "A shiny sword", 0);
            Item potion = new Item("Potion", "A red potion", 25);
            Item ice = new Item("Ice Nova", "Cold one", 20);
            Player player = new Player("Player", "A brave adventurer", 100, 10, new List<string>(), 10);
            Enemy enemy = new Enemy("Goblin", "A small, green creature", 30, 5, string_random);
            Enemy enemy1 = new Enemy("Goblin Knight", "A small strong, green creature", 50, 5, string_random1);
            Enemy enemy2 = new Enemy("Goblin King", "A big chungus", 120, 5, string_random2);

            intro.Intro_();
            int chs = Convert.ToInt32(Console.ReadLine());

            {

                if (chs == 1)
                {
                    Console.WriteLine("You entered a golbin cave");
                    Console.WriteLine("             ,      ,\r\n            /(.-\"\"-.)\\\r\n        |\\  \\/      \\/  /|\r\n        | \\ / =.  .= \\ / |\r\n        \\( \\   o\\/o   / )/\r\n         \\_, '-/  \\-' ,_/\r\n           /   \\__/   \\\r\n           \\ \\__/\\__/ /\r\n         ___\\ \\|--|/ /___\r\n       /`    \\      /    `\\\r\n      /       '----'       \\");
                    Console.WriteLine("A small green creature notices you and decide to attack you");
                    while (player.Health > 0 && enemy.Health > 0)
                        if (stage == 1)
                        {


                            {
                                stage1.Stage(myGameObject, gameloop, player, enemy, sword, ice, ref stage, ref count, ref counter, potion, lod, ref smth);
                            }
                        }
                    if (stage == 2)
                    {
                        stage2.Stage(myGameObject, gameloop, player, enemy1, sword, ice, ref stage, ref count, ref counter, potion, save, lod, ref smth);
                    }
                    if (stage == 3)
                    {
                        stage3.Stage(myGameObject, gameloop, player, enemy2, sword, ice, ref stage, ref count, ref counter, potion, lod, save, ref smth);
                    }
                }
                else if (chs == 2)
                {
                    lod.Load_(player, ref stage, ref smth,sword,potion);
                  

                    if (stage == 1)
                    {


                        
                            stage1.Stage(myGameObject, gameloop, player, enemy, sword, ice, ref stage, ref count, ref counter, potion, lod, ref smth);
                        }
                    }
                    if (stage == 2)
                    {
                        stage2.Stage(myGameObject, gameloop, player, enemy1, sword, ice, ref stage, ref count, ref counter, potion, save, lod, ref smth);
                    }
                    if (stage == 3)
                    {
                        stage3.Stage(myGameObject, gameloop, player, enemy2, sword, ice, ref stage, ref count, ref counter, potion, lod, save, ref smth);
                    }
                }
            }






        }




    }



