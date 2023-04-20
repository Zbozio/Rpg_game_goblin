using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg
{
    public class Intro
    {
        public void Intro_()
        {
            Console.WriteLine("   ___      _     _ _         __ _                       \r\n  / _ \\___ | |__ | (_)_ __   / _\\ | __ _ _   _  ___ _ __ \r\n / /_\\/ _ \\| '_ \\| | | '_ \\  \\ \\| |/ _` | | | |/ _ \\ '__|\r\n/ /_\\\\ (_) | |_) | | | | | | _\\ \\ | (_| | |_| |  __/ |   \r\n\\____/\\___/|_.__/|_|_|_| |_| \\__/_|\\__,_|\\__, |\\___|_|   \r\n                                         |___/           ");
            Console.WriteLine("-------------");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("-------------");
            Console.Write("> ");

        }
    }
}
