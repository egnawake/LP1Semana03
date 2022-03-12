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
            Console.WriteLine("Perks: stealth, combat, lockpick, luck");
            Console.WriteLine("Choose perks for each NPC (enter \"done\" to finish)");

            // for each NPC, ask for perks
            for (int i = 0; i < totalNpcs; i++)
            {
                Console.WriteLine($"NPC {i}");

                inp = "";
                while (inp != "done")
                {
                    inp = Console.ReadLine();

                    switch (inp)
                    {
                        case "done":
                            break;
                        case "stealth":
                            npcPerks[i] = npcPerks[i] | Perk.Stealth;
                            break;
                        case "combat":
                            npcPerks[i] = npcPerks[i] | Perk.Combat;
                            break;
                        case "lockpick":
                            npcPerks[i] = npcPerks[i] | Perk.Lockpick;
                            break;
                        case "luck":
                            npcPerks[i] = npcPerks[i] | Perk.Luck;
                            break;
                        default:
                            Console.WriteLine("Invalid perk, try again");
                            break;
                    }
                }
            }

            // show perks for each NPC
            for (int i = 0; i < npcPerks.Length; i++)
            {
                Console.WriteLine($"NPC {i}: {npcPerks[i]}");

                // if NPC has combat and luck, show special message
                Perk invincible = Perk.Combat | Perk.Luck;
                if ((npcPerks[i] & invincible) == invincible) {
                    Console.WriteLine("You shall win all fights!");
                }
            }
        }
    }
}