using System;

namespace NPCPerks
{
    [Flags]
    public enum Perk
    {
        Stealth = 1 << 0,
        Combat = 1 << 1,
        Lockpick = 1 << 2,
        Luck = 1 << 3
    }
}