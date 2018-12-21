using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AkademiaGame
{
    abstract class Character
    {
        public int hp { get; set; }
        protected int shield { get; set; }
        protected int damage { get; set; }
        protected int potionAumount { get; set; }
        protected Random random = new Random();

        public abstract void Attack(Monster monster);
        public abstract void UsePotion();
        public void MonsterisDead(Monster monster)
        {
            if (monster.hp <= 0)
            {
                hp += 5;
                Program.PrintLetters("Gratulacje udało Ci się pokonać potwora i przejść do następnego poziomu");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

    }

    class Warrior : Character
    {
        public Warrior()
        {
            hp = 15;
            shield = 5;
            damage = random.Next(3, 6);
            potionAumount = 3;
        }
        public override void Attack(Monster monster)
        {

            if (monster is Spider)
            {
                monster.hp -= damage;
                if (monster.hp <= 0)
                    monster.hp = 0;
                Console.WriteLine($"Życie pająka:{monster.hp}");
                Thread.Sleep(2000);

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
            if (potionAumount > 0)
            {
                hp += random.Next(2, 4);
                potionAumount--;
            }
            else
            {
                Console.WriteLine("Nie posiadasz juz butelek");
            }
            Console.Clear();
        }
    }
}
