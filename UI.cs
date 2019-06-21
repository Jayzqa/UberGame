using System;

namespace UberGame
{
    class UI
    {
        public void AskCharacterStats(ref Character thisDude)
        {
            Console.WriteLine("Give Character a name: ");
                thisDude.SetName(Console.ReadLine());

                Console.WriteLine("Choose characters class (Warrior, Rogue)");
                thisDude.SetClass(Console.ReadLine());

                Console.WriteLine("Mighty {5} named {0} is ready to fight!", thisDude.GetName(), thisDude.GetStats().Item1, thisDude.GetStats().Item2, thisDude.GetStats().Item3, thisDude.GetStats().Item4, thisDude.GetClass());

        }
    }
}
