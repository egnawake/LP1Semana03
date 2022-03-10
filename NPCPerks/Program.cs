using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNpcs;
            Perk[] npcPerks;

            string inp;

            // get number of NPCs to create
            Console.WriteLine("Enter number of NPCs:");
            inp = Console.ReadLine();
            totalNpcs = int.Parse(inp);

            npcPerks = new Perk[totalNpcs];

            // display possible perks
            Console.WriteLine("Perks:");
            Console.WriteLine("  (1) Stealth");
            Console.WriteLine("  (2) Combat");
            Console.WriteLine("  (3) Lockpick");
            Console.WriteLine("  (4) Luck");
            Console.WriteLine("Choose perks for each NPC (enter 0 to finish)");

            Console.WriteLine($"{Perk.Luck | Perk.Stealth}");
        }
    }
}