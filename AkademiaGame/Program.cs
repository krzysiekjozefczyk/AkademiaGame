﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AkademiaGame
{
    class Program
    {
        private static void Fight(Character character, Monster monster)
        {
            while (monster.hp > 0)
            {
                if(character.hp <= 0)
                {
                    PrintLetters("Niestety nie udało Ci się pkonać wszytskich stwrów ");
                    Thread.Sleep(2000);
                    return;
                }

                Console.WriteLine($"Życie postaci: { character.hp}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Wybierz co chcesz zrobić.");
                if (character is Warrior)
                {
                    Console.WriteLine("1 - Atakuj");
                    Console.WriteLine("2 - Ulecz się");
                }
                else if(character is Mage)
                {
                    Console.WriteLine("1 - Użyj zaklęcia");
                    Console.WriteLine("2 - Ulecz się");
                    Console.WriteLine("3 - Zregeneruj mane");
                    Console.WriteLine($"Ilość many: {character.mana}");
                }
                Console.Write("Wybór: ");

                int chooseAction = Int32.Parse(Console.ReadLine());

                switch (chooseAction)
                {
                    case 1:
                        character.Attack(monster);
                        break;
                    case 2:
                        character.UsePotion();
                        break;
                    case 3:
                        character.UseManaPotion();
                            break; 
                }
            }

        }


        public static void PrintLetters(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Character warrior = new Warrior();
            Character mage = new Mage();

            Monster spider = new Spider();
            Monster troll = new Troll();
            Monster dragon = new Dragon();


            PrintLetters("Witaj za chwile pojawi się wybór postaci.");
            Thread.Sleep(2000);
            Console.Clear();

            PrintLetters("Wybierz swoją postać.");
            Console.WriteLine("1 - Wojownik");
            Console.WriteLine("2 - Mag");
            Console.WriteLine("3 - Łucznik");
            Console.Write("Wybór: ");

            int choosePlayer = Int32.Parse(Console.ReadLine());

            switch (choosePlayer)
            {
                case 1:
                    PrintLetters("Grasz jako wojownik. Twoim zadaniem jest pokonaie 3 potworów. Z każdym kolejnym poziomem przeciwnicy będą trudniejsi do pokoania.Lecz za każdego pokonanego stwora otrzymujesz dodatkowe zadawane obrażenia. Z potwora może wypaść uzdrawiający napój. Na start masz ich 3. Powodzenia! ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    while (warrior.hp > 0)
                    {
                        Fight(warrior, spider);
                        Fight(warrior, troll);
                        Fight(warrior, dragon);
                    }
                    break;
                case 2:
                    PrintLetters("Grasz jako Mag. Twoim zadaniem jest pokonaie 3 potworów. Z każdym kolejnym poziomem przeciwnicy będą trudniejsi do pokoania.Lecz za każdego pokonanego stwora otrzymujesz dodatkowe zadawane obrażenia oraz regeneruje ci się mana. Z potwora może wypaść uzdrawiający napój. Na start masz ich 3. Powodzenia! ");
                    Thread.Sleep(2000);
                    while(mage.hp > 0)
                    {
                        Fight(mage, spider);
                        Fight(mage, troll);
                        Fight(mage, dragon);
                    }
                    Console.Clear();
                    break;
                case 3:
                    PrintLetters("Grasz jako Łucznik. Twoim zadaniem jest pokonaie 3 potworów. Z każdym kolejnym poziomem przeciwnicy będą trudniejsi do pokoania.Lecz za każdego pokonanego stwora otrzymujesz dodatkowe zadawane obrażenia oraz strzały. Z potwora może wypaść uzdrawiający napój. Na start masz ich 3. Powodzenia! ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                default:
                    PrintLetters("Nie ma takiego wyboru");
                    break;
            }
        }


    }
}

