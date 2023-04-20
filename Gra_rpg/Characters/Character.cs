using Gra_rpg.Przedmioty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_rpg.Characters
{
    public class Character:GameObject
    {
        public int Health { get; set; }
        public int Attack_points { get; set; }
        public Character(string name,string description,int health,int attack_points)
            :base(name, description)
            
        {
            
            this.Health=health;
            this.Attack_points=attack_points;
        }
    }
}
