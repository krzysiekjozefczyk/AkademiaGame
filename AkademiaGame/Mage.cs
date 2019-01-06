using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AkademiaGame
{
    class Mage : Character

    {
        protected int manaPotionAmount { get; set; }
        public Mage()
        {
            hp = 10;
            mana = 20;
            potionAumount = 3;
            manaPotionAmount = 5;

        }
        public override void Attack(Monster monster)
        {
            if (monster is Spider)
            {
                monster.hp -= damage;
                mana -= random.Next(2, 5);

                if (monster.hp <= 0)
                    monster.hp = 0;

                Console.WriteLine($"Życie pająka:{monster.hp}");
                System.Threading.Thread.Sleep(2000);

                MonsterisDead(monster);


                if (monster.hp > 0)
                {
                    Console.WriteLine("Pająk atakuje!");
                    hp -= monster.damage;
                }

                Thread.Sleep(2000);
                Console.Clear();
            }

            if (monster is Troll)
            {
                monster.hp -= damage;
                mana -= random.Next(2, 5);
                if (monster.hp <= 0)
                    monster.hp = 0;
                Console.WriteLine($"Życie trolla: {monster.hp}");
                Thread.Sleep(2000);

                MonsterisDead(monster);

                if (monster.hp > 0)
                {
                    Console.WriteLine("Troll atakuje!");
                    hp -= monster.damage;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }

            if (monster is Dragon)
            {
                monster.hp -= damage;
                mana -= random.Next(2, 5);
                if (monster.hp <= 0)
                    monster.hp = 0;
                Console.WriteLine($"Życie smoka: {monster.hp}");
                Thread.Sleep(2000);

                MonsterisDead(monster);

                if (monster.hp > 0)
                {
                    Console.WriteLine("Smok atakuje!");
                    hp -= monster.damage;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        public override void UsePotion()
        {
            throw new NotImplementedException();
        }

        public override void UseManaPotion()
        {
            if (manaPotionAmount > 0)
            {
                mana += 3;
                manaPotionAmount--;
            }
        }


    }
}
