using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaGame
{
    abstract class Monster
    {
        public int hp { get; set; }
        public int damage { get; set; }
        protected Random random = new Random();
 
    }

    class Spider : Monster
    {
        public Spider()
        {
            hp = 10;
            damage = random.Next(2, 4);
        }

    }

    class Troll : Monster
    {
        public Troll()
        {
            hp = 15;
            damage = random.Next(3, 6);
        }

    }

    class Dragon : Monster
    {
        public Dragon()
        {
            hp = 20;
            damage = random.Next(4, 8);
        }

    }
}
