using System;

namespace UberGame
{
    class Game
    {
        UI ui = new UI();
        Character hero, villain;
        MusicBox mb = null;

        public void Start() {
            mb = new MusicBox();
            hero = new Character();
            villain = new Character();
            mb.IntroMusic();
            

            ui.AskCharacterStats(ref hero);
            villain.InitVillain();
            Console.WriteLine(villain.GetName() + " appears!");
            FightingLoop();
            mb.PlayDramaticSound();
            Winner();



        }

        public void FightingLoop()
        {
            Random r = new Random();
            do
            {
                Console.WriteLine("Choose your attack 1. Strong attack 2. Throat slice");
                villain.Attack(Console.ReadLine());
                mb.BattleMusic();
                Console.WriteLine(hero.GetName() + " hits " + villain.GetName() + " with " + villain.GetDmg() + " damage");
                hero.Attack("1");
                mb.BattleMusic();
                Console.WriteLine(villain.GetName() + " hits " + hero.GetName() + " with " + hero.GetDmg() + " damage");

            } while (hero.GetHealth() > 0 || villain.GetHealth() > 0);
        }
        public void Winner()
        {
            if (hero.GetHealth() > villain.GetHealth())
            {
                Console.WriteLine(hero.GetName() + " wins the game!");
            }
            else
            {
                Console.WriteLine("You died!");
            }
        }
    }
}
